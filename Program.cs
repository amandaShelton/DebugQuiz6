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
            HomeworkAssignment course1 = new HomeworkAssignment();
            HomeworkAssignment course2 = new HomeworkAssignment();
            string entryString;
            int exercises;

            // Get info for first class
            Write("What class do you have homework for? ");
            entry = ReadLine();
            course1.className = entryString;
            Write("How many exercises must you complete? ");
            entryString = ReadLine(entry);
            int.TryParse(entryString, exercises);
            exercises = course1.NumberOfExercises;

            // Get info for another class
            Write("What class do you have homework for? ");
            entryString = ReadLine();
            course2.className = entrystring;
            Write("How many exercises must you complete? ");
            entryString = ReadLine();
            char.TryParse(entryString, exercises);
            course2.NumberOfExercises = exercises;

            WriteLine("You have {0} minutes of homework for {1}",
                  course1.timeToComplete, course1.ClassName);
            WriteLine("and {0} more minutes for {1}",
                  course2.timeToComplete, course2.ClassName);
        }
    }
}
