
/* Purpose:Employee Class; filters and provides attributes for the Employees read from the employees file 
 * Date of submission :11/27/22
 * I, Jacob Robbins, 000371194 certify that this material is my original work.  
 * No other person's work has been used without due acknowledgement.
 * This code is also mostly from class i should mention
 * For the user: Please use this application to sort through the Employees.txt data sheet
 * this is not a multi-purpose application
 */

using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;

/// <summary>
/// Public Class Employee
/// sets parameters for the employee's attributes
/// </summary>
public class Employee : IComparable<Employee>
{
    public string Name { get; set; }  
    public int Number { get; set; }                          
    public decimal Rate { get; set; }                         
    public double Hours { get; set; }                         
    public decimal Gross { get; set; }
    public static int sortOption { get; set; }

    /// <summary>
    /// Employee Constructor - Builds upon the Employee class and sets attributes 
    /// </summary>
    /// <param name="name">Employee name</param>
    /// <param name="number">Employee number</param>
    /// <param name="rate">Hourly rate of pay</param>
    /// <param name="hours">Hours worked in a week</param>
    public Employee(string name, int number, decimal rate, double hours)
    {
        Name = name;
        Number = number;
        Rate = rate;
        Hours = hours;
        if (hours < 40)
        {
            Gross = (decimal)rate * (decimal)hours;
        }
        else
        {
            Gross = 40m * rate + ((decimal)hours - 40m) * rate * 1.5m;
        }
        sortOption = 1;

    }

    public int CompareTo(Employee rhs)
    {
        if (sortOption == 1)
        {
            return this.Name.CompareTo(rhs.Name);
        }
        else if (sortOption == 2)
        {
            return this.Number.CompareTo(rhs.Number);
        }
        else if (sortOption == 3)
        {
            return this.Rate.CompareTo(rhs.Rate);
        }
        else if (sortOption == 4)
        {
            return this.Hours.CompareTo(rhs.Hours);
        }
        else if (sortOption == 5)
        {
            return this.Gross.CompareTo(rhs.Gross);
        }
        else
            return 0;

    }
}