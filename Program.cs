using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace DebugQuiz6
{
    class Program
    {
        static void Main(string[] args)
        {
           Myclass course1 = new HomeworkAssignment();
            MyClass course2 = new HomeworkAssignment();
            string entryString;
            int exercises;

            // Get info for first class
            Write("What class do you have homework for? ");
            entryString = ReadLine();
            course1 = entryString;
            Write("How many exercises must you complete? ");
            entryString = ReadLine();
           
            course1.NumberOfExercises = exercises;

            // Get info for another class
            Write("What class do you have homework for? ");
            course2.ClassName = ReadLine();
            Write("How many exercises must you complete? ");
            exercises = ReadLine();           
            course2.Numberofexercises = exercises;

            WriteLine($"Class Name\t\t\t\tAssignments to Complete");
            WriteLine($"{course1.ClassName}\t\t\t{course1.NumberOfExercises}");
            WriteLine($"{course2.ClassName}\t\t\t{course2.NumberOfExercises}");

            ReadKey();
         }
    }
}
