using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BudgetTrackingApp.Models;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BudgetTrackingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class BudgetEntryPage : ContentPage
    {
        public BudgetEntryPage()
        {
            InitializeComponent();
        }


        private void OnSaveButtonClicked(object sender, EventArgs e)
        {

           App.BudgetFile = Path.Combine(App.specificFolder, "IsBudgetSet.txt");

            App.SetInitialBudget = true;

            string BudgetSet = App.SetInitialBudget.ToString() + ":" + budget.Text;

            File.WriteAllText(App.BudgetFile, BudgetSet);

            Expenses.Budget = decimal.Parse(budget.Text);



            Navigation.PushAsync(new AddExpenses());
           
        }

        private void OnDeleteButtonClicked(object sender, EventArgs e)
        {
            budget.Text = null;
        }
    }
}