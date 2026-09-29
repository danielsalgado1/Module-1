using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1
{
    internal class Exercise
    {
        public string ExerciseName { get; set; } = "";
        public List<string> MuscleGroups { get; set; } = new List<string>();
        public int WorkoutSets { get; set; }
        public int WorkoutReps { get; set;}
        public double WorkoutWeight { get; set; }

        public int CalculateTotalReps()
        {
            return WorkoutSets * WorkoutReps;
        }

        public double CalculateVolume()
        {
            return CalculateTotalReps() * WorkoutWeight;
        }
    }
}
