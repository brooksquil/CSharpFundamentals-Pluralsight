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
            
            
            Gradebook book2 = book;
            book2.AddGrade(75);
            
        }
    }
}