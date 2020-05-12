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
        
        int ascii = Convert.ToInt32(c);
        if ((ascii >= 65 && ascii <= 90)) return ascii - 65;
        if (ascii >= 97 && ascii <= 122) return ascii - 97;
        return -1;







    }
    
    public static char RotChar(char c, int n)
    {
        int conv = Convert.ToInt32(c);
        if (conv >= 65 && conv <= 90)  // Majuscule
        {
            if (conv + n >= 90) // Depassement
            {
                int inter = (((conv + n) % 90) + 65);
                return Convert.ToChar(((conv + n) % 90) + 65);

            }
            else // Sans depassement 
            {
                return Convert.ToChar(conv + n);
            }
            
        }

        if (conv >= 97 && conv <= 122)
        {
            if (conv + n >= 122) // Depassement
            {
                int inter = (((conv + n) % 122) + 97);
                return Convert.ToChar(((conv + n) % 122) + 97);

            }
            else // Sans depassement 
            {
                return Convert.ToChar(conv + n);
            }
        
            
        }

        return c;


    }

    public static int[] Histogram(string str)
    {
        
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
