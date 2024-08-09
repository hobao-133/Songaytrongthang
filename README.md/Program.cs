using System;
namespace Songaytrongthang;
class Program{
    static void Main(string[] args){
           Console.WriteLine("Which month that you want to count days? ");
        int month = Int32.Parse(Console.ReadLine()); 
          switch (month)
        {
          case 2:
          Console.WriteLine("The month '2' has 28 or 29 days!");
          break;
          case 1:
          case 3:
          case 5:
          case 7:
          case 8:
          case 10:
          case 12:
          Console.WriteLine("The month '" + month + "' has 31 days!");
          break;
          case 4:
          case 6:
          case 9:
          case 11:
          Console.WriteLine("The month '" + month + "' has 30 days!");
          break;
          default:
          Console.WriteLine("Invalid input!");
          break;

          string daysInMonth; 
          switch (month){
          case 2:
          daysInMonth = "28 or 29";
          break;
          case 1:
          case 3:
          case 5:
          case 7:
          case 8:
          case 10:
          case 12:
          daysInMonth = "31";
          break;
          case 4:
          case 6:
          case 9:
          case 11:
          daysInMonth = "30";
          break;
          default:
          daysInMonth = "";
          break;
        }
        if (daysInMonth != ""){
            Console.WriteLine("The month {0} has {1} days!", month, daysInMonth);
        }
        else{
           Console.WriteLine("Invalid input!");
        }
        }
    }
}