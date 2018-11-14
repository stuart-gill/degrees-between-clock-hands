using System;
using System.Collections.Generic;
using System.Linq;
using Clock;

namespace ClockProgram
{
 public class Program
  {
    static void Main(string[] args)
    {
        Console.WriteLine("Enter hours: ");
        int hours = int.Parse(Console.ReadLine());
        Console.WriteLine("Enter minutes: ");
        int minutes = int.Parse(Console.ReadLine());
        Clock myClock = new Clock();
        Console.WriteLine("The degrees of seperation between the clock hands are :" 
            + myClock.ClockAngleFinder(hours, minutes));

    }
  }
}