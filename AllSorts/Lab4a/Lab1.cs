///
/// Program: Employee Sort
/// 
/// Author: Nicholas J. Corkigian
/// Date:   February 2010
/// 
/// Purpose:  This program reads the employee.txt data file and stores the information in an array of
///           Employee objects.  The user is then presented with a menu that allows them to select which
///           of five fields to sort the resultant table by: Employee name, ID, rate, hours, or gross pay.
///           
///           The program ends when the user selects the exit option from the menu.
///
using System;
using System.Collections.Generic;
using System.IO;


/// <summary>
/// This is the main tester class that the program starts at
/// </summary>
class Lab1
{
    /// <summary>
    /// The main method reads the data file, populates the Employee array and provides a menu of sort options.
    /// </summary>
    /// <param name="args">Command line arguments are not used in this program</param>
    static void Main(string[] args)
    {
        int count;                                      // Keep track of how many employees are instantiated
        bool loop = true;                               // A loop control variable
        string input;                                   // The user's menu option pick as a string
        int choice;                                     // The user's menu option pick as an integer
        List<Employee> employees = new List<Employee>();

        // Read the data file to build the Employee array and find out how many there are
        Read(ref employees, out count);

        // Keep the menu loop running so the user can sort several times
        while (loop)
        {
            // Display the menu and retrieve the user's choice
            input = Menu();

            // Based on the user's entry, sort using the appropriate option
            if (Int32.TryParse(input, out choice))
            {
                switch (choice)
                {
                    // Sort by employee name - ascending
                    case 1:
                        Sort(employees, 1);
                        break;

                    // Sort by employee ID number - ascending
                    case 2:
                        Sort(employees, 2);
                        break;

                    // Sort by hourly rate - descending
                    case 3:
                        Sort(employees, 3);
                        break;

                    // Sort by weekly hours - descending
                    case 4:
                        Sort(employees, 4);
                        break;

                    // Sort by gross pay - descending
                    case 5:
                        Sort(employees, 5);
                        break;

                    // Exit the program
                    case 6:
                        loop = false;
                        break;

                    // Trap invalid selections to try again
                    default:
                        Console.WriteLine("\n*** Invalid Choice - Try Again ***\n");
                        break;
                }

                // Display the table when a valid choice is made, otherwise display an error
                if (choice >= 0 && choice <= 5)
                    DisplayTable(employees);
            }
            else
                Console.WriteLine("\n*** Invalid Choice - Try Again ***\n");
        }
    }

    /// <summary>
    /// This method displays the entire table, including column headers
    /// </summary>
    /// <param name="employees">The array of employees</param>
    /// <param name="count">How many employees are in use</param>
    private static void DisplayTable(List<Employee> employees)
    {
        Console.Clear();
        Console.WriteLine("Employee              Number    Rate  Hours  Gross Pay           Nick's Company");
        Console.WriteLine("====================  ======  ======  =====  =========           --------------");

        // Display each employee in the array
        foreach (Employee record in employees)
            System.Console.WriteLine("{0, -20} {1:D5} {2,6:C} {3:#0.00} {4,9:C}", record.Name, record.Number, record.Rate, record.Hours, record.Gross);
        Console.WriteLine();
    }

    /// <summary>
    /// This method displays the menu options to the user and returns their selection
    /// </summary>
    /// <returns>The user's menu selection</returns>
    private static string Menu()
    {
        Console.WriteLine("1. Sort by Employee Name");
        Console.WriteLine("2. Sort by Employee Number");
        Console.WriteLine("3. Sort by Employee Pay Rate");
        Console.WriteLine("4. Sort by Employee Hours");
        Console.WriteLine("5. Sort by Employee Gross Pay");
        Console.WriteLine("\n6. Exit");
        Console.Write("\nEnter choice: ");

        return Console.ReadLine();
    }

    /// <summary>
    /// This method reads the data file and stores all of the employee information in an array of Employees
    /// </summary>
    /// <param name="employees">The array of employees</param>
    /// <param name="count">How many employees are in use</param>
    private static void Read(ref List<Employee> employees, out int count)
    {
        count = 0;                                    // The current number of employees
        string input;                                 // One line of data read from the file
                                                      // The Employee array

        try
        {
            // Open the file for reading purposes
            FileStream file = new FileStream("employees.txt", FileMode.Open, FileAccess.Read);
            StreamReader reader = new StreamReader(file);

            // As long as there is data in the file, keep processing 
            // Each employee record is comma separated, so explode each piece into an array,
            // create a new employee object and increment the count
            while ((input = reader.ReadLine()) != null)
            {
                string[] exploded = input.Split(',');
                employees.Add(new Employee(exploded[0], int.Parse(exploded[1]), decimal.Parse(exploded[2]), double.Parse(exploded[3])));

            }

            reader.Close();                             // Always good form to close the file
        }

        // Just in case the file can't be found - graceful exit
        catch (IOException e)
        {
            Console.WriteLine("*** File is empty - Program Aborting ***\n");
            Environment.Exit(1);
        }
    }

    /// <summary>
    /// This method uses a Bubble Sort to rearrange the Employee array in order.  Since there are 
    /// five possible ways to sort, the outer loops remain the same and instead the condition is
    /// different for each field to sort on.
    /// </summary>
    /// <param name="emps">The array of employees</param>
    /// <param name="size">How many employees are in use</param>
    /// <param name="choice">The user selected sort choice</param>
    public static void Sort(List<Employee> emps, int choice)
    {
        Employee.sortOption = choice;
        emps.Sort();
        DisplayTable(emps);
    }

    /// <summary>
    /// This method is a utility method for the Bubble Sort.  It just swaps two elements in the array
    /// </summary>
    /// <param name="a">First employee</param>
    /// <param name="b">Second employee</param>

}

