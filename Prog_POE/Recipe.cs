using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_POE
{
    public class Recipe
    {
        public string RecipeName { get; set; }
        public string Ingredients { get; set; }
        public double Quantities { get; set; }
        public string UnitOfMeasurement { get; set; }
        public double Calories { get; set; }
        public string FoodGroup { get; set; }
        public double OriginalQuantities { get; set; }

        public Recipe() { }
        //The RecipeName within the constructor acts as a primary key that locates the recipe that includes the recipe ingredient.
        public Recipe(string recipeName, string ingredients, double quantities, string unitofmeasurement, double calories, string foodgroup)//all recipe ingredient information are stored 
        {
            RecipeName = recipeName;
            Ingredients = ingredients;
            Quantities = quantities;
            UnitOfMeasurement = unitofmeasurement;
            Calories = calories;
            FoodGroup = foodgroup;
            OriginalQuantities = quantities;
        }
    }
}
