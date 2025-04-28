using System;
using System.IO;
using System.Linq;

namespace pr16_1_Shengals
{
    class Program
    {
        static void Main(string[] args)
        {
            int count = 0;
            using (StreamReader file = new StreamReader("text.txt"))
            {
                try
                {
                    string text = file.ReadToEnd();
                    if (string.IsNullOrEmpty(text))
                    {
                        Console.WriteLine("В вашем файле нету текста.");
                        return;
                    }
                    Console.WriteLine(text);
                    text = text.ToLower();


                    Console.Write("Введите слово для поиска: ");
                    string a = Convert.ToString(Console.ReadLine());
                    if (string.IsNullOrEmpty(a))
                    {
                        Console.WriteLine("Вы не ввели слово для поиска пожалуйста попробуйте снова!");
                        return;
                    }
                    a = a.ToLower();


                    string[] words = text.Split();
                    foreach (string word in words)
                    {
                        if (word.Contains(a))
                        {
                            count++;
                        }
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine($"Произошла ошибка: {ex.Message}");
                }
                Console.WriteLine($"Количество вхождений слова которое вы указали: {count}");
            }

        }
    }
}
