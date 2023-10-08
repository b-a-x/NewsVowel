using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsVowel.WordSearch
{
    /// <summary>
    /// Гласные буквы русского алфавита
    /// </summary>
    public class CyrillicVowelLetters : CollectionLetters
    {
        public CyrillicVowelLetters() : base(20)
        {
            Add('а');
            Add('А');
            Add('е');
            Add('Е');
            Add('ё');
            Add('Ё');
            Add('и');
            Add('И');
            Add('о');
            Add('О');
            Add('у');
            Add('У');
            Add('ы');
            Add('Ы');
            Add('э');
            Add('Э');
            Add('ю');
            Add('Ю');
            Add('я');
            Add('Я');
        }
    }
}
