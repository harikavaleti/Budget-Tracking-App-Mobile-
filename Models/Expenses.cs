using System;
using System.Collections.Generic;
using System.Text;

namespace BudgetTrackingApp.Models
{
    public class Expenses
    {
        public static decimal Budget { get; set; }
      
        public string FileName { get; set; }
        public  string expenseCategory { get; set; }
        
      //  public static decimal homeExpenseCost { get; set; }
        public  decimal expenseCost { get; set; }
        public DateTime Date { get; set; }
        public string expenseSubCategory { get; set; }
        public decimal subCategoryCost { get; set; }
        public string ImageFile { get; set; }
   
      
        public static bool isFileLoaded { get; set; }
    

     
      /*  public Expenses(string image, decimal expcost, string expcat )
        {
            expenseCategory = expcat;
            expenseCost = expcost;
            ImageFile = image;
        }
        public Expenses(decimal subcatCost, string expsubcat)
        {
            expenseSubCategory = expsubcat;
              subCategoryCost=subcatCost;
        }
      /*  public Expenses( string home, decimal hcost, string util, decimal utilcost, string other,decimal othercost)
        {
            Home = home;
            homeCost = hcost;
            utilities = util;
            UtilCost = utilcost;
            Others = other;
            HMotherCost = othercost;

        }*/

    }

   

}
