using BudgetTrackingApp.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;


namespace BudgetTrackingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class AddExpenses : ContentPage
    {
        public static decimal BudgetV { get; set; }
        public static decimal TotalExpensesCost { get; set; }
        public decimal DifferenceAmount { get; set; }
        public static string Message { get; set; }
        public string CategoryName { get; set; }
        public string CategoryCost { get; set; }
        public string subcatName1 { get; set; }
        public string subcatName2 { get; set; }
        public string subcatName3 { get; set; }
        public string subcatcost1 { get; set; }
        public string subcatcost2 { get; set; }
        public string subcatcost3 { get; set; }     
        public DateTime date { get; set; }

        public AddExpenses()
        {
            InitializeComponent();
        }

        decimal cost = 0;
         void AddExpensesClicked(object sender, EventArgs e)
         {
            cost = HomeSubCtegory.homeexpenseCost;
            
            var ExpPage = new ExpensesPage(cost);
             
            Navigation.PushAsync(ExpPage);
         }
         protected override void OnAppearing()
         {
                  base.OnAppearing();

               BudgetV = Expenses.Budget;

            string fname = "/data/user/0/com.companyname.budgettrackingapp/files/.config/MarchExpenses/CategoryList.txt";

            if (File.Exists(fname))
            { 
                string[] fileData = File.ReadAllLines(fname);
                if (fileData.Length > 0)
                {
                    foreach (var line in fileData)
                    {
                        var check = line.Split(':');
                        
                        TotalExpensesCost = TotalExpensesCost + decimal.Parse(check[1]);

                    }
                }
            }
            else
            {
                return;
            }

            Totalexpensescost.Text = TotalExpensesCost.ToString();

               DifferenceAmount = BudgetV - TotalExpensesCost;
               
            if(DifferenceAmount > 0)
            {
                Message = $"You are left with ${DifferenceAmount} from your Budget";
            }
            else
            {
                Message = $"You exceeded the limit of your Budget by ${DifferenceAmount}";

            }

               message.Text = Message;

               var Categories = new List<AddExpenses>();

               var files = Directory.EnumerateFiles(App.specificFolder, "*.Category.txt");

                  foreach (var filename in files)
                  {
                   string lines = File.ReadAllText(filename);

                   
                var line = lines.Split('\n');

                      Categories.Add(new AddExpenses
                      {
                          CategoryName = line[0],
                          CategoryCost = line[1],

                          subcatName1 =line[2],
                          subcatcost1=line[3],

                          subcatName2 = line[4],
                          subcatcost2 = line[5],

                          subcatName3 = line[6],
                          subcatcost3 = line[7]

                      });

                  }

                date= HomeSubCtegory.creationdate;

               CategorieslistView.ItemsSource = Categories.OrderBy(n => n.date).ToList();

               budget.Text = (Expenses.Budget).ToString();

         }
        private void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

    }
}