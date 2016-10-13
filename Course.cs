using System;

namespace Inheritance {
  public class Course {
    string CourseTitle {get; set;}
    int Score {get; set;}
    public void PrintCourseInfo() {
      Console.WriteLine("{0, -20}{1, 20}", CourseTitle, Score);
    }
  }
}