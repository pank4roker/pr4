using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        { 
            try
        {
                //Задание 1
                //Определить, является или нет текущий год високосным? Год ввести с клавиатуры (Год является високосным, если он кратен 4).

                /*WriteLine("Введите год: ");
                int year = Convert.ToInt32(Console.ReadLine());

                if (year%4 == 0)
                {
                    WriteLine($"{year} - является високосным") ;
                }
                else
                {
                    WriteLine($"{year} - не является високосным");
                }*/

                //Задание 2
                //Определить, входит ли цена выбранного ноутбука в диапазон от 20 до 30 тыс. р.

                /*WriteLine("Введите цену ноутбука: ");
                int price = Convert.ToInt32(ReadLine());

                if(price > 20000 && price < 30000)
                {
                    WriteLine($"{price} - цена ноутбука подходит");
                }
                else
                {
                    WriteLine($"{price} - цена ноутбука не подходит");
                }

                string a = price > 20000 && price < 30000 ? "Цена подходит" : "Цена не подходит";
                WriteLine(a);*/

                //Задание 3
                //Написать программу, которая в зависимости от заданного балла определяет оценку учащегося согласно таблице
                /* Write("Введите балл: ");
                 int point = Convert.ToInt32(ReadLine());
                 if(point <= 59 && point > 0)
                 {
                     WriteLine("Оценка - неудовлетворительно");
                 }
                 else if (point <=74 && point >60)
                 {
                     WriteLine("Оценка - удовлетворительно");
                 }
                 else if(point <=75 && point>89)
                 {
                     WriteLine("Оценка - хорошо");
                 }
                 else if (point <=90 && point >=100)
                 {
                     WriteLine("Оценка - отлично");
                 }*/

                //Задание 4.
                //Светофор закодирован тремя состояниями: 1 – красный, 2 – желтый, 3 – зеленый.В зависимости от состояния определить цвет светофора.

                /*Random random = new Random();
                int color = random.Next(1, 3);
                Write("Cветофор закодирован ");
                switch (color)
                {
                    case 1:
                        WriteLine("красным цветом");
                        break;

                    case 2:
                        WriteLine("желтым цветом");
                        break;
                    case 3:
                        WriteLine("зеленым цветом");
                        break;
                }*/

                //Задание 5
                //Проверка знака случайного числа и его чётности.
                /*
                Random random = new Random();
                int count = random.Next(-100, 100);
                Write($"Число {count} является ");
                if (count % 2 == 0 & count > 0)
                {
                    WriteLine("четным и положительным");
                }
                else if (count % 2 == 0 & count < 0)
                {
                    WriteLine("четным и отрицательным");
                }
                else if (count % 2 != 0 & count > 0)
                {
                    WriteLine("нечетным и положительным");
                }
                else if (count % 2 != 0 & count < 0)
                {
                    WriteLine("нечетным и отрицательным");
                }*/

                //задание 6
                //Выбор дня недели
                /* Write("Enter the number from 1 to 7: ");
                 int day = Convert.ToInt32(ReadLine());
                 switch (day)
                 {
                     case 1:
                         WriteLine("Monday");
                         break;
                     case 2:
                         WriteLine("Thusday");
                         break;
                     case 3:
                         WriteLine("Wednesday");
                         break;
                     case 4:
                         WriteLine("Thursday");
                         break;
                     case 5:
                         WriteLine("Friday");
                         break;
                     case 6:
                         WriteLine("Saturday");
                         break;
                     case 7:
                         WriteLine("Sunday");
                         break;
                     default:
                         WriteLine("The number doesn't fit");
                         break;
                 }*/
                //Задание 7
                //Проверка логина и пароля введенных с клавиатуры
                /*WriteLine("Enter yours username: ");
                string log = ReadLine();
                WriteLine("Now enter your password: ");
                string pass = ReadLine();
                string log1 = "pank4";
                string pass1 = "1234";
                string a = log == log1 && pass == pass1 ? "you have successfully logged in!" : "This username or password does not work, try again(";
                WriteLine(a);
                */
                //Задание 8.
                //Простейший калькулятор на 4 действия.
                /*
                Write("Enter a = ");
                double a = Convert.ToDouble(ReadLine());
                Write("b = ");
                double b = Convert.ToDouble(ReadLine());
                Write("Enter the operation: ");
                string oper = ReadLine();

                switch (oper)
                {
                    case "+":
                        WriteLine($"{a} + {b} = {a + b}");
                        break;
                    case "-":
                        WriteLine($"{a} - {b} = {a - b}");
                        break;
                    case "*":
                        WriteLine($"{a} * {b} = {a * b}");
                        break;
                    case "/":
                        WriteLine($"{a} / {b} = {a / b}");
                        break;
                    default:
                        WriteLine("This operation doesn't exist.");
                        break;
                }*/
                //Задание 9
                // Вводится возраст человека и в консольное окно выводится возростная группа,к которой относится человек
                /*Write("Введите свой возраст: ");
                int age = Convert.ToInt32(ReadLine());
                if (age > 0 && age < 7) 
                {
                    WriteLine("preschool");
                }
                else if (age >= 7 && age <= 12)
                {
                    WriteLine("school");
                }
                else if (age >= 13 && age <= 18)
                {
                    WriteLine("teen");
                }
                else if (age >= 19 && age <= 30)
                {
                    WriteLine("youth");
                }
                else if (age >= 31 && age <= 55)
                {
                    WriteLine("aduits");
                }
                else if (age >= 56 && age <= 90)
                {
                    WriteLine("elderly");
                }
                else if (age > 90 )
                {
                    WriteLine("centenarians");
                }*/










            }
            catch (Exception ex)
            {
                WriteLine($"Исключение: {ex.Message}");
        WriteLine($"Метод: {ex.TargetSite}");
        WriteLine($"Трассировка стека: {ex.StackTrace}");
    }
    ReadKey();
}
    }
}
