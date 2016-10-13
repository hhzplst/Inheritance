using System;
using System.Collections.Generic;

namespace Inheritance {
  public class PTEmployee : Employee {
    private List<int> hours = new List<int>();
    public double HourlyRate {get; set;}
    public PTEmployee(string firstName, string lastName) : base(firstName, lastName) {}
    public void RecordHour(int hour) {
      hours.Add(hour);
    }
  }
}