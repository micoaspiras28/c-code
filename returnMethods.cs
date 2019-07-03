using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;

namespace methods{

  class Program{

    static void Main(string[] args){

      Console.WriteLine(cube(5)); //Another way of returning value
      int cubeNumber = cube (5); //Another way of returning value

      Console.Readline();
    }
    static int cube(int num){
      int result = num * num * num;
      return result;
    }
  }
}
