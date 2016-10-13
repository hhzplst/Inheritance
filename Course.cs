using System;

namespace Inheritance {
  public class Course {
    public Course(string title, int score) {
      CourseTitle = title;
      Score = score;
    }
    string CourseTitle {get; set;}
    int Score {get; set;}
    public void PrintCourseInfo() {
      Console.WriteLine("{0, -20}{1, 10}", CourseTitle, Score);
    }
  }
}