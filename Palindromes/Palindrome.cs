using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Palindromes
{
    public class Palindrome
    {
        public Phrase ReversePhrase(string phraseToCompare)
        {
            var lowerPhrase = phraseToCompare.ToLower();
            var noSpacePhrase = lowerPhrase.Replace(" ", String.Empty);
            var phrase = new Phrase();
            char[] charArray = noSpacePhrase.ToCharArray();
            Array.Reverse(charArray);
            phrase.Characters = new string(charArray);
            return phrase;
        }

        public class Phrase
        {
            public string Characters { get; set; }
        }
    }
}
