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
    /// Purpose: The Movie Class provides parameters for necessary values that specific Movie Objects require that the
    /// abstract Media class does not encorporate by default
    /// </summary>
    public class Movie : Media, IEncryptable
    {
        public string Director;
        public string Summary;

        /// <summary>
        /// Movie Constructor to implement the parameter values required to create a Movie Object 
        /// </summary>
        /// <param name="title"></param>
        /// <param name="year"></param>
        /// <param name="director"></param>
        /// <param name="summary"></param>
        public Movie(string title, int year, string director, string summary) : base(title, year)
        {
            Director = director;
            Summary = summary;
        }

        /// <summary>
        /// Decrypt() Method - same as used in the Book class to decrypt the Movies summary and return a decrypted summary string
        /// for use in the users search utility.
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
        /// Overridden ToString Method for Book Object.
        /// </summary>
        /// <returns>Title, Year & Director values of the Movie Object.</returns>
        public override string ToString() => $"{Title} {Year} {Director} ";

    }
}