using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace transcription
{
    public class Complement
    {
        public static string OfDna(string dna)
        {
            string rna = "";
            char[] stringToCharArray = new char[dna.Length];
            stringToCharArray = dna.ToCharArray();

            for (int i = 0; i < dna.Length; i++)
            {
                switch (stringToCharArray[i])
                {
                    case 'g':
                    case 'G':
                        rna += "C";
                        break;
                    case 'c':
                    case 'C':
                        rna += "G";
                        break;
                    case 't':
                    case 'T':
                        rna += "A";
                        break;
                    case 'a':
                    case 'A':
                        rna += "U";
                        break;
                }
            }
            return rna;
        }
    }
}