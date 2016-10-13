using System;

namespace Inheritance {
  public class Test {
    public static void Main (string[] args) {
      Student myStudent = new Student("Ivy", "Chang");
      Course course = new Course("C#", 95);
      myStudent.AddTakenCourse(course);
      course = new Course("JAVA I", 70);
      myStudent.AddTakenCourse(course);
      Console.WriteLine("Printing Transcript for {0}...\n", myStudent.GetFullName());
      myStudent.PrintTranscript();

      FTEmployee myFTEmployee = new FTEmployee("Adam", "Lee");
      PTEmployee myPTEmployee = new PTEmployee("Lily", "Jackson");
      
      myFTEmployee.Department = "IT";
      myFTEmployee.Salary = 6000;

      myPTEmployee.Department = "Marketing";
      myPTEmployee.HourlyRate = 25.5;
      myPTEmployee.RecordHour(20);
      myPTEmployee.RecordHour(15.5);
      myPTEmployee.RecordHour(30);
      myPTEmployee.RecordHour(10);

      Console.WriteLine("Printing Adam's information...");
      Console.WriteLine(myFTEmployee);

      Console.WriteLine("Printing Lily's information...");
      Console.WriteLine(myPTEmployee);

    }
  }
}

/*********************************TEST OUTPUT************************************

➜  Inheritance git:(master) ✗ dotnet run
Project Inheritance (.NETCoreApp,Version=v1.0) will be compiled because inputs were modified
Compiling Inheritance for .NETCoreApp,Version=v1.0

Compilation succeeded.
    0 Warning(s)
    0 Error(s)

Time elapsed 00:00:01.7711567
 

Printing Transcript for Ivy Chang...

Title                    Score
******************************
C#                          95
JAVA I                      70

Printing Adam's information...

*****************************************************************************
ID        FIRSTNAME      LASTNAME       DPT         HOURS     AVGHOURS  WAGE      
*****************************************************************************
1002      Adam           Lee            IT          40        10        $6000      

Printing Lily's information...

*****************************************************************************
ID        FIRSTNAME      LASTNAME       DPT         HOURS     AVGHOURS  WAGE      
*****************************************************************************
1003      Lily           Jackson        Marketing   75.5      18.875    $1925.25   



********************************END TEST OUTPUT**********************************/