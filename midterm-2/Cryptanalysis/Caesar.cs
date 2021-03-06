using System;
using System.Xml;

namespace Cryptanalysis
{
public class Caesar
{
    private int key;
    public Caesar(int key)
    {
        this.key = key;
    }

    public string Encrypt(string msg)
    {
        string res = "";
        foreach (var lettre in msg)
        {
            if (Tools.LetterIndex(lettre) != -1)
            {
                res += Tools.RotChar(lettre, key);

            }
            else
            {
                res += lettre;
            }
            
        }

        return res;
    }

    public string Decrypt(string cypherText)
    {
        string res = "";
        foreach (var lettre in cypherText)
        {
            if (Tools.LetterIndex(lettre) != -1)
            {
                res += Tools.RotChar(lettre, -key);

            }
            else
            {
                res += lettre;
            }
            
        }

        return res;
        
    }
    
    public static int GuessKey(string cypherText)
    {
        
        
        int[] res = Tools.Histogram(cypherText);
        int pmax = 0;
        int i = 0;
        foreach (var occ in res)
        {
            if (occ > pmax)
            {
                pmax = i;
            }

            else
            {
                i++;
                
            }

            






        }

        return pmax - 4;



    }
}
}