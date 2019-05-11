using System;

namespace First_App
{
    class Program
    {
        Quiz q;
        static void Main(string[] args)
        {
           Quiz q = new Quiz(type: QuestionType.addition, count: 14, poolSize: 4);

           Console.WriteLine(q);
           Console.WriteLine(q.getActiveQuestion());

            string an = Console.ReadLine();
            Console.WriteLine(q.submitAnswer(an));



            Console.WriteLine("Press any key...");
           Console.ReadLine();
        }
    }
}
