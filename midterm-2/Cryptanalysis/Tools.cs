using System;

namespace Cryptanalysis
{
public static class Tools
{
    public static int Modulus(int a, int b)
    {
        if (b < 0)
            b = -b;
        
        var mod = a % b;
        return mod < 0 ? b + mod : mod;
    }

    public static int LetterIndex(char c)
    {
        
        if (Convert.ToInt32(c) >= 65 && Convert.ToInt32(c) <= 90)
        {
            return Convert.ToInt32(c) - 65;
        }

        if (Convert.ToInt32(c) >= 97 && Convert.ToInt32(c) <= 122)
        {
            return Convert.ToInt32(c) - 97;
        }

        return -1;
    }
    
    public static char RotChar(char c, int n)
    {
        if (90 >= Convert.ToInt32(c) && Convert.ToInt32(c) >= 65 )
        {
            if (90 < Convert.ToInt32(c) + n )
            {
                return Convert.ToChar(Convert.ToInt32(c) + n - 26);
            }

            if (Convert.ToInt32(c) + n  < 65 )
            {
                return Convert.ToChar(Convert.ToInt32(c) + n + 26);
            }
            return Convert.ToChar(Convert.ToInt32(c) + n);
        }

        if (122 >= Convert.ToInt32(c) && Convert.ToInt32(c) >= 97 )
        {
            if (122 < Convert.ToInt32(c) + n )
            {
                return Convert.ToChar(Convert.ToInt32(c) + n - 26);
            }

            if (Convert.ToInt32(c) + n  < 97 )
            {
                return Convert.ToChar(Convert.ToInt32(c) + n + 26);
            }
            return Convert.ToChar(Convert.ToInt32(c) + n);
        }

        return c;
        
    }

    public static int[] Histogram(string str)
    {
       int[] list = new[] { 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0, 0 };
       foreach (char c in str)
       {
           if (LetterIndex(c) != -1)
           {
               list[LetterIndex(c)] += 1;
           }
       }

       return list;
    }
            

        public static string FilterLetters(string str)
    {
        throw new NotImplementedException();
    }

    public static string Extract(string str, int start, int step)
    {
        throw new NotImplementedException();
    }
}
}
