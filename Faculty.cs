using System;

class Faculty : Person
{

//properties
public string id {get; set;}
public string title {get; set;}
public virtual DateTime DateOfEmployment {get; set;}
public string employer {get; set;}
public double YearlySalary {get; set;}
public bool Tenured {get; set;}
public int YearsWork;

public Faculty() : base()
{
Console.WriteLine("Faculty member constructor");
title = "Instructor";
}

public Faculty(string FN, string LN) : base(FN, LN)
{
Console.WriteLine("Faculty member constructor");
title = "Instructor";
}

public void GrantTenure()
{
 YearsWork = DateTime.Today.Year - DateOfEmployment.Year;

 if (YearsWork >= 5)
 {
 Tenured = true;
 Console.WriteLine("Tenure granted!");
 }
 else 
 {
 Tenured = false;
 Console.WriteLine("Tenure not granted :( ");
 }
}

public void Promote()
{
YearsWork = DateTime.Today.Year - DateOfEmployment.Year;

if (title == "Instructor" && YearsWork > 2)
{
title = "Assistant Professor";
Console.WriteLine("Faculty promoted to Assistant Professor rank!!");
}
else if (title == "Assistant Professor" && YearsWork > 5)
{
title = "Associate Professor";
Console.WriteLine("Faculty promoted to Associate Professor rank!!");
}
else if (title == "Associate Professor" && YearsWork > 10)
{
title = "Professor";
Console.WriteLine("No more promotions possible");
}
else 
{
Console.WriteLine("Faculty member is not eligible for a promotion :(");
}
}

public override void Intro()
{
base.Intro();
Console.WriteLine("I have been working as a " + title + " at " + employer + " since " + DateOfEmployment.Year);
}















}