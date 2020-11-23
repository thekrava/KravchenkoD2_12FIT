# University_OOP_LB2

Laboratory work №2

Лабораторная работа № 2 по ООП

КНТЕУ ФИТ 
КИБЕРБЕЗОПАСНОСТЬ

2020

---------------------------------------------------------------------------------------------------------------------------------------------------------------------------------

Задание:

Лаборатоная 2

1. Создать класс с именем Address.

В теле класса требуется создать поля: index, country, city, street, house, apartment. Для каждого

поля, создать свойство с двумя методами доступа.

Создать экземпляр класса Address.

В поля экземпляра записать информацию о почтовом адресе.

Выведите на экран значения полей, описывающих адрес.

2. Используя Visual Studio, создайте проект по шаблону Console Application.

Требуется: Создать класс с именем Rectangle.

В теле класса создать два поля, описывающие длины сторон double side1, side2.

Создать пользовательский конструктор Rectangle(double side1, double side2), в теле которого

поля side1 и side2 инициализируются значениями аргументов.

Создать два метода, вычисляющие площадь прямоугольника - double AreaCalculator() и периметр

прямоугольника - double PerimeterCalculator().

Создать два свойства double Area и double Perimeter с одним методом доступа get.

Написать программу, которая принимает от пользователя длины двух сторон прямоугольника и выводит

на экран периметр и площадь.

3. Используя Visual Studio, создайте проект по шаблону Console Application.

Требуется:

Создать класс Book. Создать классы Title, Author и Content, каждый из которых должен содержать

одно строковое поле и метод void Show().

Реализуйте возможность добавления в книгу названия книги, имени автора и содержания.

Выведите на экран разными цветами при помощи метода Show() название книги, имя автора и

содержание.

4. Используя Visual Studio, создайте проект по шаблону Console Application.

Требуется:

Создать классы Point и Figure.

Класс Point должен содержать два целочисленных поля и одно строковое поле.

Создать три свойства с одним методом доступа get.

Создать пользовательский конструктор, в теле которого проинициализируйте поля значениями

аргументов. Класс Figure должен содержать конструкторы, которые принимают от 3-х до 5-ти

аргументов типа Point.

Создать два метода: double LengthSide(Point A, Point B), который рассчитывает длину

стороны многоугольника; void PerimeterCalculator(), который рассчитывает периметр

многоугольника.

Написать программу, которая выводит на экран название и периметр многоугольника.

5. Используя Visual Studio, создайте проект по шаблону Console Application.

Требуется:

Создать класс User, содержащий информацию о пользователе (логин, имя, фамилия, возраст, дата

заполнения анкеты). Поле дата заполнения анкеты должно быть проинициализировано только один раз

(при создании экземпляра данного класса) без возможности его дальнейшего изменения.

Реализуйте вывод на экран информации о пользователе.

6. Используя Visual Studio, создайте проект по шаблону Console Application.

Требуется:

Создать класс Converter.

В теле класса создать пользовательский конструктор, который принимает три вещественных аргумента,

и инициализирует поля соответствующие курсу 3-х основных валют, по отношению к гривне – public

Converter(double usd, double eur, double rub).

Написать программу, которая будет выполнять конвертацию из гривны в одну из указанных валют,

также программа должна производить конвертацию из указанных валют в гривну.

7. Используя Visual Studio, создайте проект по шаблону Console Application.

Требуется:

Создать класс Employee.

В теле класса создать пользовательский конструктор, который принимает два строковых аргумента, и

инициализирует поля, соответствующие фамилии и имени сотрудника.

Создать метод рассчитывающий оклад сотрудника (в зависимости от должности и стажа) и налоговый

сбор.

Написать программу, которая выводит на экран информацию о сотруднике (фамилия, имя, должность),

оклад и налоговый сбор.

8. Создать класс Invoice.

В теле класса создать три поля int account, string customer, string provider, которые должны

быть проинициализированы один раз (при создании экземпляра данного класса) без возможности их

дальнейшего изменения.

В теле класса создать два закрытых поля string article, int quantity

Создать метод расчета стоимости заказа с НДС и без НДС.

Написать программу, которая выводит на экран сумму оплаты заказанного товара с НДС или без НДС.
