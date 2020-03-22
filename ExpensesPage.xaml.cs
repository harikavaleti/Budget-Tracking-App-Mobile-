using BudgetTrackingApp.Models;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;
using Xamarin.Forms.Platform.Android;
using Xamarin.Forms.Xaml;


namespace BudgetTrackingApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class ExpensesPage : ContentPage
    {

        public const string ItemSelectedCommandPropertyName = "ItemSelectedCommand";
        public static BindableProperty ItemSelectedCommandProperty = BindableProperty.Create(
            propertyName: "ItemSelectedCommand",
            returnType: typeof(ICommand),
            declaringType: typeof(ExpensesPage),
            defaultValue: null);

        public ICommand ItemSelectedCommand
        {
            get { return (ICommand)GetValue(ItemSelectedCommandProperty); }
            set { SetValue(ItemSelectedCommandProperty, value); }
        }
        private Expenses _expCategory { get; set; }
        public static string filename { get; set; }
        public static string Categoryfilename { get; set; }
        public static bool IsCategoryFileLoaded { get; set; }
        public static string SelectedCategory {get; set;}

        public ObservableCollection<Expenses> expenses { get; set; }
        public ObservableCollection<Expenses> loadExpensesFromFile { get; set; }

        decimal _expensescost;
        public Expenses expCategory 
        {  
           get
           {
              return _expCategory;
            }

          set
          {
                if (_expCategory != value)
                {
                    _expCategory = value;
                    // expenseCategory();
                }
          }

        }
 

        public ExpensesPage(decimal expensescost)
        {
            InitializeComponent();
            

            Categoryfilename = Path.Combine(App.specificFolder, "CategoryList.txt");
        
            _expensescost = expensescost;

           //   writeListViewToFile();
          //  string x =Expenses.expenseCost.ToString();
           // Expenses.homeExpenseCost = _expensescost;
            var entry = new Entry();
            entry.SetBinding(Entry.TextProperty, new Binding("expenseCost"));
            entry.BindingContext = new { expenseCost = _expensescost};
            
            expenses = new ObservableCollection<Expenses>();
            
            expenses.Add( new Expenses
            {
                expenseCategory = "Home & Utilities    ",
                ImageFile = "Home1.png"
            }
            );

            expenses.Add(new Expenses
            {
                expenseCategory = "Insurance            ",
                ImageFile = "Insurance.jfif"
            });

            expenses.Add(new Expenses
            {
                expenseCategory = "Food                     ",
                ImageFile = "Food.png"
            });

            expenses.Add(new Expenses
            {
                expenseCategory = "Travel                     ",
                ImageFile = "Travel.png"
            });

            expenses.Add(new Expenses
            {
                expenseCategory = "Groceries               ",
                ImageFile = "Groceries.jfif"
            });

            expenses.Add(new Expenses
            {
                expenseCategory = "Shopping & Entertainment",
                ImageFile = "Shopping.jfif"
            });

            expenses.Add(new Expenses
            {
                expenseCategory = "Cash, Checks & Misc",
                ImageFile = "misc.png"
            });
            

         //   ListViewExpenses.ItemsSource = expenses.ToList();
          
        }
      protected override void OnAppearing()
        {
            base.OnAppearing();

           // writeListViewToFile();
            loadExpensesFromFile = new ObservableCollection<Expenses>();
            var items = new List<Expenses>();


            //  string fname = "/data/user/0/com.companyname.budgettrackingapp/files/.config/MarchExpenses/CategoryList.txt";
            

            if (File.Exists(ExpensesPage.Categoryfilename))
            {
                string[] fileData = File.ReadAllLines(Categoryfilename);
                if (fileData.Length > 0)
                {
                    foreach (var line in fileData)
                    {
                        var check = line.Split(':');
                        var exptoload = new List<Expenses>();
                        items.Add(new Expenses
                        {
                            ImageFile = check[2],
                            expenseCost = decimal.Parse(check[1]),
                            expenseCategory = check[0]
                        });

                    }
                }
            }
            else
            {
                return;
            }
         
            ListViewExpenses.ItemsSource = items.ToList();
       }

        
            private  void writeListViewToFile()
            {



             if( IsCategoryFileLoaded == false)
            {

                string s1 =  "Home & Utilities     " + ":"  + "0    " + ":" + "Home1.png";
                    string s2 = "Insurance          " + ":" + "0    " + ":"  + "Insurance.jfif";
                    string s3 =  "Food                 " + ":" + "0    " + ":"  + "Food.png";
                    string s4 =  "Travel                " + ":"  + "0    " + ":" + "Travel.png";
                    string s5 =  "Groceries            " + ":" +  "0    " + ":"  + "Groceries.jfif";
                    string s6 = "Shopping & Entertainment   " + ":" + "0    " + ":"  + "Shopping.jfif";
                    string s7 = "Cash, Checks & Misc   " + ":" + "0    " + ":" + "misc.png";
                   string[] categorydata = {s1,s2,s3,s4,s5,s6,s7 };
                    File.WriteAllLines(Categoryfilename, categorydata);
                IsCategoryFileLoaded = true;
                       // File.AppendAllText(filename, item.expenseCost.ToString());
                       // File.AppendAllText(filename, item.ImageFile);
                }
              /* else
                {
                    File.WriteAllText(item.FileName, item.expenseCategory);
                    File.AppendAllText(item.FileName, item.expenseCost.ToString());
                    File.AppendAllText(item.FileName, item.ImageFile);
                }*/
            }

        

   /*         private void expenseCategory()
        {
           

            string category = expCategory.expenseCategory;

            if(category == "Home & Utilities    ")
            {
                Navigation.PushAsync(new HomeSubCtegory());
            }
            if (category == "Insurance            ")
            {
                Navigation.PushAsync(new HomeSubCtegory());
            }
            if (category == "Food                     ")
            {
                Navigation.PushAsync(new HomeSubCtegory());
            }
            if (category == "Travel                     ")
            {
                Navigation.PushAsync(new HomeSubCtegory());
            }
            if (category == "Groceries               ")
            {
                Navigation.PushAsync(new HomeSubCtegory());
            }
            if (category == "Shopping & Entertainment")
            {
                Navigation.PushAsync(new HomeSubCtegory());
            }
            if (category == "Cash, Checks & Misc")
            {
                Navigation.PushAsync(new HomeSubCtegory());
            }


        }
        */


     /*    public static List<Expenses> loadExpenses()
{
var expenses = new List<Expenses>();

Expenses expenses1 = new Expenses("Home & Utilities", 0, "Home1.png");
expenses.Add(expenses1);

Expenses expenses2 = new Expenses("Insurance",0, $"Insurance.jfif");
expenses.Add(expenses2);

Expenses expenses3 = new Expenses("Food",0, $"Food.png");
expenses.Add(expenses3);

Expenses expenses4 = new Expenses("Travel", 0,$"Travel.png");
expenses.Add(expenses4);

Expenses expenses5 = new Expenses("Groceries",0, $"Groceries.jfif");
expenses.Add(expenses5);

Expenses expenses6 = new Expenses("Shopping & Entertainment",0, $"Shopping.jfif");
expenses.Add(expenses6);

Expenses expenses7 = new Expenses("Cash,Checks & Misc",0, $"misc.png");
expenses.Add(expenses7);

//expensecategories.ItemsSource = expenses.ToList();
foreach(var item in sexpenses.ToArray())
            {
                File.AppendAllLines(Categoryfilename, item);
            }
return expenses;


}*/
/*public static void DisplayExpenseCategories(ObservableCollection<Expenses> categories)
{
List<Expenses> allexpcategories = loadExpenses();
categories.Clear();
allexpcategories.ForEach(x => categories.Add(x));
}*/


        protected override void OnBindingContextChanged()
        {
            base.OnBindingContextChanged();

            RemoveBinding(ItemSelectedCommandProperty);
            SetBinding(ItemSelectedCommandProperty, new Binding(ItemSelectedCommandPropertyName));
        }

     
        public Expenses items { get; set; }
       
        private void HandleItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
         
            if (e.SelectedItem == null)
            {
                return;
            }
            else
            {
                 Expenses item = (Expenses)e.SelectedItem;
                string categoryFile = item.expenseCategory.Trim();
                SelectedCategory = item.expenseCategory.Trim();
               // if (item.expenseCategory == "Home & Utilities     ")
                {
                  //  filename = Path.Combine(App.specificFolder, $"{categoryFile}.txt");

                    Navigation.PushAsync(new HomeSubCtegory());
    
                    ((ListView)sender).SelectedItem = null;// de-select the row
                }
            }

        }

        private void OnBindingContextChanged(object sender, EventArgs e)
        {

        }

   /*     private void expenseCategory(object sender, EventArgs e)
        {
            var item = (Expenses)sender;
            
            if (item.expenseCategory == "Home & Utilities    ")
            {
                filename = Path.Combine(App.specificFolder, $"{item.expenseCategory}.txt");

                Navigation.PushAsync(new HomeSubCtegory());

                ((ListView)sender).SelectedItem = null;// de-select the row
            }
        }
        public class CustomCell : ViewCell
{
Entry ExpCatCost;
public static readonly BindableProperty expcostProperty =
BindableProperty.Create("expenseCost", typeof(decimal), typeof(CustomCell), "expenseCost");
public decimal expenseCost
{
get { return (decimal)GetValue(expcostProperty); }
set { SetValue(expcostProperty, value); }

}

}*/

    }
}