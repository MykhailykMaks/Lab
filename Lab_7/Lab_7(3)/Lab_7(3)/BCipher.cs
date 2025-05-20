using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_3_
{
    class BCipher
    {
        public string text;
        public BCipher(string text)
        {
            this.text = text;
        }
        public BCipher()
        {
            this.text = "";
        }
        public string Text
        {
            get { return text; }
            set { text = value; }
        }
        public string encode(string text)
        {
            char[] textSymbols = text.ToCharArray();
            char[] encodedSymbols = new char[textSymbols.Length];
            string alphabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";
            string reverseAlphabet = new string(alphabet.Reverse().ToArray());
            for(int i = 0; i < textSymbols.Length; i++)
            {
                textSymbols[i] = char.ToUpper(textSymbols[i]);
                char symbol = textSymbols[i];
                int index = alphabet.IndexOf(symbol);
                if (index != -1)
                {
                    char encodedSymbol = reverseAlphabet[index];
                    encodedSymbols[i] = encodedSymbol;
                }
                else
                {
                    encodedSymbols[i] = symbol;
                }
            }
            string encodedText = new string(encodedSymbols);    
            return encodedText;
        }
        public string decode(string text)
        {
            char[] textSymbols = text.ToCharArray();
            char[] decodedSymbols = new char[textSymbols.Length];
            string alphabet = "АБВГҐДЕЄЖЗИІЇЙКЛМНОПРСТУФХЦЧШЩЬЮЯ";
            string reverseAlphabet = new string(alphabet.Reverse().ToArray());
            for (int i = 0; i < textSymbols.Length; i++)
            {
                textSymbols[i] = char.ToUpper(textSymbols[i]);
                char symbol = textSymbols[i];
                int index = alphabet.IndexOf(symbol);
                if (index != -1)
                {
                    char encodedSymbol = reverseAlphabet[index];
                    decodedSymbols[i] = encodedSymbol;
                }
                else
                {
                    decodedSymbols[i] = symbol;
                }
            }
            string decodedText = new string(decodedSymbols);
            return decodedText;
        }
    }
}
