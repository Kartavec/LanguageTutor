using System;
using System.Collections.Generic;
using System.IO;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            var nums = GetArrayFromFile("path.txt");

        }

        static int[] GetArrayFromFile(string path)
        {
            try
            {
                string content = File.ReadAllText(path);
                var numString = content.Split(' ');
                List<int> nums = new List<int>();
                for (int i = 0; i < numString.Length; i++)
                {
                    int num;
                    if (Int32.TryParse(numString[i], out num))
                        nums.Add(num);

                    //try
                    //{
                    //    int num = Int32.Parse(numString[i]);
                    //    nums.Add(num);
                    //}
                    //catch (Exception){}
                }
                return nums.ToArray();
            }
            catch (Exception ex)
            {
                Console.WriteLine($"Не удалось считать содержимое файла {path}");
                return new int[0];
            }
        }
        static int GetRowCount(string path)
        {
            try
            {
                var rows = File.ReadAllLines(path);
                return rows.Length;
            }
            catch (FileNotFoundException ex)
            {
                //                Console.WriteLine($"Файл {path} не был найден! Алярм!");
                Console.WriteLine(ex.Message);
                return 0;
            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine("Функция была вызвана с пустым аргументом. Так делать нехорошо!");
                return 0;
            }
            catch(Exception ex)
            {
                Console.WriteLine("Алярм, ошибка!");
                var appEx = new AppException();
                appEx.MethodName = "GetRowCount";
                throw appEx;
            }
        }
    }
}
