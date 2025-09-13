using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_7_3_
{
    class ACipher : ICipher
    {
        public string text;
        public ACipher(string text)
        {
            this.text = text;
        }
        public ACipher()
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
            for (int i = 0; i < textSymbols.Length; i++)
            {
                textSymbols[i] = char.ToUpper(textSymbols[i]);
                char symbol = textSymbols[i];
                int index = alphabet.IndexOf(symbol);
                if (index != -1)
                {
                    char encodedSymbol = alphabet[(index + 1) % alphabet.Length];
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
                int index = reverseAlphabet.IndexOf(symbol);
                if (index != -1)
                {
                    char decodedSymbol = alphabet[index];
                    decodedSymbols[i] = decodedSymbol;
                }
                else
                {
                    decodedSymbols[i] = symbol;
                }
            }
            string decodedText = new string(decodedSymbols);
            return decodedText.ToString();
        } 
    }
}
