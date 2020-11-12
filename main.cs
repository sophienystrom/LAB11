using System;

class MainClass {
  public static void Main (string[] args) {

  string answer;

  do {
  Faculty facultymember = new Faculty();
  Console.WriteLine("What is the faculty member's first name?");
  facultymember.FirstName = Console.ReadLine();
  Console.WriteLine("What is the faculty member's last name?");
  facultymember.LastName = Console.ReadLine();
  Console.WriteLine("What is the faculty member's date of employment? (mm/dd/yyyy format)");
  facultymember.DateOfEmployment = Convert.ToDateTime(Console.ReadLine());

  /*
  The lab directions did not state if we were supposed to ask for all of the variables so I wrote this section out and did NOT apply it to the code since we were not told to use any of it

  Console.WriteLine("What is the person's id?");
  facultymember.id = Console.ReadLine();
  Console.WriteLine("What is the person's yearly salary?");
  facultymember.YearlySalary = Convert.ToDouble(Console.ReadLine()); 

  also, I made the code kind of with my own twist. I did everything that was listed on the lab sheet but added some extra stuff because it wasn't super duper clear so I assumed there was room for play
  */

  Console.WriteLine("Where does the faculty member work?");
  facultymember.employer = Console.ReadLine();

  Console.WriteLine(" ");

  facultymember.GrantTenure();
  facultymember.Promote();

  Console.WriteLine(" ");

  facultymember.Intro();

  Console.WriteLine(" ");

  Console.WriteLine("Is there another faculty member to report?");
  answer = Console.ReadLine();
  }
  while (answer == "yes" || answer == "Yes");
  
  
  


  










  







  }
}