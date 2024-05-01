using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;

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
    /// Purpose: The Main Program for this Application offers A highly modular main instance and implements the logic for the creation
    /// of class objects in the ReadData Method, storing the objects in lists. 
    /// 
    /// The Main Program also implements a Search utility so the User may search for Media objects by their title
    /// </summary>
    internal class Program
    {
        public static bool isOpen = true;
        public static int count;

        public static List<string> fileData = new List<String>();
        public static List<Book> sortedDataBook = new List<Book>();
        public static List<Song> sortedDataSong = new List<Song>();
        public static List<Movie> sortedDataMovie = new List<Movie>();
        public static List<Media> sortedDataAll = new List<Media>();

        public static List<string> summary = new List<string>();
        public static List<string> summaryM = new List<string>();

        /// <summary>
        /// ReadData() Method - Reads the data from the selected input file, parses text into strings by seperation delimiters
        /// Adding the seperated strings to a temporary object then adding the objects to their respected type Lists
        /// </summary>
        /// <param name="count"></param>
        public static void ReadData(out int count)
        {
            int x = 0;
            int y = 0;
            count = 0;
            try
            {
                foreach (string line in System.IO.File.ReadAllLines("Data.txt"))
                {
                        fileData.Add(line);
                }
                {
                    int lineNumber = 0;
                    while (lineNumber < fileData.Count)
                    {
                        string[] fields = fileData[lineNumber].Split('|');
                        lineNumber++;
                            switch (fields[0])
                            {
                                case "BOOK":
                                    summary.Add(fileData[lineNumber++]);
                                    Book temp = new Book(fields[1], int.Parse(fields[2]), fields[3], summary[x]);
                                    sortedDataBook.Add(temp);
                                    x++;
                                    break;
                                        case "MOVIE":
                                                summaryM.Add(fileData[lineNumber++]);
                                            Movie newTemp = new Movie(fields[1], int.Parse(fields[2]), fields[3], summaryM[y]);
                                            sortedDataMovie.Add(newTemp);
                                            y++;
                                            break;
                                                case "SONG":
                                                Song tempTwo = new Song(fields[1], int.Parse(fields[2]), fields[3], fields[4]);
                                                    sortedDataSong.Add(tempTwo);
                                                    break;
                            }
                        }
                }
            }
            catch (Exception ex)
            {
                isOpen = false;
                Console.Clear();
                Console.WriteLine(ex.Message);
                Console.WriteLine("Input Data in Incorrect Format, Please try Again");
                Console.WriteLine("Please Press Enter to Continue");
                Console.ReadLine();
            }
        }

        /// <summary>
        /// WriteDataBook() Method - Writes the Data from the Books List to the console 
        /// </summary>
        public static void WriteDataBook()
        {
            for (int i = 0; i < sortedDataBook.Count; i++)
            {
                Console.WriteLine("Book : " + sortedDataBook[i].ToString());
            }
        }
        /// <summary>
        /// WriteDataMovie() Method - Writes the Data from the Movie List to the console 
        /// </summary>
        public static void WriteDataMovie()
        {
            for (int i = 0; i < sortedDataMovie.Count; i++)
            {
                Console.WriteLine("Movie : " + sortedDataMovie[i].ToString());
            }
        }
        /// <summary>
        /// WriteDataSong() Method - Writes the Data from the Song List to the console 
        /// </summary>
        public static void WriteDataSong()
        {
            for (int i = 0; i < sortedDataSong.Count; i++)
            {
                Console.WriteLine("Song : " + sortedDataSong[i].ToString());
            }
        }
        /// <summary>
        /// WriteAllData() Method - adds all of the Data from each List to a seperate list for Search utility
        /// </summary>
        public static void WriteAllData()
        {
            foreach (Book book in sortedDataBook)
            {
                Console.WriteLine("Book: " + book.ToString());
                sortedDataAll.Add(book);
            }
            foreach (Movie movie in sortedDataMovie)
            {
                Console.WriteLine("Movie : " + movie.ToString());
                sortedDataAll.Add(movie);
            }
            foreach (Song song in sortedDataSong)
            {
                Console.WriteLine("Song : " + song.ToString());
                sortedDataAll.Add(song);
            }
        }
        /// <summary>
        /// AllData() Method - re-writes all the data from WriteAllData for Search utility 
        /// </summary>
        public static void AllData()
        {
            sortedDataAll.Clear();
            foreach (Book book in sortedDataBook)
            {
                sortedDataAll.Add(book);
            }
            foreach (Movie movie in sortedDataMovie)
            {
                sortedDataAll.Add(movie);
            }
            foreach (Song song in sortedDataSong)
            {
                sortedDataAll.Add(song);
            }
        }
        /// <summary>
        /// Menu() Method - Presents a neat menu for the user to choose their options and acts as a UI for the application
        /// </summary>
        /// <param name="isOpen">A boolean value to decide whether the menu is kept open or otherwise</param>
        public static void Menu(bool isOpen)
        {
            
            while (isOpen)
            {
                Console.WriteLine("Please Enter a Selection from 1 - 6");
                Console.WriteLine("1: List All Books");
                Console.WriteLine("2: List All Movies");
                Console.WriteLine("3: List All Songs");
                Console.WriteLine("4: List All Media");
                Console.WriteLine("5: Search Query");
                Console.WriteLine("6: Exit Program");


                try
                {
                    int x = int.Parse(Console.ReadLine());
                    Console.Clear();

                    switch (x)
                    {
                        case 1:
                            Console.Clear();
                            isOpen = false;
                            WriteDataBook();
                            Console.WriteLine("Please Press Enter to Continue");
                            Console.ReadLine();
                            Console.Clear();
                            isOpen = true;
                            break;
                        case 2:
                            Console.Clear();
                            isOpen = false;
                            WriteDataMovie();
                            Console.WriteLine("Please Press Enter to Continue");
                            Console.ReadLine();
                            Console.Clear();
                            isOpen = true;
                            break;
                        case 3:
                            Console.Clear();
                            isOpen = false;
                            WriteDataSong();
                            Console.WriteLine("Please Press Enter to Continue");
                            Console.ReadLine();
                            Console.Clear();
                            isOpen = true;
                            break;
                        case 4:
                            Console.Clear();
                            isOpen = false;
                            WriteAllData();
                            Console.WriteLine("Please Press Enter to Continue");
                            Console.ReadLine();
                            Console.Clear();
                            isOpen = true;
                            break;
                        case 5:
                            Console.Clear();
                            isOpen = false;
                            Console.WriteLine("Please Enter a Search String");
                            SearchMe();
                            Console.WriteLine("Please Press Enter to Continue");
                            Console.ReadLine();
                            Console.Clear();
                            isOpen = true;
                            break;
                        case 6:
                            Environment.Exit(0);
                            break;
                        default:
                            Console.Clear();
                            Console.WriteLine("Please Enter a Selection from the List!");
                            isOpen = false;
                            Console.WriteLine("Please Press Enter to Continue");
                            Console.ReadLine();
                            Console.Clear();
                            isOpen = true;
                            break;
                    }
                }
                catch (Exception e)
                {
                    Console.Clear();
                    isOpen = false;
                    Console.WriteLine("Please enter a Selection from the List!");
                    Console.WriteLine("Please Press Enter to Continue");
                    Console.ReadLine();
                    Console.Clear();
                    isOpen = true;
                }
            }
        }
        /// <summary>
        /// The main instance of the Program which is highly-modular
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
            ReadData(out count);

            Menu(isOpen);
        }

        /// <summary>
        /// SearchMe() Method allows the user to search Media objects by their Title's
        /// </summary>
        public static void SearchMe()
        {
            
            string x = Console.ReadLine();
            List<Book> newBook = new List<Book>();
            List<Movie> newMovie = new List<Movie>();
            List<Song> newSongs = new List<Song>();
            bool y;

            for (int i = 0; i < sortedDataBook.Count; i++)
            {
                y = sortedDataBook[i].Search(x);
                if (y == true)
                {
                    newBook.Add(sortedDataBook[i]);
                }
            }
            for (int i = 0; i < sortedDataMovie.Count; i++)
            {
                y = sortedDataMovie[i].Search(x);
                if (y == true)
                {
                    newMovie.Add(sortedDataMovie[i]);
                }
            }
            for (int i = 0; i < sortedDataSong.Count; i++)
            {
                y = sortedDataSong[i].Search(x);
                if (y == true)
                {
                    newSongs.Add(sortedDataSong[i]);
                }
            }
            foreach (Book b in newBook)
            {
                string bookDecrypt = b.Decrypt();
                Console.WriteLine(b.ToString() + "-" + bookDecrypt);
            }
            foreach (Movie m in newMovie)
            {
                string movieDecrypt = m.Decrypt();
                Console.WriteLine(m.ToString() + "-" + movieDecrypt);
            }
            foreach (Song s in newSongs)
            {
                Console.WriteLine("Song : " + s);
            }
        }
    }
}



