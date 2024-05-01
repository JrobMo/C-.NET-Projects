/*
  Interface: IEncryptable.cs
  Author:    Nicholas J. Corkigian
  Date:      October 05, 2017

  Purpose: This interface has two methods that classes making use of must
           implement. 

           This code is not to be altered.
*/

/// <summary>
/// The class implementing the Encrypt() method will use some sort
/// of encryption algorithm to return some encrypted data.
///
///  The class implementing the Decrypt() method will use (presumably)
///  the same encryption algorithm to return a decrypted string.
/// </summary>

public interface IEncryptable
{
  string Encrypt();
  string Decrypt();
}