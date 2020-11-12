using System;

class Person
{

public string FirstName {get; set;}
public string LastName {get; set;}

public Person()
{
  FirstName = "unknown";
  LastName = "unknown";
}

public Person(string FN, string LN)
{
  FirstName = FN;
  LastName = LN;
}

public virtual void Intro()
{
Console.WriteLine("My name is " + FirstName + " " + LastName);
}












  
}