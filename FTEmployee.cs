using System;

namespace Inheritance {
  public class FTEmployee : Employee {
    public FTEmployee(string firstName, string lastName) : base(firstName, lastName) {}
    public double Salary {get; set;}

  }
}