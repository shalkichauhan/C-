// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");

using System;
using System.Collections.Generic;


namespace Hello
{
    public class Program
    {
        static void Main(string[] args)
        {


            string[,] myGroceryList = new string[,] { {"apple", "Banana" },{"orange","guvava"}};
            Console.WriteLine(myGroceryList[1,0]);
            Dictionary<string, string> myDict = new Dictionary<string, string>(){{"shalki","job"},{"Zubin","work"}};
            Console.WriteLine(myDict["shalki"]);
            string[] fruitList = { "grapes", "avacado" };
            Console.WriteLine(fruitList[1]);

            List<string> myVegList =  new List<string>(){"peas", "potato"};
            myVegList.Add("eggplant");
            Console.WriteLine(myVegList[2]);
            
            
            Console.ReadLine();




        }
        
        
    }
}
