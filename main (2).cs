/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
      
      int Month;
      Month = Convert.ToInt32(Console.ReadLine());
      switch(Month)
   {
	case 1:
	       Console.Write("January");
	       break;
	case 2:
	       Console.Write("February");
	       break;
	case 3:
	       Console.Write("March");
	       break;
	case 4:
	       Console.Write("April");
	       break;
	case 5:
	       Console.Write("May");
	       break;
	case 6:
	       Console.Write("June");
	       break;
	case 7:
	       Console.Write("July");
	       break;
	case 8:
	       Console.Write("August");
	       break;
	case 9:
	       Console.Write("September");
	       break;
	case 10:
	       Console.Write("October");
	       break;
	case 11:
	       Console.Write("November");
	       break;
	case 12:
	       Console.Write("December");
	       break;
	default:
	       Console.Write("invalid input");
	       break;
      }
   }
  
}
