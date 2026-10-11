//*************************************************************************************
//*Практическая работа №11                                                            *
//* Выполнила: Вохмянина А.Р., группа 2-ИСП                                           *
//* Задание: получение навыков работы с символьными данными или операциями над ними   *
//*************************************************************************************
using System;

namespace работа_11
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Практическая работа 11";

            try
            {
                Console.WriteLine("Здравствуйте!");
                Console.Write("Введите, пожалуйста, строку: ");

                string str = Console.ReadLine();

                if (string.IsNullOrWhiteSpace(str))
                {
                    throw new ArgumentException("Строка не должна быть пустой!");
                }

                string word = "student";
                char[] wordArray = word.ToCharArray();
                char[] str1 = str.ToLower().ToCharArray();

                bool result = true;

                for (int i = 0; i < wordArray.Length; i++)
                {
                    int countWord = 0;
                    int countStr = 0;

                    for (int j = 0; j < wordArray.Length; j++)
                    {
                        if (wordArray[i] == wordArray[j])
                        {
                            countWord++;
                        }
                    }

                    for (int j = 0; j < str1.Length; j++)
                    {
                        if (wordArray[i] == str1[j])
                        {
                            countStr++;
                        }
                    }

                    if (countStr < countWord)
                    {
                        result = false;
                        break;
                    }
                }

                if (result)
                {
                    Console.WriteLine(
                        "Все буквы слова student имеются в строке! УРА :)");
                }
                else
                {
                    Console.WriteLine(
                        "Не все буквы слова student имеются в строке!");
                }
            }
            catch (IndexOutOfRangeException ioorex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Ошибка!:" + ioorex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (FormatException fex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Ошибка!:" + fex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.DarkRed;
                Console.WriteLine("Ошибка!:" + ex.Message);
                Console.ForegroundColor = ConsoleColor.White;
            }
            Console.ReadKey();
        }
    }
}