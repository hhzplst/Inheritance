using System;
using System.Collections.Generic;

namespace Inheritance {
  public class Student : Person {
    private List<Course> courses = new List<Course>();
    public Student(string firstName, string lastName) : base(firstName, lastName) {}
    public void AddTakenCourse(Course c) {
      courses.Add(c);
    }
    public void PrintTranscript() {
      PrintHeader();
      foreach (Course c in courses)
        c. PrintCourseInfo(); 
    }
    private void PrintHeader() {
      Console.WriteLine("{0, -20}{1, 10}\n******************************", "Title", "Score");
    }
  }
}