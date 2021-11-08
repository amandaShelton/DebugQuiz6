using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DebugQuiz6
{
    class HomeworkAssignment
    {
        private int numberOfExercises;
        private int timeToComplete;
        // 10 minutes to complete each exercise
        private const int TIME_PER_EXERCISE = 10;

        public int NumberOfExercises
        {
            get; set;
        }
        public double TimeToComplete
        {
            get
            {
                return timeToComplete;
            }
        }
    }
}