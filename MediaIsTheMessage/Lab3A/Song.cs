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
    /// Purpose: The Song Class provides parameters for necessary values that specific Song Objects require that the
    /// abstract Media class does not encorporate by default
    /// </summary>
    internal class Song : Media
    {

        public string Artist;
        public string Album;
        /// <summary>
        /// Song Constructor to implement the parameter values required to create a Song Object.
        /// </summary>
        /// <param name="title"></param>
        /// <param name="year"></param>
        /// <param name="album"></param>
        /// <param name="artist"></param>
        public Song(string title, int year, string album, string artist) : base(title, year)
        {
            Album = album;
            Artist = artist;
        }

        /// <summary>
        /// Overridden ToString Method for Song Object
        /// </summary>
        /// <returns>Title, Year Album and Artist values of the Song Object</returns>
        public override string ToString() => $"{Title} {Year} {Album} {Artist} ";
    }
}
