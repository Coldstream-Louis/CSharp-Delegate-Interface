using System;
using System.Collections.Generic;
using System.Text;

namespace Delegate
{
    public delegate void AnsweringDelegate(string question);
    
    class Program
    {
        private static void AnswerName(string question) {
            Console.WriteLine("Your name is "+question);
        }
        private static void AnswerBirthday(string question) {
            Console.WriteLine("Your birthday is "+question);
        }
        
        private static void AnswerTime(string question) {
            Console.WriteLine("Now is "+System.DateTime.Now);
        }
        private static void WhatCanIDo(string question) {
            Console.WriteLine("Hi, I am Robort Zero, I can answer your name, your birthday and today's date, now I will show you my capabilities.");
        }
        
        private static void GiveMeAnswer(string question, AnsweringDelegate MakeAnswering) {
            MakeAnswering(question);
        }

        static void Main(string[] args) {
            GiveMeAnswer("What can you do?", WhatCanIDo);
            GiveMeAnswer("Edward Plantagenet", AnswerName);
            GiveMeAnswer("1988.6.7", AnswerBirthday);
            GiveMeAnswer("What's the time?", AnswerTime);
            Console.ReadKey();
        }
    }
}