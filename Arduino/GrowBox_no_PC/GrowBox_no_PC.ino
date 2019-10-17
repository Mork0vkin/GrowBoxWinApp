
#include <Thread.h>               // Библиотека для работы с псевдопотоками
#include <DS3231.h>               // Библиотека для работы с часами реального времени
#include <LCD_1602_RUS.h>         // Библиотека для работы дисплея с поддержкой русского языка


// Вписывайте ваши значения
#define FAN_IN_PIN 8              // Реле №1. Пин вентилятора на вдув
#define FAN_OUT_PIN 9             // Реле №2. Пин вентилятора на выдув
#define POMPA_PIN 10              // Реле №3. Пин помпы
#define LED_PIN 11                // Реле №4. Пин лампы

DS3231  rtc(5, 4);                // Создаём объект для работы с часами реального времени. Пины rtc(sda,scl), rtc(D5,D4)

float MAX_TEMP = 25;              // Максимальная температура для растений
float MIN_TEMP = 17;              // Минимальная температура для растений

unsigned long VREMYA_POLIVA = 3000;       // Время полива.
unsigned long TH_TIME_TIMER = 1000;       // Таймер проверки времени и вывода на экран. НЕ МЕНЯТЬ.
unsigned long TH_FAN_TIMER = 60000;       // Таймер проверки температуры и вывода на экран. По умолчанию 60 секунд
unsigned long TH_LED_TIMER = 1800000;     // Таймер проверки освещения. По умолчанию 30 минут
// ------------------------

int pompa_i = 0;                          // Переменная для хранения состояния счетчика полива
unsigned long TIMER_POLIVA;               // Переменная для хранения начала времени полива

int Hor;              // часы
int Min;              // минуты
int Sec;              // секунлы
Time t;               // полное время
String Date_str;      // дата  
String Time_str;      // время

LCD_1602_RUS lcd(0x27, 16, 2);        // Создаём объект для работы с дисплеем. Показываем адрес и размерность дисплея. 2 строки, 16 столбцов. Отсчёт с 0

Thread TimeThread = Thread();     // Cоздаём поток вывода времени на дисплей
Thread FanThread = Thread();      // Cоздаём поток вывода температуры на дисплей
Thread LedThread = Thread();      // Cоздаём поток включения света

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


// ################################################## КОНФИГ ПРОГРАММЫ ##################################################
void setup() {
  // Инициируем работу с часами
  rtc.begin();

  // Установка времени вручную. Выполняеть один раз.
  rtc.setDOW(WEDNESDAY);     	      // день недели на английском. TUESDAY
  rtc.setTime(15, 57, 40);         // 13:00:00 (24-х часовой формат)
  rtc.setDate(16, 10, 2019);       // 30.09.2019

  // Начало работы дисплея
  lcd.init(); 			                // инициализация дисплея
  lcd.backlight();		              // включение подсветки дисплея
  lcd.clear(); 			                // очищаем экран

  // Активации управления реле
  digitalWrite(POMPA_PIN, HIGH);
  pinMode(POMPA_PIN, OUTPUT);
  digitalWrite(LED_PIN, HIGH);
  pinMode(LED_PIN, OUTPUT);
  digitalWrite(FAN_IN_PIN, HIGH);
  pinMode(FAN_IN_PIN, OUTPUT);
  digitalWrite(FAN_OUT_PIN, HIGH);
  pinMode(FAN_OUT_PIN, OUTPUT);
  
  //Назначаем потокам их задачи и интервал срабатывания
  TimeThread.onRun(time_lcd);
  TimeThread.setInterval(TH_TIME_TIMER);  
  FanThread.onRun(fan_on_off);
  FanThread.setInterval(TH_FAN_TIMER);
  LedThread.onRun(led_on_off);
  LedThread.setInterval(TH_LED_TIMER);

  // Создаем в памяти дисплея значки и выводим их
  lcd.createChar(1, WATER_ICON);
  lcd.createChar(2, LED_ICON);
  lcd.createChar(3, CELSIUS_ICON);

  lcd.setCursor(12, 0);
  lcd.print(L"\1");
  lcd.setCursor(13, 0);
  lcd.print(L"OFF");

  lcd.setCursor(12, 1);
  lcd.print(L"\2");

  // Активируем передачу данных через SERIAL порт
  now_time();
  Serial.begin(9600);
  Serial.println("ARDUINO: [" + Date_str + "] [" + Time_str + "] -  Загрузка ARDUINO завершена");

  // Начнем сразу при запуске выполнять функции включени света, вывода на дисплей времени и температуры
  time_lcd();
  led_on_off();
  fan_on_off ();
}
// ##############################################################################################################################


