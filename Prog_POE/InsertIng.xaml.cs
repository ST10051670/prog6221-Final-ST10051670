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
    /// Interaction logic for InsertIng.xaml
    /// </summary>
    public partial class InsertIng : Window
    {
        public delegate double CalorieDelegate(List<Recipe> recipebook, String Recipe);
        public InsertIng()
        {
            InitializeComponent();
        }

        private void btnAddNewIng_Click(object sender, RoutedEventArgs e)
        {
            // Validate input fields
            if (string.IsNullOrWhiteSpace(txtIngName.Text))
            {
                MessageBox.Show("Ingredient Name is required.", "Input Error");
                return;
            }

            if (!double.TryParse(txtIngQuantity.Text, out double IngQuantity))
            {
                MessageBox.Show("Please enter a valid quantity.", "Input Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbUnitOfMeasurement.Text))
            {
                MessageBox.Show("Unit of Measurement is required.", "Input Error");
                return;
            }

            if (!double.TryParse(txtCalories.Text, out double IngCalories))
            {
                MessageBox.Show("Please enter a valid calorie amount.", "Input Error");
                return;
            }

            if (string.IsNullOrWhiteSpace(cmbFoodGroup.Text))
            {
                MessageBox.Show("Food Group is required.", "Input Error");
                return;
            }

            string IngName = txtIngName.Text;
            string IngUOM = cmbUnitOfMeasurement.Text;
            string IngFoodGroup = cmbFoodGroup.Text;
            double OriginalQuantities = IngQuantity; 

            Recipe IngInfo = new Recipe(InsertRecipe.RecipeName, IngName, IngQuantity, IngUOM, IngCalories, IngFoodGroup);
            ListUtils.IngList.Add(IngInfo);

            MessageBox.Show("Ingredient added successfully!", "Added New Ingredient");

            txtIngName.Text = string.Empty;
            txtIngQuantity.Text = string.Empty;
            cmbUnitOfMeasurement.Text = string.Empty;
            txtCalories.Text = string.Empty;
            cmbFoodGroup.SelectedIndex = -1;
        }

        private void txtCalories_TextChanged(object sender, TextChangedEventArgs e)
        {

        }

        private void btnProceed_Click(object sender, RoutedEventArgs e)
        {
            Delegate del = new Delegate();
            CalorieDelegate CD = new CalorieDelegate(del.CalorieAlert);
            CD(ListUtils.IngList, InsertRecipe.RecipeName);
            this.Close();
            InsertSteps insertSteps = new InsertSteps();
            insertSteps.Show();
        }

        private void btnClear_Click(object sender, RoutedEventArgs e)
        {
            // Clear the text of text boxes
            txtIngName.Text = string.Empty;
            txtIngQuantity.Text = string.Empty;
            cmbUnitOfMeasurement.Text = string.Empty;
            txtCalories.Text = string.Empty;

            // Clear the selection of the combo box
            cmbFoodGroup.SelectedIndex = -1;

            MessageBox.Show("Cleared successfully!", "Clear");
        }
    }
}