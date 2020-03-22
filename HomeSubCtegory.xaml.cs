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
    public partial class HomeSubCtegory : ContentPage
    {

        public HomeSubCtegory()
        {
            InitializeComponent();
        }
        public Expenses item { get; set; }
        public static DateTime creationdate { get; set; }
        public static string HomeSubcatFile { get; set; }

        public decimal TotalHomeExp { get; set; }
        public decimal TotalInsuranceExp { get; set; }
        public decimal TotalFoodExp { get; set; }
        public decimal TotalTravelExp { get; set; }
        public decimal TotalGroceriesExp { get; set; }
        public decimal TotalShoppingExp { get; set; }
        public decimal TotalMiscExp { get; set; }
        public decimal homecost { get; set; }
        public decimal utilcost { get; set; }
        public decimal othercost { get; set; }
        public string SubCat1 { get; set; }
        public string SubCat2 { get; set; }
        public string SubCat3 { get; set; }
        public decimal homecatpreviouscost { get; set; }
        public static decimal homeexpenseCost { get; set; }

        public string homeDetails { get; set; }
        public string data { get; set; }
        public async void OnSaveButtonClicked(object sender, EventArgs e)
        {
           
            if (ExpensesPage.SelectedCategory == "Home & Utilities")
            {
                HomeSubcatFile = Path.Combine(App.specificFolder, "HomeCategoryList.txt");

                homecost = decimal.Parse(homecatCost.Text);

                utilcost = decimal.Parse(UtilcatCost.Text);

                othercost = decimal.Parse(otherCost.Text);

                SubCat1 = Subcat1.Text;

                SubCat2 = Subcat2.Text;

                SubCat3 = Subcat3.Text;
                
                homeexpenseCost = homecost + utilcost + othercost;
                TotalHomeExp = homeexpenseCost;
                data = SubCat1 + ":" + homecost + ":" + SubCat2 + ":" + utilcost + ":" + SubCat3 + ":" + othercost;

                string categorydata = SubCat1 + "," + homecost + "," + SubCat2 + "," + utilcost + "," + SubCat3 + "," + othercost;

                File.WriteAllText(HomeSubcatFile, categorydata);

                WriteCategoryCost();

                WriteCatandSubCatDetailsToFile();
            }
            if (ExpensesPage.SelectedCategory == "Insurance")
            {
                HomeSubcatFile = Path.Combine(App.specificFolder, "Insurance.txt");

                homecost = decimal.Parse(homecatCost.Text);

                utilcost = decimal.Parse(UtilcatCost.Text);

                othercost = decimal.Parse(otherCost.Text);

                SubCat1 = Subcat1.Text;

                SubCat2 = Subcat2.Text;

                SubCat3 = Subcat3.Text;

                homeexpenseCost = homecost + utilcost + othercost;

                TotalInsuranceExp = homeexpenseCost;

                data = SubCat1 + ":" + homecost + ":" + SubCat2 + ":" + utilcost + ":" + SubCat3 + ":" + othercost;

                string categorydata = SubCat1 + "," + homecost + "," + SubCat2 + "," + utilcost + "," + SubCat3 + "," + othercost;

                File.WriteAllText(HomeSubcatFile, categorydata);

                WriteCategoryCost();

                WriteCatandSubCatDetailsToFile();
            }
            if (ExpensesPage.SelectedCategory == "Food")
            {
                HomeSubcatFile = Path.Combine(App.specificFolder, "Food.txt");

                homecost = decimal.Parse(homecatCost.Text);

                utilcost = decimal.Parse(UtilcatCost.Text);

                othercost = decimal.Parse(otherCost.Text);

                SubCat1 = Subcat1.Text;

                SubCat2 = Subcat2.Text;

                SubCat3 = Subcat3.Text;

                homeexpenseCost = homecost + utilcost + othercost;

                TotalFoodExp = homeexpenseCost;

                data = SubCat1 + ":" + homecost + ":" + SubCat2 + ":" + utilcost + ":" + SubCat3 + ":" + othercost;

                string categorydata = SubCat1 + "," + homecost + "," + SubCat2 + "," + utilcost + "," + SubCat3 + "," + othercost;

                File.WriteAllText(HomeSubcatFile, categorydata);

                WriteCategoryCost();

                WriteCatandSubCatDetailsToFile();
            }
            if (ExpensesPage.SelectedCategory == "Travel")
            {
                HomeSubcatFile = Path.Combine(App.specificFolder, "Travel.txt");

                homecost = decimal.Parse(homecatCost.Text);

                utilcost = decimal.Parse(UtilcatCost.Text);

                othercost = decimal.Parse(otherCost.Text);

                SubCat1 = Subcat1.Text;

                SubCat2 = Subcat2.Text;

                SubCat3 = Subcat3.Text;

                homeexpenseCost = homecost + utilcost + othercost;

                TotalTravelExp = homeexpenseCost;

                data = SubCat1 + ":" + homecost + ":" + SubCat2 + ":" + utilcost + ":" + SubCat3 + ":" + othercost;

                string categorydata = SubCat1 + "," + homecost + "," + SubCat2 + "," + utilcost + "," + SubCat3 + "," + othercost;

                File.WriteAllText(HomeSubcatFile, categorydata);

                WriteCategoryCost();

                WriteCatandSubCatDetailsToFile();
            }
            if (ExpensesPage.SelectedCategory == "Groceries")
            {
                HomeSubcatFile = Path.Combine(App.specificFolder, "Groceries.txt");

                homecost = decimal.Parse(homecatCost.Text);

                utilcost = decimal.Parse(UtilcatCost.Text);

                othercost = decimal.Parse(otherCost.Text);

                SubCat1 = Subcat1.Text;

                SubCat2 = Subcat2.Text;

                SubCat3 = Subcat3.Text;

                homeexpenseCost = homecost + utilcost + othercost;

                TotalGroceriesExp = homeexpenseCost;

                data = SubCat1 + ":" + homecost + ":" + SubCat2 + ":" + utilcost + ":" + SubCat3 + ":" + othercost;

                string categorydata = SubCat1 + "," + homecost + "," + SubCat2 + "," + utilcost + "," + SubCat3 + "," + othercost;

                File.WriteAllText(HomeSubcatFile, categorydata);

                WriteCategoryCost();

                WriteCatandSubCatDetailsToFile();
            }
            if (ExpensesPage.SelectedCategory == "Shopping & Entertainment")
            {
                HomeSubcatFile = Path.Combine(App.specificFolder, "ShoppingEntertainment.txt");

                homecost = decimal.Parse(homecatCost.Text);

                utilcost = decimal.Parse(UtilcatCost.Text);

                othercost = decimal.Parse(otherCost.Text);

                SubCat1 = Subcat1.Text;

                SubCat2 = Subcat2.Text;

                SubCat3 = Subcat3.Text;

                homeexpenseCost = homecost + utilcost + othercost;

                TotalShoppingExp = homeexpenseCost;

                data = SubCat1 + ":" + homecost + ":" + SubCat2 + ":" + utilcost + ":" + SubCat3 + ":" + othercost;

                string categorydata = SubCat1 + "," + homecost + "," + SubCat2 + "," + utilcost + "," + SubCat3 + "," + othercost;

                File.WriteAllText(HomeSubcatFile, categorydata);

                WriteCategoryCost();

                WriteCatandSubCatDetailsToFile();
            }
            if (ExpensesPage.SelectedCategory == "Cash, Checks & Misc")
            {
                HomeSubcatFile = Path.Combine(App.specificFolder, "MiscList.txt");

                homecost = decimal.Parse(homecatCost.Text);

                utilcost = decimal.Parse(UtilcatCost.Text);

                othercost = decimal.Parse(otherCost.Text);

                SubCat1 = Subcat1.Text;

                SubCat2 = Subcat2.Text;

                SubCat3 = Subcat3.Text;

                homeexpenseCost = homecost + utilcost + othercost;

                TotalMiscExp = homeexpenseCost;

                data = SubCat1 + ":" + homecost + ":" + SubCat2 + ":" + utilcost + ":" + SubCat3 + ":" + othercost;

                string categorydata = SubCat1 + "," + homecost + "," + SubCat2 + "," + utilcost + "," + SubCat3 + "," + othercost;

                File.WriteAllText(HomeSubcatFile, categorydata);

                WriteCategoryCost();

                WriteCatandSubCatDetailsToFile();

            }


            //  var exp = (Expenses)BindingContext;
            //  var homeExp = (HomeSubCtegory)BindingContext;
            // List<string> filesList = Directory.GetFiles(App.specificFolder).ToList();
            //  Console.WriteLine(filesList);

            //  Expenses.homeExpenseCost = homeexpenseCost ;

            AddExpenses.TotalExpensesCost = TotalHomeExp + TotalFoodExp + TotalGroceriesExp + TotalInsuranceExp +
                                            TotalTravelExp + TotalShoppingExp + TotalMiscExp;
            

            var expensePage = new ExpensesPage(homeexpenseCost);    
          
            await Navigation.PushAsync(expensePage);

            // item.expenseCost = Expenses.homeExpenseCost;

            Expenses.isFileLoaded = true;


        }
        protected override void OnAppearing()
        {
            base.OnAppearing();

            // loadExpensesFromFile = new ObservableCollection<Expenses>();
            //    var items = new List<HomeSubCtegory>();


            // string fname = "/data/user/0/com.companyname.budgettrackingapp/files/.config/MarchExpenses/HomeCategoryList.txt";
            if (ExpensesPage.SelectedCategory == "Home & Utilities")
            {
                HomeSubcatFile = Path.Combine(App.specificFolder, "HomeCategoryList.txt");
                if (File.Exists(HomeSubcatFile))
                {



                    string[] fileData = File.ReadAllLines(HomeSubcatFile);

                    if (!(fileData == null))
                    {
                        foreach (var line in fileData)
                        {
                            var check = line.Split(',');

                            {
                                Subcat1.Text = check[0].ToString();
                                homecatCost.Text = (check[1].ToString());

                                Subcat2.Text = check[2].ToString();
                                UtilcatCost.Text = (check[3]).ToString();

                                Subcat3.Text = check[4].ToString();
                                otherCost.Text = (check[5]).ToString();
                            }
                        }

                    }
                }
                else
                {
                    string categorydata = "Home" + "," + homecost + "," + "Utilities" + "," + utilcost + "," + "Others" + "," + othercost;

                    File.WriteAllText(HomeSubcatFile, categorydata);
                }

            }

            if (ExpensesPage.SelectedCategory == "Insurance")
            {
                HomeSubcatFile = Path.Combine(App.specificFolder, "Insurance.txt");

                if (File.Exists(HomeSubcatFile))
                {
                    string[] fileData = File.ReadAllLines(HomeSubcatFile);

                    if (!(fileData == null))
                    {
                        fileData = File.ReadAllLines(HomeSubcatFile);
                        foreach (var line in fileData)
                        {
                            var check = line.Split(',');

                            {
                                Subcat1.Text = check[0].ToString();
                                homecatCost.Text = (check[1].ToString());

                                Subcat2.Text = check[2].ToString();
                                UtilcatCost.Text = (check[3]).ToString();

                                Subcat3.Text = check[4].ToString();
                                otherCost.Text = (check[5]).ToString();
                            }
                        }

                    }
                    
                }
                else
                {
                    string categorydata = "Health "+ "," + homecost + "," + "Dental" + "," + utilcost + "," + "Car" + "," + othercost;

                    File.WriteAllText(HomeSubcatFile, categorydata);
                }
      
            }
            if (ExpensesPage.SelectedCategory == "Food")
            {
                HomeSubcatFile = Path.Combine(App.specificFolder, "Food.txt");

                if (File.Exists(HomeSubcatFile))
                {

                    string[] fileData = File.ReadAllLines(HomeSubcatFile);

                    if (fileData.Length > 0)
                    {
                        foreach (var line in fileData)
                        {
                            var check = line.Split(',');

                            {
                                Subcat1.Text = check[0].ToString();
                                homecatCost.Text = (check[1].ToString());

                                Subcat2.Text = check[2].ToString();
                                UtilcatCost.Text = (check[3]).ToString();

                                Subcat3.Text = check[4].ToString();
                                otherCost.Text = (check[5]).ToString();
                            }
                        }

                    }
                }
                else
                {
                    string categorydata = "Restaurants" + "," + homecost + "," + "Parties" + "," + utilcost + "," + "Others" + "," + othercost;

                    File.WriteAllText(HomeSubcatFile, categorydata);
                }
                
          
            }
            if (ExpensesPage.SelectedCategory == "Travel")
            {
                HomeSubcatFile = Path.Combine(App.specificFolder, "Travel.txt");

                if (File.Exists(HomeSubcatFile))

                {

                    string[] fileData = File.ReadAllLines(HomeSubcatFile);

                    if (fileData.Length > 0)
                    {
                        foreach (var line in fileData)
                        {
                            var check = line.Split(',');

                            {
                                Subcat1.Text = check[0].ToString();
                                homecatCost.Text = (check[1].ToString());

                                Subcat2.Text = check[2].ToString();
                                UtilcatCost.Text = (check[3]).ToString();

                                Subcat3.Text = check[4].ToString();
                                otherCost.Text = (check[5]).ToString();
                            }
                        }

                    }
                }
                else
                {
                    string categorydata = "Trip" + "," + homecost + "," + "JetCharges" + "," + utilcost + "," + "Others" + "," + othercost;

                    File.WriteAllText(HomeSubcatFile, categorydata);
                }
         
            }
            if (ExpensesPage.SelectedCategory == "Groceries")
            {
                HomeSubcatFile = Path.Combine(App.specificFolder, "Groceries.txt");

                if (File.Exists(HomeSubcatFile))
                {



                    string[] fileData = File.ReadAllLines(HomeSubcatFile);

                    if (fileData.Length > 0)
                    {
                        foreach (var line in fileData)
                        {
                            var check = line.Split(',');

                            {
                                Subcat1.Text = check[0].ToString();
                                homecatCost.Text = (check[1].ToString());

                                Subcat2.Text = check[2].ToString();
                                UtilcatCost.Text = (check[3]).ToString();

                                Subcat3.Text = check[4].ToString();
                                otherCost.Text = (check[5]).ToString();
                            }
                        }

                    }
                }
                else
                {
                    string categorydata = "FredMeyar" + "," + homecost + "," + "Target" + "," + utilcost + "," + "Costco" + "," + othercost;

                    File.WriteAllText(HomeSubcatFile, categorydata);
                }

            }
            if (ExpensesPage.SelectedCategory == "Shopping & Entertainment")
            {
                HomeSubcatFile = Path.Combine(App.specificFolder, "ShoppingEntertainment.txt");

                if (File.Exists(HomeSubcatFile))
                {
                    string[] fileData = File.ReadAllLines(HomeSubcatFile);

                    if (fileData.Length > 0)
                    {
                        foreach (var line in fileData)
                        {
                            var check = line.Split(',');

                            {
                                Subcat1.Text = check[0].ToString();
                                homecatCost.Text = (check[1].ToString());

                                Subcat2.Text = check[2].ToString();
                                UtilcatCost.Text = (check[3]).ToString();

                                Subcat3.Text = check[4].ToString();
                                otherCost.Text = (check[5]).ToString();
                            }
                        }

                    }
                }
                else
                {
                    string categorydata = "Fashion" + "," + homecost + "," + "Gifts" + "," + utilcost + "," + "Electronics" + "," + othercost;

                    File.WriteAllText(HomeSubcatFile, categorydata);
                }
            }
            if (ExpensesPage.SelectedCategory == "Cash, Checks & Misc")
            {
                HomeSubcatFile = Path.Combine(App.specificFolder, "MiscList.txt");

                if (File.Exists(HomeSubcatFile))
                {
                    string[] fileData = File.ReadAllLines(HomeSubcatFile);

                    if (fileData.Length > 0)
                    {
                        foreach (var line in fileData)
                        {
                            var check = line.Split(',');

                            {
                                Subcat1.Text = check[0].ToString();
                                homecatCost.Text = (check[1].ToString());

                                Subcat2.Text = check[2].ToString();
                                UtilcatCost.Text = (check[3]).ToString();

                                Subcat3.Text = check[4].ToString();
                                otherCost.Text = (check[5]).ToString();
                            }
                        }

                    }
                }
                else
                {
                    string categorydata = "ATM/Cash" + "," + homecost + "," + "Checks" + "," + utilcost + "," + "OtherBills" + "," + othercost;

                    File.WriteAllText(HomeSubcatFile, categorydata);
                }
       
            }
        }
        //Updating category cost from total subcategory cost and writing it  to categorylist file.
        public void WriteCategoryCost()
        {

            if (File.Exists(ExpensesPage.Categoryfilename))
            {

                string[] lines = File.ReadAllLines(ExpensesPage.Categoryfilename);
                //    homeexpenseCost = homeexpenseCost + homecatpreviouscost;
                //      File.WriteAllText(ExpensesPage.Categoryfilename, String.Empty);
                for (int i = 0; i < lines.Length; i++)
                {
                    string line = lines[i];
                    if ((line.Contains("Home & Utilities")&& (ExpensesPage.SelectedCategory == "Home & Utilities")) || (line.Contains("Insurance")&&(ExpensesPage.SelectedCategory == "Insurance")) || (line.Contains("Food") && (ExpensesPage.SelectedCategory == "Food")) || (line.Contains("Travel") && (ExpensesPage.SelectedCategory == "Travel")) || 
                        (line.Contains("Groceries") && (ExpensesPage.SelectedCategory == "Groceries")) || (line.Contains("Shopping & Entertainment")&& (ExpensesPage.SelectedCategory == "Shopping & Entertainment")) || (line.Contains("Cash, Checks & Misc")&&(ExpensesPage.SelectedCategory == "Cash, Checks & Misc")))
                    {
                        string[] words = line.Split(':');
                        line = words[0] + ":" + homeexpenseCost + ":" + words[2].Trim();
                        homeDetails = words[0] + ":" + homeexpenseCost;
                        lines[i] = line;
                    }
               
                }
                File.WriteAllLines(ExpensesPage.Categoryfilename, lines);
            }
            homecatpreviouscost = homeexpenseCost;
        }

        public void WriteCatandSubCatDetailsToFile()
        {
           
            if((ExpensesPage.SelectedCategory == "Home & Utilities"))
            {

                App.CatAndsubcatdetailFile = Path.Combine(App.specificFolder, "HomeExpenseList.Category.txt");
                //  string fname = "/data/user/0/com.companyname.budgettrackingapp/files/.config/MarchExpenses/DetailExpenseList.txt";//
                if (File.Exists(App.CatAndsubcatdetailFile))
                {
                    homeDetails = homeDetails + ":" + data;
                    File.WriteAllText(App.CatAndsubcatdetailFile, homeDetails);
                    string[] lines = File.ReadAllLines(App.CatAndsubcatdetailFile);
                    if (lines.Length > 0)
                    {
                       
                        for (int i = 0; i < lines.Length; i++)
                        {
                          //  File.WriteAllText(App.CatAndsubcatdetailFile, String.Empty);
                            string line = lines[i];
                            if (line.Contains("Home & Utilities"))
                            {
                                string[] words = line.Split(':');

                                File.WriteAllLines(App.CatAndsubcatdetailFile, words);
                                // line = words[0] + ":" + homeexpenseCost + ":" + words[2].Trim();
                                // lines[i] = line;
                            }

                        }

                    }
                   

                  creationdate = File.GetLastWriteTime(App.CatAndsubcatdetailFile);

                }

 

            }
            if ((ExpensesPage.SelectedCategory == "Insurance"))
            {

                App.CatAndsubcatdetailFile = Path.Combine(App.specificFolder, "Insurance.Category.txt");
                //  string fname = "/data/user/0/com.companyname.budgettrackingapp/files/.config/MarchExpenses/DetailExpenseList.txt";//
                homeDetails = homeDetails + ":" + data;

                File.WriteAllText(App.CatAndsubcatdetailFile, homeDetails);

                if (File.Exists(App.CatAndsubcatdetailFile))
                {
                   
                    string[] lines = File.ReadAllLines(App.CatAndsubcatdetailFile);
                    if (lines.Length > 0)
                    {

                        for (int i = 0; i < lines.Length; i++)
                        {
                            string line = lines[i];
                            if (line.Contains("Insurance"))
                            {
                                string[] words = line.Split(':');

                                File.WriteAllLines(App.CatAndsubcatdetailFile, words);
                                
                            }

                        }

                    }


                    creationdate = File.GetLastWriteTime(App.CatAndsubcatdetailFile);

                }



            }
            if ((ExpensesPage.SelectedCategory == "Food"))
            {

                App.CatAndsubcatdetailFile = Path.Combine(App.specificFolder, "Food.Category.txt");
                //  string fname = "/data/user/0/com.companyname.budgettrackingapp/files/.config/MarchExpenses/DetailExpenseList.txt";//
                homeDetails = homeDetails + ":" + data;

                File.WriteAllText(App.CatAndsubcatdetailFile, homeDetails);

                if (File.Exists(App.CatAndsubcatdetailFile))
                {

                    string[] lines = File.ReadAllLines(App.CatAndsubcatdetailFile);
                    if (lines.Length > 0)
                    {

                        for (int i = 0; i < lines.Length; i++)
                        {
                            string line = lines[i];
                            if (line.Contains("Food"))
                            {
                                string[] words = line.Split(':');

                                File.WriteAllLines(App.CatAndsubcatdetailFile, words);

                            }

                        }

                    }


                    creationdate = File.GetLastWriteTime(App.CatAndsubcatdetailFile);

                }



            }
            if ((ExpensesPage.SelectedCategory == "Travel"))
            {

                App.CatAndsubcatdetailFile = Path.Combine(App.specificFolder, "Travel.Category.txt");
                //  string fname = "/data/user/0/com.companyname.budgettrackingapp/files/.config/MarchExpenses/DetailExpenseList.txt";//
                homeDetails = homeDetails + ":" + data;

                File.WriteAllText(App.CatAndsubcatdetailFile, homeDetails);

                if (File.Exists(App.CatAndsubcatdetailFile))
                {

                    string[] lines = File.ReadAllLines(App.CatAndsubcatdetailFile);
                    if (lines.Length > 0)
                    {

                        for (int i = 0; i < lines.Length; i++)
                        {
                            string line = lines[i];
                            if (line.Contains("Travel"))
                            {
                                string[] words = line.Split(':');

                                File.WriteAllLines(App.CatAndsubcatdetailFile, words);

                            }

                        }

                    }


                    creationdate = File.GetLastWriteTime(App.CatAndsubcatdetailFile);

                }



            }
            if ((ExpensesPage.SelectedCategory == "Groceries"))
            {

                App.CatAndsubcatdetailFile = Path.Combine(App.specificFolder, "Groceries.Category.txt");
                //  string fname = "/data/user/0/com.companyname.budgettrackingapp/files/.config/MarchExpenses/DetailExpenseList.txt";//
                homeDetails = homeDetails + ":" + data;

                File.WriteAllText(App.CatAndsubcatdetailFile, homeDetails);

                if (File.Exists(App.CatAndsubcatdetailFile))
                {

                    string[] lines = File.ReadAllLines(App.CatAndsubcatdetailFile);
                    if (lines.Length > 0)
                    {

                        for (int i = 0; i < lines.Length; i++)
                        {
                            string line = lines[i];
                            if (line.Contains("Groceries"))
                            {
                                string[] words = line.Split(':');

                                File.WriteAllLines(App.CatAndsubcatdetailFile, words);

                            }

                        }

                    }


                    creationdate = File.GetLastWriteTime(App.CatAndsubcatdetailFile);

                }



            }
            if ((ExpensesPage.SelectedCategory == "Shopping & Entertainment"))
            {

                App.CatAndsubcatdetailFile = Path.Combine(App.specificFolder, "ShoppingEntertainment.Category.txt");
                //  string fname = "/data/user/0/com.companyname.budgettrackingapp/files/.config/MarchExpenses/DetailExpenseList.txt";//
                homeDetails = homeDetails + ":" + data;

                File.WriteAllText(App.CatAndsubcatdetailFile, homeDetails);

                if (File.Exists(App.CatAndsubcatdetailFile))
                {

                    string[] lines = File.ReadAllLines(App.CatAndsubcatdetailFile);
                    if (lines.Length > 0)
                    {

                        for (int i = 0; i < lines.Length; i++)
                        {
                            string line = lines[i];
                            if (line.Contains("Shopping & Entertainment"))
                            {
                                string[] words = line.Split(':');

                                File.WriteAllLines(App.CatAndsubcatdetailFile, words);

                            }

                        }

                    }


                    creationdate = File.GetLastWriteTime(App.CatAndsubcatdetailFile);

                }



            }
            if ((ExpensesPage.SelectedCategory == "Cash, Checks & Misc"))
            {

                App.CatAndsubcatdetailFile = Path.Combine(App.specificFolder, "Misc.Category.txt");
                //  string fname = "/data/user/0/com.companyname.budgettrackingapp/files/.config/MarchExpenses/DetailExpenseList.txt";//
                homeDetails = homeDetails + ":" + data;

                File.WriteAllText(App.CatAndsubcatdetailFile, homeDetails);

                if (File.Exists(App.CatAndsubcatdetailFile))
                {

                    string[] lines = File.ReadAllLines(App.CatAndsubcatdetailFile);
                    if (lines.Length > 0)
                    {

                        for (int i = 0; i < lines.Length; i++)
                        {
                            string line = lines[i];
                            if (line.Contains("Cash, Checks & Misc"))
                            {
                                string[] words = line.Split(':');

                                File.WriteAllLines(App.CatAndsubcatdetailFile, words);

                            }

                        }

                    }


                    creationdate = File.GetLastWriteTime(App.CatAndsubcatdetailFile);

                }



            }

        }
            private void OnCancelButtonClicked(object sender, EventArgs e)
            {

                var ExpPage = new ExpensesPage(homeexpenseCost);
                Navigation.PushAsync((ExpPage));

            }
        
    }
}