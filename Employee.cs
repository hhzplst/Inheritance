using System;

namespace Inheritance {
  public abstract class Employee : Person {
    public virtual double TotalHour {get;}
    public double AvgHour {
      get{
        return TotalHour / 4;
      }
    }
    public virtual double TotalWage {get; }
    public string Department {get; set;}
    public Employee(string firstName, string lastName) : base(firstName, lastName) {}

    public override string ToString() {
      return String.Format("\n*****************************************************************************\n" +
                           "{0, -10}{1, -15}{2, -15}{3, -12}{4, -10:f}{5, -10:f}{6, -10:f}\n" +
                           "*****************************************************************************\n" + 
                           "{7, -10}{8, -15}{9, -15}{10, -12}{11, -10}{12, -10}${13, -10}\n", "ID", "FIRSTNAME", "LASTNAME", 
                           "DPT", "HOURS", "AVGHOURS", "WAGE", 
                           ID, FirstName, LastName, Department, TotalHour, AvgHour, TotalWage);
    }
  }
}