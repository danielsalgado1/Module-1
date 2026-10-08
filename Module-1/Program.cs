using System;
using System.Collections.Generic;
using System.Reflection;

namespace Module_2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WeightedExercise exercise = new WeightedExercise
            {
                ExerciseName = "Bench Press",
                MuscleGroups = new List<string> { "Chest", "Triceps", "Shoulders" },
                WorkoutSets = 4,
                WorkoutReps = 10,
                WorkoutWeight = 95.0,
                WeightType = "Barbell"
            };

            Type thisType = exercise.GetType();
            MethodInfo commandMethod = thisType.GetMethod("printProperties");

            if (commandMethod != null)
            {
                commandMethod.Invoke(exercise, null);
            }
            else
            {
                Console.WriteLine("The printProperties method was not found.");
            }

            Console.WriteLine($"Total Reps: {exercise.CalculateTotalReps()}");
            Console.WriteLine($"Total Volume: {exercise.CalculateVolume()} lbs");
        }
    }
}
