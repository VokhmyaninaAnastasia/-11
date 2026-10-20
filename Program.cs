//*************************************************************************************
//*Практическая работа №11                                                            *
//* Выполнила: Вохмянина А.Р., группа 2-ИСП                                           *
//* Задание: получение навыков работы с символьными данными или операциями над ними   *
//*************************************************************************************
using System;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Clear();
            Console.Title = "Практическая работа 11";
            Console.BackgroundColor = ConsoleColor.Black;
            Console.ForegroundColor = ConsoleColor.White;
            Console.WriteLine("Здравствуйте!");
            string str;

            do
            {
                Console.Write("Введите строку: ");
                str = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(str))
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine("Ошибка: строка не должна быть пустой!");

                    Console.ResetColor();
                }

            } while (string.IsNullOrWhiteSpace(str));

            try
            {
                string word = "student";
                char[] wordArray = word.ToCharArray();
                char[] str1 = str.ToLower().ToCharArray();

                bool result = true;

                for (int i = 0; i < wordArray.Length; i++)
                {
                    bool found = false;

                    for (int j = 0; j < str1.Length; j++)
                    {
                        if (wordArray[i] == str1[j])
                        {
                            found = true;

                            // Помечаем найденную букву,
                            // чтобы не использовать её повторно
                            str1[j] = '1';
                            break;
                        }
                    }

                    if (!found)
                    {
                        result = false;
                        break;
                    }
                }

                if (result)
                {
                    Console.Write("Все буквы слова student присутствуют в строке.");
                }
                else
                {
                    Console.Write("Не все буквы слова student присутствуют в строке.");
                }
            }
            catch (ArgumentException aex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Ошибка аргумента: " + aex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.Write("Непредвиденная ошибка: " + ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ReadKey();
        }
    }
}