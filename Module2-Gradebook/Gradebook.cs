using System.Collections.Generic;

namespace Module2_Gradebook
{
    public class Gradebook
    {
        //State or behavior related members
        //state - holds data
        //behavior - methods that do work
        
        //Explicit Constructor
        public Gradebook()
        {
           //or initialize field inside constructor
           grades = new List<float>(); 
        }
        
        //method
        public void AddGrade(float grade)
        {
            grades.Add(grade);
        }
        
        //field initializer
        //List<float> grades = new List<float>();
        
        //or

       private List<float> grades;
    }
}