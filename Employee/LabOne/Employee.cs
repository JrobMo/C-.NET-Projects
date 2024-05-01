using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabOne
{
    public class Employee
    {

        private string name;
        private int number;
        private decimal rate;
        private double hours;
        private decimal gross;

        /// <summary>
        /// Employee = the constructor used to construct the Employee Object 
        /// </summary>
        /// <param name="name">Employee name</param>
        /// <param name="number">Employee number</param>
        /// <param name="rate">Employee rate</param>
        /// <param name="hours">Employee hours</param>
        public Employee(string name, int number, decimal rate, double hours)
        {
        SetName(name);
        SetNumber(number);
        SetRate(rate);
        SetHours(hours);
        gross = GetGross();
        }
        /// <summary>
        /// GetGross - used to calculate the gross pay of the Employee
        /// </summary>
        /// <returns></returns>
        public decimal GetGross()
        {
            gross = rate * Convert.ToDecimal(hours);
            if (hours >= 40)
            {
                gross = rate * Convert.ToDecimal(hours * 1.5);
            };
            return gross;
        }

        /// <summary>
        ///  GetHours - used to get the hours worked from the employee
        /// </summary>
        /// <returns></returns>
        public double GetHours()
        {
            return hours;
        }
        /// <summary>
        /// GetName - used to get the names of the employees worked
        /// </summary>
        /// <returns></returns>
        public string GetName()
        {
            return name;
        }
        /// <summary>
        /// GetNumber - used to get the numbers assigned to employees
        /// </summary>
        /// <returns></returns>
        public int GetNumber()
        {
            return number;
        }
        /// <summary>
        /// GetRate - used to get the rate assigned to employees
        /// </summary>
        /// <returns></returns>
        public decimal GetRate()
        {
            return rate;
        }

        /// <summary>
        /// SetHours - used to set the hours of the employees 
        /// </summary>
        /// <param name="value"></param>
        public void SetHours(double value)
        {
            hours = value;
        }

        /// <summary>
        /// SetName - used to set the names of the employees
        /// </summary>
        /// <param name="value"></param>
        public void SetName(string value)
        {
            name = value;
        }

        /// <summary>
        /// SetNumber - used to set the numbers of the employees
        /// </summary>
        /// <param name="value"></param>
        public void SetNumber(int value)
        {
            number = value;
        }

        /// <summary>
        /// SetRate - used to set the rate of the employees
        /// </summary>
        /// <param name="value"></param>
        public void SetRate(decimal value)
        {
            rate = value;
        }

        /// <summary>
        /// Override toString to print the values assigned to the employees
        /// </summary>
        /// <returns></returns>
        public override String ToString() => $"{GetName(),-20}  {GetNumber():D5}  {GetRate(),6:C}  {GetHours():#0.00}  {GetGross(),9:C}";

    }
}
