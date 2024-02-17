using System;

class Program {
  public static void Main (string[] args) {

      int num = 30;
      for (int i = 1; i <= num; i++){
        if (i % 3 == 0 && i % 5 == 0){
          Console.WriteLine($"{i} - Foobar");
          }
        else if (i % 5 == 0){
          Console.WriteLine($"{i} - Bar");
          }
        else if (i % 3 == 0){
          Console.WriteLine($"{i} - Foo");
          }
        else{
          Console.WriteLine(i);
          }
      }
  }
  }
