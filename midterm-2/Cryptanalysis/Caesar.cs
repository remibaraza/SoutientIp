using System;

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
            
        }

        return res;
        
    }
    
    public static int GuessKey(string cypherText)
    {
        throw new NotImplementedException();
    }
}
}