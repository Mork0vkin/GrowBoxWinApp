
#include <Thread.h>               // Библиотека для работы с псевдопотоками
#include <DS3231.h>               // Библиотека для работы с часами реального времени
#include <LCD_1602_RUS.h>         // Библиотека для работы дисплея с поддержкой русского языка

#define FAN_PIN       9           // Реле №2. Пин вентилятора
#define POMPA_PIN     10          // Реле №3. Пин помпы
#define LED_PIN       11          // Реле №4. Пин светодиодной лампы

unsigned long TIMER_POLIVA;                 // Таймер полива
unsigned long VREMYA_POLIVA = 3000;         // Время полива

int Hor;          // часы
int Min;          // минуты
int Sec;          // секунлы
Time t;           // время целиком
String t_str;     // Переменная для хранения времени в виде текстовой строки
String d_str;     // Переменная для хранения даты в виде текстовой строки

DS3231  rtc(5, 4);                // Создаём объект для работы с часами реального времени. rtc(sda,scl), rtc(D5,D4)
LCD_1602_RUS lcd(0x27, 16, 2);    // Создаём объект для работы с дисплеем. Показываем адрес и размерность дисплея. 2 строки, 16 столбцов. Отсчёт с 0

Thread TimeThread = Thread();     // Cоздаём поток вывода времени на дисплей
Thread GradThread = Thread();     // Cоздаём поток вывода температуры на дисплей
Thread LedThread = Thread();      // Cоздаём поток включения света

int pompa_i = 0;  // Переменная для хранения состояния счетчика полива

// --------------- Иконки для вывода на дисплей -----------------
byte WATER_ICON[8] =
{
  B00100, B01110, B01110, B11111, B11111, B10111, B11111, B01110,     // Капля
};
byte LED_ICON[8] =
{
  B01110, B10001, B10101, B10101, B01110, B01110, B01110, B00100,     // Светодиодная лампа
};
byte CELSIUS_ICON[8] =
{
  B11000, B11000, B00011, B00100, B00100, B00100, B00100, B00011,     // Градусы
};
byte OBMEN_ICON[8] =
{
  B00100, B01010, B10101, B00100, B00100, B10101, B01010, B00100,     // Обмен данными
};

// --------- Переменные для работы с данными по SERIAL ---------

char divider = ' ';           // Разделитель между ключевым словом и значнием
char ending = ';';            // Конец строки (команды)


const char *headers[]  = { "led",  "pompa", "fan"};         // Ключевые слова
enum names { LED_SERIAL, POMPA_SERIAL, FAN_SERIAL};

names thisName;
byte headers_am = sizeof(headers) / 2;
uint32_t prsTimer;
String prsValue = "";
String prsHeader = "";
enum stages {WAIT, HEADER, GOT_HEADER, VALUE, SUCCESS};
stages parseStage = WAIT;
boolean recievedFlag;


// ------------------------------------- КОНФИГ ПРОГРАММЫ -------------------------------------
void setup() {
  // Инициируем работу с часами
  rtc.begin();

  // Установка времени вручную. Выполняеть один раз.
  //rtc.setDOW(TUESDAY);     	      // день недели на английском. TUESDAY
  //rtc.setTime(13, 21, 00);         // 13:00:00 (24-х часовой формат)
  //rtc.setDate(8, 10, 2019);       // 30.09.2019

  // Начало работы дисплея
  lcd.init(); 			                // инициализация дисплея
  lcd.backlight();		              // включение подсветки дисплея
  lcd.clear(); 			                // очищаем экран

  // Активации управления реле
  digitalWrite(POMPA_PIN, HIGH);
  pinMode(POMPA_PIN, OUTPUT);
  digitalWrite(LED_PIN, HIGH);
  pinMode(LED_PIN, OUTPUT);

  //Назначаем потокам их задачи и интервал срабатывания
  TimeThread.onRun(time_lcd);       // назначаем потоку задачу
  TimeThread.setInterval(1000);     // задаём интервал. 1 секунда
  GradThread.onRun(grad_lcd);
  GradThread.setInterval(30000);    // 30 секунд
  LedThread.onRun(led_on_off);
  LedThread.setInterval(1800000);   // 30 минут

  // Создаем в памяти дисплея значки и выводим их
  lcd.createChar(1, WATER_ICON);
  lcd.createChar(2, LED_ICON);
  lcd.createChar(3, CELSIUS_ICON);
  lcd.createChar(4, OBMEN_ICON);

  lcd.setCursor(12, 0);
  lcd.print(L"\1");
  lcd.setCursor(13, 0);
  lcd.print(L"OFF");

  lcd.setCursor(12, 1);
  lcd.print(L"\2");

  // Активируем передачу данных через SERIAL порт
  now_time();
  Serial.begin(9600);
  Serial.println("ARDUINO: [" + d_str + "] [" + t_str + "] -  Загрузка ARDUINO завершена");

  // Начнем сразу при запуске выполнять функции включени света, вывода на дисплей времени и температуры
  grad_lcd();
  time_lcd();
  led_on_off();
}


