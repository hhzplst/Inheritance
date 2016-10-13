using System;

namespace Inheritance {
  public abstract class Employee : Person {
    public abstract int TotalHour {get; set;}
    public abstract int AvgHour {get; set;}
    public abstract int TotalWage {get; set;}
    public string Department {get; set;}
    public Employee(string firstName, string lastName) : base(firstName, lastName) {}
    
    public override string ToString() {
      return String.Format("**********************************************************\n" +
                           "{0, -10} {1, -15} {2, -15} {3, -20}{4, -10}{5, -10}{6, -10}\n" +
                           "**********************************************************\n" + 
                           "{4, -10} {5, -15} {6, -15} {7, -20}{4, -10}{5, -10}{6, -10}\n", "ID", "FIRSTNAME", "LASTNAME", "FULLNAME", 
                           "HOURS", "AVG HOURS", "WAGE", 
                           ID, FirstName, LastName, GetFullName(), TotalHour, AvgHour, TotalWage);
    }
  }
}