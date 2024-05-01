using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static LabOne.Program;
using static System.Net.Mime.MediaTypeNames;

/*
 * Lab to be done individually
 * In order to be graded, the following Statement of Authorship must be present at the beginning of the script
 * I, Jacob Robbins, student number 000371194, certify that this material is my original work. No other person's work has been used without 
 * due acknowledgment and I have not made my work available to anyone else.
 * Author: Jacob Robbins
 * Date: February 2023 
 * Description: Out of Sorts 
*/

namespace LabOne
{
    internal class Program
    {
        public static Employee[] employees;
        public static int count;
        public static bool notExit = true;

        /// <summary>
        /// Class for the Sort Methods
        /// </summary>
        class Sort
        {
            /// <summary>
            ///  Names Asc - display employees by hours in ascemding fashion
            /// </summary>
            /// <param name="employees"></param>
            /// <param name="count"></param>
            public void NamesAsc(Employee[] employees, int count)
            {
                for (int i = 1; i < count; ++i)
                {
                    int key = employees[i].GetNumber();
                    int j = i - 1;

                    while (j >= 0 && employees[j].GetNumber() > key)
                    {
                        employees[j + 1] = employees[j];
                        j = j - 1;
                    }
                }
            }
            /// <summary>
            ///  Numbers Asc - display employees by hours in Asc fashion
            /// </summary>
            /// <param name="employees"></param>
            /// <param name="count"></param>
            public void NumberAsc(Employee[] employees, int count)
            {
                for (int i = 1; i < count; ++i)
                {
                    int key = employees[i].GetNumber();
                    int j = i - 1;

                    while (j >= 0 && employees[j].GetNumber() > key)
                    {
                        employees[j + 1] = employees[j];
                        j = j - 1;
                    }
                }
            }
            /// <summary>
            ///  Rate Desc - display employees by rate in descending fashion
            /// </summary>
            /// <param name="employees"></param>
            /// <param name="count"></param>
            public void RateDesc(Employee[] employees, int count)
            {
                for (int i = 1; i < count; ++i)
                {
                    decimal key = employees[i].GetRate();
                    int j = i - 1;

                    while (j >= 0 && employees[j].GetRate() < key)
                    {
                        employees[j + 1] = employees[j];
                        j = j - 1;
                    }
                }
            }

            /// <summary>
            /// Hours Desc - display employees by hours in descending fashion
            /// </summary>
            /// <param name="employees"></param>
            /// <param name="count"></param>
            public void HoursDesc(Employee[] employees, int count)
            {
                for (int i = 1; i < count; ++i)
                {
                    double key = employees[i].GetHours();
                    int j = i - 1;

                    while (j >= 0 && employees[j].GetHours() < key)
                    {
                        employees[j + 1] = employees[j];
                        j = j - 1;
                    }
                }
            }
            /// <summary>
            /// Gross Desc - display employees by gross in descending fashion
            /// </summary>
            /// <param name="employees"></param>
            /// <param name="count"></param>
            public void GrossDesc(Employee[] employees, int count)
            {
                for (int i = 1; i < count; ++i)
                {
                    double key = employees[i].GetHours();
                    int j = i - 1;

                    while (j >= 0 && employees[j].GetHours() < key)
                    {
                        employees[j + 1] = employees[j];
                        j = j - 1;
                    }
                }
            }

