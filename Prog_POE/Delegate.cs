using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;

namespace Final_POE
{
    internal class Delegate
    {
        // Wagner, B. (2022) Using delegates - C# programming guide, Using Delegates -
        // C# Programming Guide | Microsoft Learn.
        // Available at: https://learn.microsoft.com/en-us/dotnet/csharp/programming-guide/delegates/using-delegates (Accessed: 25 June 2024). 
        public double CalorieAlert(List<Recipe> recipebook, String Recipe)// Delegate notifies the user when a recipe exceeds 300 calories
        {
            double Calories = 0;
            foreach (Recipe recipe in recipebook)
            {
                if (Recipe == recipe.RecipeName)
                {
                    Calories += recipe.Calories * recipe.Quantities;
                }
            }
            if (Calories > 300)
            {
                MessageBox.Show("Recipe " + Recipe + " exceeds 300 calories", "Calorie Alert!");

            }
            return Calories;
        }

        public double TotalCals(List<Recipe> recipebook, String Recipe)//Delegate calculates the total amount of calories
        {
            double Calories = 0;
            foreach (Recipe recipe in recipebook)
            {
                if (Recipe == recipe.RecipeName)
                {
                    Calories += recipe.Calories * recipe.Quantities;
                }
            }
            return Calories;
        }
    }
}