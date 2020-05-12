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
        string res = "";
        foreach (char c in msg)
        {
            res += Tools.RotChar(c, Key);
        }

        return res;
    }

    public string Decrypt(string cypherText)
    {
        string res = "";
        foreach (char c in cypherText)
        {
            res += Tools.RotChar(c, -Key);
        }

        return res;
    }
    
    public static int GuessKey(string cypherText)
    {
        int[] list = Tools.Histogram(cypherText);
        int max = 0;
        int count = 0;
        int occ = 0;
        foreach (int x in list)
        {
            
            if (x > max)
            {
                occ = count;
                max = x;
            }
            count += 1;
        }

        return occ - 5;



    }
}
}