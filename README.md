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
 - [Arduino Nano 3,0 Atmega328](https://ru.aliexpress.com/item/32531372300.html?gps-id=pcStoreLeaderboard&scm=1007.22922.122102.0&scm_id=1007.22922.122102.0&scm-url=1007.22922.122102.0&pvid=9446bc38-82cc-455f-be5a-9dfe9d0841d6&spm=a2g1y.12024536.smartLeaderboard_484303483.32531372300 "Перейти по ссылке")💲
 - [Соединительный провод для Arduino](https://ru.aliexpress.com/item/32822990940.html?spm=a2g0o.detail.1000013.4.39cc3e416t1Lmv&gps-id=pcDetailBottomMoreThisSeller&scm=1007.13339.146401.0&scm_id=1007.13339.146401.0&scm-url=1007.13339.146401.0&pvid=a368ef15-bc50-4ae3-893a-7f3f6f9f4f52 "Перейти по ссылке")💲
 - [Реле 4-х канальный](https://ru.aliexpress.com/item/32970231202.html?spm=a2g0v.12010615.8148356.8.6e024298oPkc6B "Перейти по ссылке")
 - [Часы реального времени DS3231](https://ru.aliexpress.com/item/32807883422.html?spm=a2g0s.9042311.0.0.274233edxiFjsg "Перейти по ссылке")💲

🥦 Схема подключения модулей к Arduino
---
![Схема подключения модулей к Arduino](Arduino/images/scheme.jpg)
