using BudgetTrackingApp.Models;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BudgetTrackingApp
{
    public partial class App : Application
    {
        public static string IsBudgetSet { get; set; }
        public static string BudgetFile { get; set; }
        public static string FolderPath { get; set; }
        public static string specificFolder { get; set; }
        public static decimal BudgetCost { get; set; }
        public static bool SetInitialBudget { get; set; }
        public static string CatAndsubcatdetailFile { get; set; }
        public App()
        {
            InitializeComponent();
            // The folder for the roaming current user 
           FolderPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);
           

            // Combine the base folder with your specific folder....
            App.specificFolder = Path.Combine(App.FolderPath, "MarchExpenses");


            // CreateDirectory will check if folder exists and, if not, create it.
            // If folder exists then CreateDirectory will do nothing.
            if (Directory.Exists(App.specificFolder))
            {

            }
            else
            {
                Directory.CreateDirectory(App.specificFolder);
            }
            BudgetFile = "/data/user/0/com.companyname.budgettrackingapp/files/.config/MarchExpenses/IsBudgetSet.txt";
           
            if(File.Exists(BudgetFile))
            {
             //  string s = "false" + ":" + "0";
              // File.WriteAllText(BudgetFile, s);

                string isbudget = File.ReadAllText(BudgetFile);

                var check = isbudget.Split(':');

                IsBudgetSet = check[0];

                if(IsBudgetSet == "True")
                {
                    BudgetCost = decimal.Parse(check[1]);

                    MainPage = new NavigationPage(new AddExpenses());
                }
                else
                {
                    MainPage = new NavigationPage(new BudgetEntryPage());
                }
               
                
            }
            else
            {
                MainPage = new NavigationPage(new BudgetEntryPage());

            }

           
        }

        protected override void OnStart()
        {
        }

        protected override void OnSleep()
        {
        }

        protected override void OnResume()
        {
        }
    }
}