// ------------------------------------- ОСНОВНОЙ КОД ПРОГРАММЫ -------------------------------------

void loop() {
  // ---------- Проверяем, настало ли время работы потока ----------
  if (TimeThread.shouldRun()) TimeThread.run();
  if (GradThread.shouldRun()) GradThread.run();
  if (LedThread.shouldRun()) LedThread.run();

  // ---------- Заукаем постоянную работу с поливом и получением времени ----------
  poliv();
  now_time();

  // ---------- Парсим данные, поступаемые в порт ----------
  parsingSeparate();

  if (recievedFlag)
  {
    lcd.setCursor(10, 0);
    lcd.print(L"\4");
    recievedFlag = false;
    switch (thisName)
    {
      case LED_SERIAL:
        Serial.println("ARDUINO: [" + d_str + "] [" + t_str + "] -  Получено значение по SERIAL: 'led1 " + prsValue + ";'");
        if (prsValue == "on") {
          digitalWrite(LED_PIN, LOW);
          Serial.println("ARDUINO: [" + d_str + "] [" + t_str + "] -  Свет был включен вручную пользователем");
        }
        else if (prsValue == "off") {
          digitalWrite(LED_PIN, HIGH);
          Serial.println("ARDUINO: [" + d_str + "] [" + t_str + "] -  Свет был выключен вручную  пользователем");
        }
        else {
          Serial.println("ARDUINO: [" + d_str + "] [" + t_str + "] -  Ошибка значения, переданного по SERIAL: 'led1 " + prsValue + ";'");
        }
        break;
      case POMPA_SERIAL:
        Serial.println("ARDUINO: [" + d_str + "] [" + t_str + "] -  Получено значение по SERIAL: 'led1 " + prsValue + ";'");
        if (prsValue == "on") {
          digitalWrite(POMPA_PIN, LOW);
          Serial.println("ARDUINO: [" + d_str + "] [" + t_str + "] -  Полив был включен вручную  пользователем");
        }
        else if (prsValue == "off") {
          digitalWrite(POMPA_PIN, HIGH);
          Serial.println("ARDUINO: [" + d_str + "] [" + t_str + "] -  Полив был выключен вручную  пользователем");
        }
        else {
          Serial.println("ARDUINO: [" + d_str + "] [" + t_str + "] -  Ошибка значения, переданного по SERIAL: 'led1 " + prsValue + ";'");
        }
        break;
      case FAN_SERIAL:
        Serial.println("ARDUINO: [" + d_str + "] [" + t_str + "] -  Получено значение по SERIAL: 'led1 " + prsValue + ";'");
        if (prsValue == "on") {
          digitalWrite(FAN_PIN, LOW);
          Serial.println("ARDUINO: [" + d_str + "] [" + t_str + "] -  Вентиляция была включена вручную  пользователем");
        }
        else if (prsValue == "off") {
          digitalWrite(FAN_PIN, HIGH);
          Serial.println("ARDUINO: [" + d_str + "] [" + t_str + "] -  Вентиляция была выключена вручную  пользователем");
        }
        else {
          Serial.println("ARDUINO: [" + d_str + "] [" + t_str + "] -  Ошибка значения, переданного по SERIAL: 'led1 " + prsValue + ";'");
        }
        break;
    }
  }
}
// --------------------------------- КОНЕЦ ОСНОВНОГО КОДА ПРОГРАММЫ ---------------------------------





