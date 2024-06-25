using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace Final_POE
{
    /// <summary>
    /// Interaction logic for RecipeView.xaml
    /// </summary>
    public partial class RecipeView : Window
    {
        public delegate double CalorieDelegate(List<Recipe> recipebook, String Recipe);
        string SelectedRecipe;
        public RecipeView()
        {
            InitializeComponent();
        }

        private void RecipeView_Loaded(object sender, RoutedEventArgs e)
        {

            String EliminateRepetitions = " ";
            //because the recipe list has no unique IDs I eliminated the repetition of the recipe name in the alphabetical list
            //(e.g. many ingredients fall under a single recipe and because they are under the same list to save space the recipe name will repeat)
            IEnumerable<RecipeSteps> sorted = ListUtils.StepsList
            .OrderBy(x => x.RecipeName)  // Sort by RecipeName
            .GroupBy(x => x.RecipeName)  // Group by RecipeName
            .Select(group => group.First());  // Select the first element from each group

            //Hoffman, K. (2012) Get a list of distinct values in list, Stack Overflow.
            //Available at: https://stackoverflow.com/questions/10255121/get-a-list-of-distinct-values-in-list (Accessed: 25 June 2024). 



            List<String> NoReps = new List<String>();



            foreach (RecipeSteps item in sorted)
            {
                NoReps.Add(item.RecipeName);



            }

            foreach (String RecipeName in NoReps)
            {
                lbRecipes.Items.Add(RecipeName);
            }

        }

        private void lbRecipes_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            lbOutput.Items.Clear();
            stepListBox.Items.Clear();

            if (lbRecipes.SelectedItem != null)
            {

                SelectedRecipe = lbRecipes.SelectedItem.ToString();

                lbSelectedRecipe.Content = "Details for Recipe: " + SelectedRecipe;



                foreach (Recipe item in ListUtils.IngList)
                {

                    if (SelectedRecipe == item.RecipeName)
                    {

                        //Adegeo (2022) Composite formatting,
                        //Microsoft Learn. Available at:
                        //https://learn.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting (Accessed: 25 June 2024).

                        lbOutput.Items.Add(String.Format("{0,-40}", item.Ingredients) + String.Format("{0,-40}", "Quantity: " + item.Quantities + " " + item.UnitOfMeasurement) + String.Format("{0,-40}", "Calories(Per Unit): " + item.Calories) + String.Format("{0,-40}", "Food Group: " + item.FoodGroup));


                    }
                }
                Delegate del = new Delegate();
                CalorieDelegate CD = new CalorieDelegate(del.TotalCals);

                double totalCals = CD(ListUtils.IngList, SelectedRecipe);
                lbCalories.Visibility = Visibility.Visible;
                lbCalories.Content = "This recipe contains a total of " + totalCals + " calories";

                foreach (RecipeSteps p in ListUtils.StepsList)
                {
                    if (SelectedRecipe == p.RecipeName)
                    {
                        stepListBox.Items.Add(p.Step);

                    }
                }
            }
        }
        private void btnscale_Click(object sender, RoutedEventArgs e)
        {
            lbOutput.Items.Clear();
            foreach (Recipe item in ListUtils.IngList)
            {
                if (SelectedRecipe == item.RecipeName)
                {
                    item.Quantities = (item.Quantities * 0.5);


                }
            }



            foreach (Recipe item in ListUtils.IngList)
            {

                if (SelectedRecipe == item.RecipeName)
                {

                    //Adegeo (2022) Composite formatting,
                    //Microsoft Learn. Available at:
                    //https://learn.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting (Accessed: 25 June 2024).

                    lbOutput.Items.Add(String.Format("{0,-40}", item.Ingredients) + String.Format("{0,-40}", "Quantity: " + item.Quantities + " " + item.UnitOfMeasurement) + String.Format("{0,-40}", "Calories(Per Unit): " + item.Calories) + String.Format("{0,-40}", "Food Group: " + item.FoodGroup));


                }
            }

            Delegate del = new Delegate();
            CalorieDelegate CD = new CalorieDelegate(del.TotalCals);

            double totalCals = CD(ListUtils.IngList, SelectedRecipe);
            lbCalories.Content = "This recipe contains a total of " + totalCals + " calories";
        }

        private void btnscale2_Click(object sender, RoutedEventArgs e)
        {
            lbOutput.Items.Clear();
            foreach (Recipe item in ListUtils.IngList)
            {
                if (SelectedRecipe == item.RecipeName)
                {
                    item.Quantities = (item.Quantities * 2);


                }
            }


            foreach (Recipe item in ListUtils.IngList)
            {

                if (SelectedRecipe == item.RecipeName)
                {

                    //Adegeo (2022) Composite formatting,
                    //Microsoft Learn. Available at:
                    //https://learn.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting (Accessed: 25 June 2024).

                    lbOutput.Items.Add(String.Format("{0,-40}", item.Ingredients) + String.Format("{0,-40}", "Quantity: " + item.Quantities + " " + item.UnitOfMeasurement) + String.Format("{0,-40}", "Calories(Per Unit): " + item.Calories) + String.Format("{0,-40}", "Food Group: " + item.FoodGroup));


                }
            }

            Delegate del = new Delegate();
            CalorieDelegate CD = new CalorieDelegate(del.TotalCals);

            double totalCals = CD(ListUtils.IngList, SelectedRecipe);
            lbCalories.Content = "This recipe contains a total of " + totalCals + " calories";
        }

        private void btnscale3_Click(object sender, RoutedEventArgs e)
        {
            lbOutput.Items.Clear();
            foreach (Recipe item in ListUtils.IngList)
            {
                if (SelectedRecipe == item.RecipeName)
                {
                    item.Quantities = (item.Quantities * 3);


                }
            }


            foreach (Recipe item in ListUtils.IngList)
            {

                if (SelectedRecipe == item.RecipeName)
                {

                    //Adegeo (2022) Composite formatting,
                    //Microsoft Learn. Available at:
                    //https://learn.microsoft.com/en-us/dotnet/standard/base-types/composite-formatting (Accessed: 25 June 2024).

                    lbOutput.Items.Add(String.Format("{0,-40}", item.Ingredients) + String.Format("{0,-40}", "Quantity: " + item.Quantities + " " + item.UnitOfMeasurement) + String.Format("{0,-40}", "Calories(Per Unit): " + item.Calories) + String.Format("{0,-40}", "Food Group: " + item.FoodGroup));


                }
            }

            Delegate del = new Delegate();
            CalorieDelegate CD = new CalorieDelegate(del.TotalCals);

            double totalCals = CD(ListUtils.IngList, SelectedRecipe);
            lbCalories.Content = "This recipe contains a total of " + totalCals + " calories";
        }

        private void btnFilterIng_Click(object sender, RoutedEventArgs e)
        {
            lbRecipes.Items.Clear();
            lbOutput.Items.Clear();
            stepListBox.Items.Clear();
            string filterIng = txtFilter.Text;


            lbCalories.Visibility = Visibility.Hidden;


            foreach (Recipe item in ListUtils.IngList)
            {
                if (item.Ingredients.ToLower() == filterIng.ToLower())
                {
                    lbRecipes.Items.Add(item.RecipeName);
                }
            }
        }

        private void btnFilterFoodGroup_Click(object sender, RoutedEventArgs e)
        {
            lbRecipes.Items.Clear();
            lbOutput.Items.Clear();
            stepListBox.Items.Clear();
            string filterIng = txtFilter.Text;


            lbCalories.Visibility = Visibility.Hidden;

            String EliminateRepetitions = " ";
            Boolean valid = false;
            foreach (Recipe item in ListUtils.IngList)
            {
                if (item.FoodGroup.ToLower().Contains(filterIng.ToLower()) == true)
                {
                    valid = true;
                    if (EliminateRepetitions.Contains(item.RecipeName) == false)//if the string does not contain the repetition the recipe name is printed in the menu in alphabetical order
                                                                                //The name is then added into the NoReps List
                    {
                        lbRecipes.Items.Add(item.RecipeName);
                        EliminateRepetitions = EliminateRepetitions + " " + item.RecipeName;
                    }

                }
            }
            if (valid == false)
            {
                MessageBox.Show("There were no food groups that are similar to or match " + filterIng + " \n| Please Reset The Filter |", "Error!");
            }
        }

        private void btnFilterCalories_Click(object sender, RoutedEventArgs e)
        {

            lbRecipes.Items.Clear();
            lbOutput.Items.Clear();
            stepListBox.Items.Clear();
            string filterIng = txtFilter.Text;


            lbCalories.Visibility = Visibility.Hidden;

            IEnumerable<RecipeSteps> sorted = ListUtils.StepsList
             .OrderBy(x => x.RecipeName)  // Sort by RecipeName
             .GroupBy(x => x.RecipeName)  // Group by RecipeName
             .Select(group => group.First());  // Select the first element from each group


            try
            {
                int MaxCals = int.Parse(txtFilter.Text);

                Boolean valid = false;
                foreach (RecipeSteps item in sorted)
                {
                    double totalCals = 0;
                    Delegate del = new Delegate();
                    CalorieDelegate CD = new CalorieDelegate(del.TotalCals);

                    totalCals = CD(ListUtils.IngList, item.RecipeName);
                    if (totalCals <= MaxCals)
                    {
                        valid = true;

                        lbRecipes.Items.Add(item.RecipeName);

                    }
                }
                if (valid == false)
                {
                    MessageBox.Show("There were no food groups that are similar to or match " + filterIng + " \n| Please Reset The Filter |", "Notice");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("please insert a valid integer input", "Error!");
            }

        }
        private void btnResetScale_Click(object sender, RoutedEventArgs e)
        {
            lbOutput.Items.Clear();

            foreach (Recipe item in ListUtils.IngList)
            {
                if (SelectedRecipe == item.RecipeName)
                {
                    // Reset the quantities to their original values
                    item.Quantities = item.OriginalQuantities;
                }

                // Display the ingredients with the original quantities
                lbOutput.Items.Add(String.Format("{0,-40}", item.Ingredients) + String.Format("{0,-40}", "Quantity: " + item.Quantities + " " + item.UnitOfMeasurement) + String.Format("{0,-40}", "Calories(Per Unit): " + item.Calories) + String.Format("{0,-40}", "Food Group: " + item.FoodGroup));
            }

            Delegate del = new Delegate();
            CalorieDelegate CD = new CalorieDelegate(del.TotalCals);
            double totalCals = CD(ListUtils.IngList, SelectedRecipe);
            lbCalories.Content = "This recipe contains a total of " + totalCals + " calories";
        }

        private void lbOutput_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }
    }
}