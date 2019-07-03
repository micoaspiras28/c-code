using System;
using System.Collections.Generic;
using System.Ling;
using System.Text;
using System.Threading.Tasks;

namespace methods{

  class Program{

    static void Main(string[] args){
      //This methods allow user to say hi!

      SayHi("Mico", 33);
      SayHi("John", 12);
      SayHi("Michael", 34);
      Console.Readline();
    }

    static void SayHi(string name, int age){
      Console.WriteLine("Hello" + name + "you are " + age);
    }
  }
}
