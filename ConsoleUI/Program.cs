
Console.WriteLine("Please enter first name ");
var FirstName =  Console.ReadLine();

Console.WriteLine("Please enter Last Name ");
var LastName = Console.ReadLine();

string EmployeeID =GenerateEmployeeUD(FirstName, LastName); ;

Console.WriteLine(EmployeeID);


string GenerateEmployeeUD(string firstName, string lastName)
{
    return $@"{firstName.Substring(0, 4)}{lastName.Substring(0, 4)}{DateTime.Now.Microsecond}";

}