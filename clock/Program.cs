using System;
using System.Collections.Generic;
using System.Linq;

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
        if (hours==12)
        {
          hours=0;
        }
        Clock myClock = new Clock();
        Console.WriteLine("The seperation between the clock hands is " 
            + myClock.ClockAngleFinder(hours, minutes) + " degrees.");

    }
  }

  public class Clock
  {
    public string ClockAngleFinder(int hours, int minutes)
    {
      int hourDegrees = hours*30+minutes/2;
      int minuteDegrees = minutes*6;
      int degreeDifference = Math.Abs(minuteDegrees-hourDegrees);
      return degreeDifference.ToString(); 
    }
  }
}