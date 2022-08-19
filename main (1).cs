/******************************************************************************

                            Online C# Compiler.
                Code, Compile, Run and Debug C# program online.
Write your code in this editor and press "Run" button to execute it.

*******************************************************************************/

using System;
class HelloWorld {
  static void Main() {
      
      int[] arr=new int[]{1,2,3,4};
      
      
      for(int i=0;i<7;i++){
    try
    {
        Console.WriteLine(arr[i]);
        
    }
    
    catch(Exception ex)
    {
        Console.WriteLine(ex.Message);
    }
    
      }
}
   
}
