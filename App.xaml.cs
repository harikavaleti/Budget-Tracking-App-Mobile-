using BudgetTrackingApp.Models;
using System;
using System.IO;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace BudgetTrackingApp
{
    public partial class App : Application
    {
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
            if(SetInitialBudget == false)
            {
                MainPage = new NavigationPage(new BudgetEntryPage());
            }
            else
            {
               BudgetCost = Expenses.Budget;
               MainPage = new NavigationPage(new AddExpenses());

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
