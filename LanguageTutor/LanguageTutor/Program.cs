using System;
using System.Collections.Generic;

namespace LanguageTutor
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> set = new HashSet<int>();
            set.Add(1);
            set.Add(2);
            set.Add(1);

            if (set.Contains(1))
            {
                Console.WriteLine("В hashset-е хранится элемент 1");
            }


            Dictionary<string, string> dic = new Dictionary<string, string>();
            dic.Add("dog", "собака");
            dic.Add("cat", "кошка");


            Console.WriteLine($"dog переводится как {dic["dog"]}");
            Console.WriteLine($"В словаре у нас {dic.Count} значений");

            foreach (var key in dic.Keys)
            {
                Console.WriteLine($"{key} переводится как {dic[key]}");
            }

            if (dic.ContainsKey("dog"))
            {


            }
        }
    }
}
