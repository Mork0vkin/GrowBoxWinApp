# 🥦🥬🧅 Приложение GrowBox для Windows 🧅🥬🥦

🥦 Введение
---
 ***!!! ПРОГРАММА В СТАДИИ РАЗРАБОТКИ !!!***
 
**Описание:**

Программа для настройки и управления подключенными модулями к микроконтроллеру Arduino Nano через USB-интерфейс.
Разрабатывается для курсового проекта. Также возможно будет доработана до диплома.

**Реализуемые функции:**

 - Настройка периода освещения;
 - Настройка температуры для включения вентиляции;
 - Время и длительность полива;
 - и прочие настройки.

P.S. За ошибки сильно не пинать😅
Только недавно начал изучать все это.

🥦 Скетчи
---
 - Скетч без функции управления с компьютера [GrowBox_PC.ino](Arduino/GrowBox_no_PC/GrowBox_PC.ino "Открыть код")⬇️
 - Скетч с функцией управления с компьютера [GrowBox_PC_beta.ino](Arduino/GrowBox_PC_beta/GrowBox_PC_beta.ino "Открыть код")⬇️

🥦 Библиотеки
---
 - [ArduinoThread](Arduino/libraries/ArduinoThread.zip "Скачать")⬇️
 - [DS3231](Arduino/libraries/DS3231.zip "Скачать")⬇️
 - [LCD_1602_RUS.zip](Arduino/libraries/LCD_1602_RUS.zip "Скачать")⬇️
 - [LiquidCrystal_I2C](Arduino/libraries/LiquidCrystal_I2C_V112.zip "Скачать")⬇️

🥦 Используемые модули
---
 - [Адаптер питания DC 12V 3A](https://ru.aliexpress.com/item/32966888452.html?spm=a2g0s.9042311.0.0.419933edt8Hdgs "Перейти по ссылке")💲
 - [Водяной насос 5V ~ 12V](https://ru.aliexpress.com/item/33035325360.html?spm=a2g0s.9042311.0.0.419933edt8Hdgs "Перейти по ссылке")💲
 - [Силиконовая трубка для насоса](https://ru.aliexpress.com/item/32919412958.html?spm=a2g0o.productlist.0.0.30512d6d4r5uQa&algo_pvid=1865452c-eee2-457e-999e-c3d2630fed97&algo_expid=1865452c-eee2-457e-999e-c3d2630fed97-0&btsid=937a90ed-43a6-4da4-b1a3-34757ed37405&ws_ab_test=searchweb0_0,searchweb201602_5,searchweb201603_52 "Перейти по ссылке")💲
 - [Светодиодная лента 5730, 5м, Белый цвет](https://ru.aliexpress.com/item/32474298457.html?spm=a2g0s.9042311.0.0.274233edDdZxHl "Перейти по ссылке")💲
 - [ЖК-модуль LCD1602](https://ru.aliexpress.com/item/32763867041.html?spm=a2g0s.9042311.0.0.274233edWMfKGk "Перейти по ссылке")💲
 - [Arduino Nano 3,0 Atmega328](https://ru.aliexpress.com/item/32353404307.html?spm=2114.13010708.0.0.339433edzJWzNM "Перейти по ссылке")💲
 - [Плата расширения Arduino Nano](https://ru.aliexpress.com/item/32346681480.html?spm=2114.13010708.0.0.339433edzJWzNM "Перейти по ссылке")💲
 - [Соединительный провод для Arduino](https://ru.aliexpress.com/item/32343840673.html?spm=2114.13010708.0.0.339433edzJWzNM "Перейти по ссылке")💲
 - [Реле 4-х канальный](https://ru.aliexpress.com/item/32970231202.html?spm=a2g0v.12010615.8148356.8.6e024298oPkc6B "Перейти по ссылке")💲
 - [Часы реального времени DS3231](https://ru.aliexpress.com/item/32807883422.html?spm=a2g0s.9042311.0.0.274233edxiFjsg "Перейти по ссылке")💲

🥦 Схема подключения модулей к Arduino
---
![Схема подключения модулей к Arduino](Arduino/images/scheme.jpg)
