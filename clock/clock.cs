using System;
namespace ClockProgram
{


public class Clock
  {

    public int Hours;
    public int Minutes;

    public Clock(int hours, int minutes)
    {
        Hours = hours;
        Minutes = minutes;
    }

    public string ClockAngleFinder(int hours, int minutes)
    {
      int hourDegrees = hours*30+minutes/2;
      int minuteDegrees = minutes*6;
      int degreeDifference = Math.Abs(minuteDegrees-hourDegrees);
      return degreeDifference.ToString(); 
    }
  }
}