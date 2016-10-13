namespace Inheritance {
  public class FTEmployee : Employee {
    const double HOUR_PER_WEEK = 40.0;
    public FTEmployee(string firstName, string lastName) : base(firstName, lastName) {}
    public double Salary {get; set;}
    public override double TotalHour {
      get{
        return HOUR_PER_WEEK;
      } 
    }
    public override double TotalWage {
      get{
        return Salary;
      } 
    }
  }
}