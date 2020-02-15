using System;
using System.Collections.Generic;
using Telegram.Bot;

namespace LanguageTutor
{
    class Program
    {

        static TelegramBotClient Bot;

        const string COMMAND_LIST =
@"Список команд:
/add <eng> <rus> - добавление английского слова и его перевод в словарь
/get - получаем случайное английское слово из словаря
/check <eng> <rus> - проверяем правильность перевода английского слова
";
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

        private static async void Bot_OnMessage(object sender, Telegram.Bot.Args.MessageEventArgs e)
        {
            if (e == null || e.Message == null || e.Message.Type != Telegram.Bot.Types.Enums.MessageType.Text)
                return;

            Console.WriteLine(e.Message.Text);
            Console.WriteLine(e.Message.From.Username);

            var msgArgs = e.Message.Text.Split(' ');
            switch (msgArgs[0])
            {
                case "/start":
                    await Bot.SendTextMessageAsync(e.Message.From.Id, COMMAND_LIST);
                    break;
            }
        }
    }
}
