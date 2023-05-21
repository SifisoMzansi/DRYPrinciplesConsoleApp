
using DryDemoLibrary;

Console.WriteLine("Please enter first name ");
var FirstName =  Console.ReadLine();

Console.WriteLine("Please enter Last Name ");
var LastName = Console.ReadLine();


EmployeeProcessor EmployeeProcessors = new EmployeeProcessor();

string EmployeeID = EmployeeProcessors.GenerateEmployeeId(FirstName, LastName); ;

Console.WriteLine(EmployeeID);

 