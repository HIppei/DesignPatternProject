using System;

namespace ChainOfResponsibilityDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            QuizeMaster quizeMaster = new QuizeMaster();
            quizeMaster.AskQuestion("History");
            Console.WriteLine("\n");

            quizeMaster.AskQuestion("Language");
            Console.WriteLine("\n");
            
            quizeMaster.AskQuestion("Music");
            Console.WriteLine("\n");

            quizeMaster.AskQuestion("Math");

            Console.ReadLine();
        }
    }
}
