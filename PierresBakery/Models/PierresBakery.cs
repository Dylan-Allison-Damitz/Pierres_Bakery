using System;
using PierresBakery;

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
        if (orderPastry == "1"){
          Console.WriteLine("Dinkin Flicka");
        }
        //int inputNumber = Convert.ToInt32(Console.ReadLine()); idea for parsing?
    }
  }
}