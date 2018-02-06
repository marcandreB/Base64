using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Base64
{
    static public class Base64
    {
        static private char[] encodedValues = new char[64];

        //Initialize our encoding table
        static Base64()
        { 
            for (int i = 0; i < 26; i++) encodedValues[i] = (char)(i + 65); // UpperCases letters
            for (int i = 0; i < 26; i++) encodedValues[i + 26] = (char)(i + 97); // LowerCases letters
            for (int i = 0; i < 10; i++) encodedValues[i + 52] = (char)(i + 48); // 0 - 9 integers
            encodedValues[62] = '/';
            encodedValues[63] = '+';
        }

        static public String Encode(byte[] source)
        {
            string resultString = "";
            int temp_EncodedNumber = 0;
            for (int i = 0; i < source.Length; i+= 6)  // For each 6 bytes block
            {
                for (int j = 0; j < 6; j++) // For each byte in the block
                {
                    if (source[i - j + 5] == 0) continue;
                    temp_EncodedNumber += (int)(Math.Pow(2, j));
                }
                resultString += encodedValues[temp_EncodedNumber]; // temp_EncodedNumber now contains our 0-63 integer
                temp_EncodedNumber = 0;
            }
            return resultString;
        }
    }

}
