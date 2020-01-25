using System;
using System.Collections.Generic;

namespace LanguageTutor
{
    class Program
    {
        static void Main(string[] args)
        {
            var tutor = new Tutor();
            tutor.AddWord("hello", "привет");
            tutor.AddWord("dog", "собака");
            tutor.AddWord("cat", "кошка");
            tutor.AddWord("byke", "велосипед");

            if(tutor.CheckWord("dog", "Cобака"))
            {

            }
        }
    }
}