            /// <summary>
            /// Menu function - used to ensure the menu will be open until the user chooses
            /// for the menu to close. 
            /// </summary>
            /// <param name="notExit"></param>
            public static void Menu(bool notExit)
            {
                while (notExit)
                {
                    Console.WriteLine("Please choose one of the 6 options:");
                    Console.WriteLine("====================================");
                    Console.WriteLine("1: Sort Employee by Name");
                    Console.WriteLine("2: Sort Employee by Number");
                    Console.WriteLine("3: Sort Employee by Pay Rate");
                    Console.WriteLine("4: Sort Employee by Hours");
                    Console.WriteLine("5: Sort Employee by Gross Pay");
                    Console.WriteLine("6: Exit Application");
                    Console.WriteLine("====================================");

                    try
                    {
                        int userInput = int.Parse(Console.ReadLine());
                        
                        switch (userInput)
                        {

                            case 1:
                                Console.Clear();

                                //Names ASC
                                Console.WriteLine("Employees by Names : ASC");
                                Console.WriteLine("Name =========== Number ==== Rate ==== Hours ==== Gross");
                                Console.WriteLine("====================================");
                                //instantiates Sort class object
                                Sort obOG = new Sort();
                                //deploys sort technique
                                obOG.NamesAsc(employees, count);
                                //displays new array
                                DisplayEmployee(employees, count);
                                //Request for user input 
                                Console.WriteLine("Press Enter to Continue");
                                Console.ReadLine();
                                //Re-reads original array
                                Read(out employees, out count);
                                Console.Clear();
                                break;

                            case 2:
                                Console.Clear();

                                //Numbers ASC
                                Console.WriteLine("Employees by Number : ASC");
                                Console.WriteLine("Name =========== Number ==== Rate ==== Hours ==== Gross");
                                Console.WriteLine("====================================");
                                //instantiates Sort class object
                                Sort ob = new Sort();
                                //deploys sort technique
                                ob.NumberAsc(employees, count);
                                //displays new array
                                DisplayEmployee(employees, count);
                                //Request for user input 
                                Console.WriteLine("Press Enter to Continue");
                                Console.ReadLine();
                                //Re-reads original array
                                Read(out employees, out count);
                                Console.Clear();
                                break;


                            case 3:
                                Console.Clear();

                                //Rate DESC
                                Console.WriteLine("Employees by Pay Rate : DESC");
                                Console.WriteLine("Name =========== Number ==== Rate ==== Hours ==== Gross");
                                //instantiates Sort class object
                                Sort ob2 = new Sort();
                                //deploys sort technique
                                ob2.RateDesc(employees, count);
                                //displays new array 
                                DisplayEmployee(employees, count);

                                Read(out employees, out count);
                                Console.WriteLine("To be implemented");
                                Console.WriteLine("====================================");
                                Console.WriteLine("Press Enter to Continue");
                                Console.ReadLine();
                                Console.Clear();
                                break;


                            case 4:
                                Console.Clear();
                                //DESC
                                Console.WriteLine("Employees by Hours : DESC");
                                Console.WriteLine("Name =========== Number ==== Rate ==== Hours ==== Gross");
                                Sort ob3 = new Sort();
                                //deploys sort technique
                                ob3.HoursDesc(employees, count);
                                //displays new array 
                                DisplayEmployee(employees, count);
                                Read(out employees, out count);
                                Console.WriteLine("To be implemented");
                                Console.WriteLine("====================================");
                                Console.WriteLine("Press Enter to Continue");
                                Console.ReadLine();
                                Console.Clear();
                                break;


                            case 5:
                                Console.Clear();
                                //DESC
                                Console.WriteLine("Employees by GrossPay : DESC");
                                Console.WriteLine("Name =========== Number ==== Rate ==== Hours ==== Gross");
                                Sort ob4 = new Sort();
                                //deploys sort technique
                                ob4.GrossDesc(employees, count);
                                //displays new array 
                                DisplayEmployee(employees, count);
                                Read(out employees, out count);
                                Console.WriteLine("To be implemented");
                                Console.WriteLine("====================================");
                                Console.WriteLine("Press Enter to Continue");
                                Console.ReadLine();
                                Console.Clear();
                                break;

                            case 6:
                                notExit = false;
                                Environment.Exit(0);
                                break;
                            default:
                                Console.Clear();
                                Console.WriteLine("Please select a number between 1 and 6");
                                Console.WriteLine("\n");
                                break;
                        }
                    }

                    catch (Exception ex)
                    {
                        Console.Clear();
                        Console.WriteLine(ex.Message);
                        Console.WriteLine("Input must be numbers 1 through 6");
                        Console.WriteLine("\n");
                    }
                }

            }

            /// <summary>
            /// Read Method - this method is used to read data from txt and place the data into appropriate fields 
            /// from within the employee class
            /// </summary>
            /// <param name="employees"></param>
            /// <param name="count"></param>
            public static void Read(out Employee[] employees, out int count)
            {
                count = -1;
                string input;
                employees = new Employee[100];

                try
                {
                    //Read File
                    FileStream file = new FileStream("employees.txt", FileMode.Open, FileAccess.Read);
                    //using Stream reader object to sort through file
                    StreamReader sr = new StreamReader(file);

                    //While the stream reader has data 
                    while ((input = sr.ReadLine()) != null)
                    {
                        //Parse
                        count++;
                        //split data at ',' delimiter
                        string[] lines = input.Split(',');
                        //store in employees array
                        employees[count] = new Employee(lines[0], int.Parse(lines[1]), decimal.Parse(lines[2]), double.Parse(lines[3]));
                    }
                    sr.Close();
                }

                // Just in case the file can't be found - graceful exit
                catch (IOException e)
                {
                    //Exceptions
                    Console.WriteLine(e.Message);
                    Console.WriteLine("Data in file not consistenet\n");
                    Environment.Exit(0);
                }
            }

            /// <summary>
            /// Display Employee - this method is used in order to display the initial 
            /// output for the employee array
            /// </summary>
            /// <param name="employees"></param>
            /// <param name="count"></param>
            public static void DisplayEmployee(Employee[] employees, int count)
            {
                for (int i = 0; i < count; i++)
                {
                    Console.WriteLine(employees[i]);
                }
            }

            /// <summary>
            /// Main method which is modularized for the user/owner
            /// </summary>
            /// <param name="args"></param>
            static void Main(string[] args)
            {
                //Read file into employees array
                Read(out employees, out count);

                //Debug
                Console.WriteLine();

                //Menu until notExit
                Menu(notExit);

                //Keep oprn
                Console.ReadLine();
            }
        }
    }
}


