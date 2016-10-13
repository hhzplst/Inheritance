using System;

namespace Inheritance {
  public class Test {
    public static void Main (string[] args) {
      Student myStudent = new Student("Ivy", "Chang");
      Course course = new Course("C# Programming Language", 95);
      myStudent.AddTakenCourse(course);
      course = new Course("JAVA I", 70);
      myStudent.AddTakenCourse(course);
      myStudent.PrintTranscript();
    }
    
    
  }
}