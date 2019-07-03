using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;

namespace array{

  class Program{

    static void Main(string[] args){

      int[] luckyNumbers = {9, 10, 5, 7, 4, 3, 2, 39};
      string[] friends = new string[4];
      friends[0] = "Mico";
      friends[1] = "John";
      friends[2] = "Quintero";
      friends[3] = "Michael";

      luckyNumbers[1] = 90; //Change array value
      Console.WriteLine(luckyNumbers[0]); //Print the value of array

      Console.Readline();
    }

  }
}
