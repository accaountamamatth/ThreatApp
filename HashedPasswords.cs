﻿using System;
using System;
using System.IO;
using System.Text;
using System.Security.Cryptography;

//Main function for hashing passwords

public class HashSalt
{
    public string Hash { get; set; }
    public string Salt { get; set; }
}

public static HashSalt GenerateSaltedHash(int size, string password)
{
    //Getting the salted Hash of the password
    var saltBytes = new byte[size];
    var provider = new RNGCryptoServiceProvider();
    provider.GetNonZeroBytes(saltBytes);
    var salt = Convert.ToBase64String(saltBytes);

    var rfc2898DeriveBytes = new Rfc2898DeriveBytes(password, saltBytes, 10000);
    var hashPassword = Convert.ToBase64String(rfc2898DeriveBytes.GetBytes(256));

    HashSalt hashSalt = new HashSalt { Hash = hashPassword, Salt = salt };
    return hashSalt;

}