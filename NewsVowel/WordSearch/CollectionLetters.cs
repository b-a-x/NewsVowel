using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NewsVowel.WordSearch
{
    public interface ICollectionLetters
    {
        bool ContainsLetters(char item);
    }

    public class CollectionLetters : HashSet<char>, ICollectionLetters
    {
        public CollectionLetters(int count) : base(count) { }
        public bool ContainsLetters(char item) => Contains(item);
    }
}
