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
    /// Interaction logic for InsertSteps.xaml
    /// </summary>
    public partial class InsertSteps : Window
    {
        public InsertSteps()
        {
            InitializeComponent();
        }

        private void btnAddSteps_Click(object sender, RoutedEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbSteps.Text))
            {
                MessageBox.Show("Ingredient Name is required.", "Input Error");
                return;
            }
            RecipeSteps Rs = new RecipeSteps(InsertRecipe.RecipeName, tbSteps.Text);
            ListUtils.StepsList.Add(Rs);
            MessageBox.Show("Step Added.", "Steps");
            tbSteps.Text = "";
            
        }

        private void btnDone_Click(object sender, RoutedEventArgs e)
        {
            InsertSteps insertSteps = new InsertSteps();
            this.Close();

        }

    }
}