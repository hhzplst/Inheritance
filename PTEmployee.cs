using System.Collections.Generic;

namespace Inheritance {
  public class PTEmployee : Employee {
    private List<double> hours = new List<double>();
    public double HourlyRate {get; set;}
    public override double TotalHour {
      get {
        double result = 0;
        foreach (double h in hours)
          result += h;
        return result; 
      } 
    }
    public override double TotalWage {
      get{
        return HourlyRate * TotalHour;
      } 
    }
    public PTEmployee(string firstName, string lastName) : base(firstName, lastName) {}
    public void RecordHour(double hour) {
      hours.Add(hour);
    }
  }
}