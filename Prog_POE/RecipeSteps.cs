using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Final_POE
{
    public class RecipeSteps//Constructor for all the steps within recipes
    {
        public string RecipeName { get; set; }
        public string Step { get; set; }

        public RecipeSteps() { }

        public RecipeSteps(string recipeName, String step)//RecipeName acts as a primary key that helps locate the steps
        {
            RecipeName = recipeName;
            Step = step;
        }
    }
}
