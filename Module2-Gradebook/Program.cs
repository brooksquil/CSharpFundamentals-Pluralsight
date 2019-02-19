using System;

namespace Module2_Gradebook
{
    class Program
    {
        static void Main(string[] args)
        {
            //instantiate class Gradebook => invokes constructor (defaults but can be customized)
            Gradebook book = new Gradebook();
            book.AddGrade(91);
            book.AddGrade(89);
            book.AddGrade(72);

            //separates blueprint class from computational class
            GradeStatistics stats = book.ComputeStatistics();


            Console.WriteLine(stats.AverageGrade);
            Console.WriteLine(stats.HighestGrade);
            Console.WriteLine(stats.LowestGrade);
            
        }
    }
}