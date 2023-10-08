using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsVowel.WordSearch
{
    /// <summary>
    /// Гласные буквы английского алфавита
    /// </summary>
    public class EnglishVowelLetters : CollectionLetters
    {
        public EnglishVowelLetters() : base(12)
        {
            Add('a');
            Add('A');
            Add('e');
            Add('E');
            Add('i');
            Add('I');
            Add('o');
            Add('O');
            Add('u');
            Add('U');
            Add('y');
            Add('Y');
        }
    }
}
