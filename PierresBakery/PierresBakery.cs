using System;
using PierresBakery.Models;

namespace PierresBakery
{
  public class MyBakery
  {
      public static void Main()
      {
        Console.WriteLine("Welcome to Pierre's Bakery || Home of Pierre's world-famous gluten-free pastries!");
        Console.WriteLine("---------------------------------------------------------------------------------");
        Console.WriteLine("Pierre's world-famous gluten-free pastries cost $2 a piece. Every third pastry is half off!");
        Console.WriteLine("-------------------------------------------------------------------------------------------");
        
        Console.WriteLine("Please enter the number of pastries you'd like to purchase:");
        string orderPastry = Console.ReadLine();
        int PastriesAmount = int.Parse(orderPastry);

        Console.WriteLine("Please enter the number of bread loaves you'd like to purchase:");
        string orderBread = Console.ReadLine();
        int BreadAmount = int.Parse(orderBread);

        int userPastries = Pastries.PastriesCalculator(2, PastriesAmount);
        int userBread = Bread.BreadCalculator(5, BreadAmount);
        int totalOrder = UserOrder.FinalOrder(userPastries, userBread);

        Console.WriteLine("ORDER TOTAL");
        Console.WriteLine("------------------------");
        Console.WriteLine("You ordered " + PastriesAmount + " world-famous pastries and " + BreadAmount + " loaves of bread");
        Console.WriteLine("------------------------");
        Console.WriteLine("Your total cost is $" + totalOrder);
        Console.WriteLine("------------------------");
        Console.WriteLine("Thank you for visiting Pierre's! Please come back soon.");
      }
  }
}
