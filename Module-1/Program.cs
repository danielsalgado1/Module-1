using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Module_1
{
    internal class Program
    {
        
        static void Main(string[] args)
        {
            Exercise exercise = new Exercise
            {
                ExerciseName = "Bench Press",
                MuscleGroups = new List<string> { "Chest", "Triceps", "Shoulders" },
                WorkoutSets = 4,
                WorkoutReps = 10,
                WorkoutWeight = 135.0
            };
            exercise.displayDetails();
            Console.WriteLine($"Total Reps: {exercise.CalculateTotalReps()}");
            Console.WriteLine($"Total Volume: {exercise.CalculateVolume()} lbs");
        }
    }
}
