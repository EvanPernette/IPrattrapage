using System;

namespace Cryptanalysis
{
public class Caesar
{
    private int Key;
    public Caesar(int key)
    {
        this.Key = key;
    }

    public string Encrypt(string msg)
    {
        throw new NotImplementedException();
    }

    public string Decrypt(string cypherText)
    {
        throw new NotImplementedException();
    }
    
    public static int GuessKey(string cypherText)
    {
        throw new NotImplementedException();
    }
}
}