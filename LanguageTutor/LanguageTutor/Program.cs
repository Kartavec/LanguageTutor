using System;
using System.Collections.Generic;
using Telegram.Bot;

namespace LanguageTutor
{
    class Program
    {

        static TelegramBotClient Bot;
        static void Main(string[] args)
        {
            Bot = new TelegramBotClient("1077974262:AAFLGbCcG10-1TWHyNALbjwF3JhyJBjOrKY");

            //var me = Bot.GetMeAsync().Result;
            //Console.WriteLine(me.FirstName);

            Bot.OnMessage += Bot_OnMessage;
            Bot.StartReceiving();
            Console.ReadLine();
            Bot.StopReceiving();



            //var tutor = new Tutor();
            //tutor.AddWord("rabbit", "кролик");
            //while (true)
            //{
            //    var word = tutor.GetRandomEngWord();
            //    Console.WriteLine($"Как переводится слово: {word}?");
            //    var userAnswer = Console.ReadLine();
            //    if (tutor.CheckWord(word, userAnswer))
            //        Console.WriteLine("Правильно!");
            //    else
            //    {
            //        var correctAnswer = tutor.Translate(word);
            //        Console.WriteLine($"Неверно. Правильный ответ: {correctAnswer}");
            //    }
            //}

        }

        private static void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            Console.WriteLine(e.Message.Text);
            Console.WriteLine(e.Message.From.Username);

        }
    }
}
