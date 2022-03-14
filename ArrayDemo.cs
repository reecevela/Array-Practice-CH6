using System;
using static System.Console;
class ArrayDemo
{
   static void Main()
   {
      int[] nums = {7, 6, 3, 2, 10, 8, 4, 5, 9, 1};
      string choice = "";
      // Write your main here
      string[] statements = {"Enter order number: ",
        "1:F-to-L", "2:L-to-F", "3:Specific location",
        "4:Quit"};
      foreach(string statement in statements)
        WriteLine(statement);

      while(choice != "4"){
       choice = ReadLine();
       switch (choice)
       {
         case "1":
           for(var i = 0; i < nums.Length; ++i){
             Write(nums[i].ToString());
           }
           Write("\n");
           break;
         case "2":
           for(var i = nums.Length-1; i > 0; --i){
             Write(nums[i].ToString());
           }
           Write("\n");
           break;
         case "3":
           break;
         default:
           break;
       }
      }
   }  
}
