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
        public string date { get; set; }

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

            

            string x = (Expenses.Budget).ToString();
            if (x == "0")
            {
                budget.Text = App.BudgetCost.ToString();
                Settoolbar.Text = "Edit Expenses";
            }
            else
            {
                budget.Text = Expenses.Budget.ToString();
                Settoolbar.Text = "Add Expenses";
            }
            BudgetV = decimal.Parse(budget.Text);

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

            string[] lins = File.ReadAllLines("/data/user/0/com.companyname.budgettrackingapp/files/.config/MarchExpenses/CategoryList.txt");
            //    homeexpenseCost = homeexpenseCost + homecatpreviouscost;
            //      File.WriteAllText(ExpensesPage.Categoryfilename, String.Empty);
            TotalExpensesCost = 0;
            for (int i = 0; i < lins.Length; i++)
            {
                
                string lin = lins[i];
                if ((lin.Contains("Home & Utilities")) || (lin.Contains("Insurance")) || (lin.Contains("Food")) ||
                        (lin.Contains("Travel")) || (lin.Contains("Groceries")) ||
                        (lin.Contains("Shopping & Entertainment")) || (lin.Contains("Cash, Checks & Misc")))
                {
                    string[] words = lin.Split(':');
                    lin = words[1];
                    TotalExpensesCost = TotalExpensesCost + decimal.Parse(lin);
                }
            }

                Totalexpensescost.Text = TotalExpensesCost.ToString();
        /*    if (File.Exists(HomeSubCtegory.TotalExpenses))
            {
                string str = File.ReadAllText(HomeSubCtegory.TotalExpenses);

               Totalexpensescost.Text = str;

                TotalExpensesCost = decimal.Parse(str);


            }
            else
            {
                Totalexpensescost.Text = "0";
            }*/

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

               var files = Directory.EnumerateFiles(App.specificFolder, "*.Category2.txt");

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
                          subcatcost3 = line[7],

                          date = line[8] + line[9] + line[10]
                      });

                  }

                

               CategorieslistView.ItemsSource = Categories.OrderBy(n=>n.date).ToList();

              

         }
        private void OnListViewItemSelected(object sender, SelectedItemChangedEventArgs e)
        {

        }

        private void OnBudgetAmountClicked(object sender, EventArgs e)
        {

            App.IsBudgetSet = "false";
           App.BudgetFile = "/data/user/0/com.companyname.budgettrackingapp/files/.config/MarchExpenses/IsBudgetSet.txt";

                //  File.WriteAllText(App.BudgetFile, String.Empty);

             //   string isbudget = File.ReadAllText(App.BudgetFile);

                string BudgetSet = App.IsBudgetSet.ToString() + ":" + "0";

                File.WriteAllText(App.BudgetFile, BudgetSet);
                // var BudgetEntryPage = new BudgetEntryPage();

                Navigation.PushAsync(new BudgetEntryPage());

        }
    }
}