using System;
using System.ComponentModel.Design;
using System.Security.Cryptography.X509Certificates;

namespace тр3
{
    internal class Program
    {
        static byte position = 1;
        static byte leftRuightPosition = 1;
        static void Main(string[] args)
        {
            bool qwe = true;
            while (qwe) { 
                ConsoleKeyInfo key = Console.ReadKey();
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");
                if (position > 2)
                {
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                }
                if(leftRuightPosition > 3)
                {
                    Menu1(leftRuightPosition = 1);
                }
                if (key.Key == ConsoleKey.DownArrow)
                {
                    position++;
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                }
                else if (key.Key == ConsoleKey.UpArrow)
                {
                    position--;
                    Console.SetCursorPosition(0, position);
                    Console.WriteLine("->");
                }
                Console.Clear();
                if (key.Key == ConsoleKey.LeftArrow)
                {
                    leftRuightPosition--;
                    Menu1(leftRuightPosition);
                }
                if (key.Key == ConsoleKey.RightArrow)
                {
                    leftRuightPosition++;
                  
                }
                Menu1(leftRuightPosition);
                Console.SetCursorPosition(0, position);
                Console.WriteLine("->");


            }

        }



        public static void Menu1(int i)
        {
            ConsoleKeyInfo key = Console.ReadKey();
            if (i == 1)
            {

                Console.WriteLine("     Выбрана дата: 01.02.2023");
                Console.WriteLine("     1.Сходить на пары");
                Console.WriteLine("     2.Погулять с собакой");
                if(position == 1 && key.Key== ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Сходить на пары");
                    Console.WriteLine("--------------");
                    Console.WriteLine("10:10 - 17:10 \n Со 2 по 4 пару");
                }
                if (position == 2 && key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Погулять с собакой");
                    Console.WriteLine("--------------");
                    Console.WriteLine("7:30, 17:00, 22:00 \n Не забудь погулять с собакой");
                }

            }
            else if (i == 2)
            {

                Console.WriteLine("     Выбрана дата: 02.02.2023");
                Console.WriteLine("     1.Прогулять пары");
                Console.WriteLine("     2.Выкинуть собаку");
                if (position == 1 && key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Прогулять пары");
                    Console.WriteLine("--------------");
                    Console.WriteLine("10:10 - 17:10 \n Со 2 по 4 пару прогулять в обязательном порядке");
                }
                if (position == 2 && key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Выкинуть собаку");
                    Console.WriteLine("--------------");
                    Console.WriteLine("12:00 \n Задолблся гулять с ней, холодно");
                }
            }
            else if (i == 3)
            {

                Console.WriteLine("     Выбрана дата: 03.02.2023");
                Console.WriteLine("     1.Сходить в магаз");
                Console.WriteLine("     2.Снять лям с карты");
                if (position == 1 && key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Сходить в магаз");
                    Console.WriteLine("--------------");
                    Console.WriteLine("18:00 \n Ну молока и пельмени надо все таки");
                }
                if (position == 2 && key.Key == ConsoleKey.Enter)
                {
                    Console.Clear();
                    Console.WriteLine("Снять лям с карты");
                    Console.WriteLine("--------------");
                    Console.WriteLine("12:00 \n Хоть какие-то копейки в кармане наликом нужно носить");
                }
            }
        }
    }
}
