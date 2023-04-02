using GabesConsoleApp;
using GabesConsoleApp.HR;

List<Employee> employees = new List<Employee>();

Console.ForegroundColor = ConsoleColor.Green;
Console.WriteLine("---------------------------");
Console.WriteLine(" *** Maday's Book Shop *** ");
Console.WriteLine("---------------------------");
Console.ForegroundColor = ConsoleColor.White;

string userSelection;
Console.ForegroundColor = ConsoleColor.Blue;

Utilities.CheckForExistingEmployeeFile();

do
{
    Console.ForegroundColor = ConsoleColor.Cyan;
    Console.WriteLine($"Loaded {employees.Count} employee(s)\n\n");

    Console.ForegroundColor = ConsoleColor.White;
    Console.WriteLine("1. Register employee");
    Console.WriteLine("2. View all employees");
    Console.WriteLine("3. Save data");
    Console.WriteLine("4. Load Data");
    Console.WriteLine("5. Load specific employee");
    Console.WriteLine("9. Exit Application");
    Console.Write("Your selection: ");

    userSelection = Console.ReadLine();

    switch (userSelection)
    {
        case "1":
                Utilities.RegisterEmployee(employees);
            break;
        case "2":
                Utilities.ViewAllEmployees(employees);
            break;
        case "3":
                Utilities.SaveEmployees(employees);
            break;
        case "4":
                Utilities.LoadEmployees(employees);
            break;
        case "5":
            Utilities.LoadEmployeeById(employees);
            break;
        case "9": break;
        default:
            Console.WriteLine("Invalid selection. Please try again.");
            break;
    }
}
while (userSelection != "9");

Console.WriteLine("Thank you, goodbye!");