// ################################################### ОСНОВНОЙ КОД ПРОГРАММЫ ###################################################

void loop() {
  // ---------------- Проверяем, настало ли время работы потоков ------------------
  if (TimeThread.shouldRun()) TimeThread.run();
  if (FanThread.shouldRun()) FanThread.run();
  if (LedThread.shouldRun()) LedThread.run();

  // ---------- Заукаем постоянную работу с поливом и получением времени ----------
  poliv();
  now_time();
}
// ###############################################################################################################################



// ########################################################## ФУНКЦИИ ############################################################


// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ФУНКЦИЯ ПОЛИВА ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

void poliv () {
  if (Hor == 10 && Min == 00 && Sec == 00 && pompa_i == 0)
  {
    TIMER_POLIVA = millis();
    digitalWrite(POMPA_PIN, LOW);
    pompa_i = 1;
    lcd.setCursor(13, 0);
    lcd.print(L"ON ");
    Serial.println("ARDUINO: [" + Date_str + "] [" + Time_str + "] -  Идет полив...");
  }
  else if (pompa_i == 1 &&  ((millis() - TIMER_POLIVA) > VREMYA_POLIVA))
  {
    TIMER_POLIVA = millis();
    digitalWrite(POMPA_PIN, HIGH);
    pompa_i = 0;
    lcd.setCursor(13, 0);
    lcd.print(L"OFF");
    Serial.println("ARDUINO: [" + Date_str + "] [" + Time_str + "] -  Полив закончен");
  }
}

// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ФУНКЦИЯ ЗАПУСКА ОСВЕЩЕНИЯ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

void led_on_off () {
  if (Hor >= 9 && Hor < 22)
  {
    digitalWrite(LED_PIN, LOW);
    lcd.setCursor(13, 1);
    lcd.print(L"ON ");
    Serial.println("ARDUINO: [" + Date_str + "] [" + Time_str + "] -  Освещение включено");
  }
  else
  {
    digitalWrite(LED_PIN, HIGH);
    lcd.setCursor(13, 1);
    lcd.print(L"OFF");
    Serial.println("ARDUINO: [" + Date_str + "] [" + Time_str + "] -  Освещение выключено");
  }
}

// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ФУНКЦИЯ ЗАПУСКА ВЕНТИЛЯЦИИ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~
void fan_on_off () {
  lcd.setCursor(0, 0);
  lcd.print(rtc.getTemp());
  lcd.setCursor(5, 0);
  lcd.print(L"\3");
  if (lrint(rtc.getTemp()) >= MAX_TEMP)
  {
    digitalWrite(FAN_OUT_PIN, LOW);
    digitalWrite(FAN_IN_PIN, LOW);
    Serial.println("ARDUINO: [" + Date_str + "] [" + Time_str + "] -  Высокая температура воздуха. Вентиляторы запущены");
  }
  else if (lrint(rtc.getTemp()) <= MIN_TEMP){
    digitalWrite(FAN_OUT_PIN, HIGH);
    digitalWrite(FAN_IN_PIN, HIGH);
    Serial.println("ARDUINO: [" + Date_str + "] [" + Time_str + "] -  Низкая температура воздуха. Вентиляторы выключены");
    }
}

// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ФУНКЦИЯ ПОКАЗАНА ВРЕМЕНИ НА ДИСПЛЕЕ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

void time_lcd () {
  lcd.setCursor(0, 1);
  lcd.print(Time_str);
}

// ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~ ФУНКЦИЯ ДЛЯ РАБОТЫ СО ВРЕМЕНЕМ ~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~~

void now_time() {
  t = rtc.getTime();
  Hor = t.hour;
  Min = t.min;
  Sec = t.sec;
  Date_str = rtc.getDateStr();
  Time_str = rtc.getTimeStr();
}
