/*
  Interface: ISearchable.cs
  Author:    Nicholas J. Corkigian
  Date:      October 5, 2017

  Purpose: This interface has one method that classes making use of must
           implement. 

           This code is not to be altered.
*/

/// <summary>
/// The class implementing the Search() method will be assumed to
/// use a string search key as a parameter and return a boolean
/// value to indicate if that key was successfully found.
/// </summary>

interface ISearchable
{
  bool Search(string key);
}

