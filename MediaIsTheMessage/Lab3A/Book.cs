using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Lab to be done individually
 * In order to be graded, the following Statement of Authorship must be present at the beginning of the script
 * I, Jacob Robbins, student number 000371194, certify that this material is my original work. No other person's work has been used without 
 * due acknowledgment and I have not made my work available to anyone else.
 * March 2023
 */


namespace Lab3A
{
    /// <summary>
    /// Purpose: The Book Class provides parameters for necessary values that specific Book Objects require that the
    /// abstract Media class does not encorporate by default.
    /// </summary>
    public class Book : Media, IEncryptable
    {

        public string Author;
        public string Summary;
        /// <summary>
        /// Book Constructor to implement the parameter values required to create a Book Object.
        /// </summary>
        /// <param name="title">Title for the Book Object</param>
        /// <param name="year">Year for the Book Object</param>
        /// <param name="author">Author for the Book Object</param>
        /// <param name="summary">Summary for the Book Object</param>
        public Book(string title, int year, string author, string summary) : base(title, year)
        {
            Author = author;
            Summary = summary;

        }
        /// <summary>
        /// Overridden ToString Method for Book Object.
        /// </summary>
        /// <returns>Title, Year & Director values of the Book Object.</returns>
        public override string ToString() => $"{Title} {Year} {Author} ";

        /// <summary>
        /// Encrypt() Method not utilized as ROT13 is interchangable with Decrypt Method.
        /// </summary>
        /// <returns>new string array</returns>
        public string Encrypt()
        {
            char[] array = Summary.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                array[i] = (char)number;
            }
            return new string(array);
        }

        /// <summary>
        /// Decrypt() Method - Takes the books summary value and decrypts it using a simple ROT13 method
        /// returning a decrypted summary for use as the Books string when displayed in the search utility
        /// </summary>
        /// <returns>new string array</returns>
        public string Decrypt()
        {
            char[] array = Summary.ToCharArray();
            for (int i = 0; i < array.Length; i++)
            {
                int number = (int)array[i];

                if (number >= 'a' && number <= 'z')
                {
                    if (number > 'm')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                else if (number >= 'A' && number <= 'Z')
                {
                    if (number > 'M')
                    {
                        number -= 13;
                    }
                    else
                    {
                        number += 13;
                    }
                }
                array[i] = (char)number;
            }
            return new string(array);
        }
    }
}