// ------------------------------------- ФУНКЦИЯ ПОЛИВА -------------------------------------

void poliv () {
  if (Hor == 10 && Min == 00 && Sec == 00 && pompa_i == 0)
  {
    TIMER_POLIVA = millis();
    digitalWrite(POMPA_PIN, LOW);
    pompa_i = 1;
    lcd.setCursor(13, 0);
    lcd.print(L"ON ");
    Serial.println("ARDUINO: [" + d_str + "] [" + t_str + "] -  Идет полив...");
  }
  else if (pompa_i == 1 &&  ((millis() - TIMER_POLIVA) > VREMYA_POLIVA))
  {
    TIMER_POLIVA = millis();
    digitalWrite(POMPA_PIN, HIGH);
    pompa_i = 0;
    lcd.setCursor(13, 0);
    lcd.print(L"OFF");
    Serial.println("ARDUINO: [" + d_str + "] [" + t_str + "] -  Полив закончен");
  }
}

// ------------------------------------- ФУНКЦИЯ ЗАПУСКА ОСВЕЩЕНИЯ -------------------------------------

void led_on_off () {
  if (Hor >= 9 && Hor < 22)
  {
    digitalWrite(LED_PIN, LOW);
    lcd.setCursor(13, 1);
    lcd.print(L"ON ");
    Serial.println("ARDUINO: [" + d_str + "] [" + t_str + "] -  Освещение включено");
  }
  else
  {
    digitalWrite(LED_PIN, HIGH);
    lcd.setCursor(13, 1);
    lcd.print(L"OFF");
    Serial.println("ARDUINO: [" + d_str + "] [" + t_str + "] -  Освещение выключено");
  }
}

// ------------------------------------- ФУНКЦИЯ ЗАПУСКА ОСВЕЩЕНИЯ -------------------------------------
void fan_on_off () {
  digitalWrite(FAN_PIN, LOW);
}

// ------------------------------------- ФУНКЦИЯ ПОКАЗАНА ВРЕМЕНИ НА ДИСПЛЕЕ -------------------------------------

void time_lcd () {
  lcd.setCursor(0, 1);
  lcd.print(t_str);
}

// ------------------------------------- ФУНКЦИЯ ДЛЯ РАБОТЫ СО ВРЕМЕНЕМ -------------------------------------

void now_time() {
  t = rtc.getTime();
  t_str = rtc.getTimeStr();
  d_str = rtc.getDateStr();
  Hor = t.hour;
  Min = t.min;
  Sec = t.sec;
}

// ------------------------------------- ФУНКЦИЯ ПОКАЗАНА ТЕМПЕРАТУРЫ НА ДИСПЛЕЕ -------------------------------------

void grad_lcd() {
  lcd.setCursor(0, 0);
  lcd.print(rtc.getTemp());
  lcd.setCursor(5, 0);
  lcd.print(L"\3");
}

// ------------------------------------- ФУНКЦИЯ ПАРСИНГА ДАННЫХ SERIAL -------------------------------------

/*
  Пример текстового интерфейса через монитор порта. Парсинг осуществляется через switch и встроенные методы работы со строками.
  Пример отправки: keyword 5; - ключевое слово keyword, значение 5.
  Взято отсюда: https://alexgyver.ru/arduino-algorithms/
*/

void parsingSeparate() {
  if (Serial.available() > 0)
  {
    if (parseStage == WAIT)
    {
      parseStage = HEADER;
      prsHeader = "";
      prsValue = "";
    }

    if (parseStage == GOT_HEADER)
      parseStage = VALUE;
    char incoming = (char)Serial.read();
    if (incoming == divider)
    {
      parseStage = GOT_HEADER;
    }
    else if (incoming == ending)
    {
      parseStage = SUCCESS;
    }
    if (parseStage == HEADER)
      prsHeader += incoming;
    else if (parseStage == VALUE)
      prsValue += incoming;
    prsTimer = millis();
  }
  if (parseStage == SUCCESS) {
    for (byte i = 0; i < headers_am; i++) {
      if (prsHeader == headers[i]) {
        thisName = i;
      }
    }
    recievedFlag = true;
    parseStage = WAIT;
  }
  if ((millis() - prsTimer > 10) && (parseStage != WAIT)) {
    parseStage = WAIT;
  }
}
