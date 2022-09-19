using System;
using System.Collections.Generic;
using System.Linq;

namespace PingPongTable
{
  public class Program 
  {
    public static void Main() 
    {
      Console.WriteLine("Welcome to Ping Pong!");
      Console.WriteLine("-----------------------");
      Console.WriteLine("Enter a number: ");
      string stringUserInput = Console.ReadLine();
      int UserInput = int.Parse(stringUserInput);
      List<string> PingPong = new List<string> {};

      for (int index = 1; index <= UserInput; index++)
      {
        if (index % 3 == 0 && index % 5 == 0)
        {
          //Console.WriteLine("Ping-Pong");
          PingPong.Add("Ping-Pong");
        } else if (index % 5 == 0)
        {
          //Console.WriteLine("Ping");
          PingPong.Add("Ping");
        } else if (index % 3 == 0)
        {
          //Console.WriteLine("Pong");
          PingPong.Add("Pong");
        } else
        {
          //Console.WriteLine(index);
          PingPong.Add(index.ToString());
        }
      }
      Console.WriteLine(PingPong[14]);
    }
  }
}
