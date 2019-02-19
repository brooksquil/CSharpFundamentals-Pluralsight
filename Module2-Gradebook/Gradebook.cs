using System;
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
        
        //Gradestatistics is what will be returned - void is used if not returning a value
        public GradeStatistics ComputeStatistics()
        {
            GradeStatistics stats =  new GradeStatistics();

            float sum = 0;
            foreach (float grade in grades)
            {
                stats.HighestGrade = Math.Max(grade, stats.HighestGrade);
                stats.LowestGrade = Math.Min(grade, stats.LowestGrade);
                //adds value of grade into variable
                sum += grade;
            }

            stats.AverageGrade = sum / grades.Count;
            return stats;
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