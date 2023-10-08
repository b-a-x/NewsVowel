using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsVowel.WordSearch
{
    public class CyrillicAndEnglishVowelLetters : ICollectionLetters
    {
        private readonly ICollectionLetters _firstLetters;
        private readonly ICollectionLetters _secondLetters;
        public CyrillicAndEnglishVowelLetters(ICollectionLetters first, ICollectionLetters second)
        {
            _firstLetters = first;
            _secondLetters = second;
        }

        public bool ContainsLetters(char item) => _firstLetters.ContainsLetters(item) || _secondLetters.ContainsLetters(item);

        public static CyrillicAndEnglishVowelLetters Create() => new CyrillicAndEnglishVowelLetters(new CyrillicVowelLetters(), new EnglishVowelLetters());
    }
}
