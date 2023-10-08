namespace NewsVowel.WordSearch
{
    /// <summary>
    /// Поисковик слов в тексте
    /// </summary>
    public class WordSearchManager
    {
        /// <summary>
        /// Возвращает слово с максимальны вхождением символов
        /// </summary>
        /// <param name="source">текст</param>
        /// <param name="letters">вхождение символов</param>
        /// <returns></returns>
        public string GetWord(string source, ICollectionLetters letters)
        {
            if (string.IsNullOrWhiteSpace(source))
                return string.Empty;

            var word = new Word();
            int countLetters = 0;
            int startIndex = 0;
            for (int i = 0; i < source.Length; i++)
            {
                var letter = source[i];

                if (char.IsLetter(letter) && letters.ContainsLetters(letter))
                {
                    countLetters++;
                }
                else if (char.IsSeparator(letter) || char.IsWhiteSpace(letter) || char.IsPunctuation(letter))
                {
                    if (countLetters > word.CountLetters)
                    {
                        word.StartIndex = startIndex;
                        word.CountLetters = countLetters;
                        word.FinishIndex = i;
                    }
                    startIndex = i + 1;
                    countLetters = 0;
                }
            }

            if (word.Length <= 0 && countLetters <= 0) return string.Empty;
            
            if(word.Length <= 0 && countLetters > 0)
            {
                word.StartIndex = startIndex;
                word.CountLetters = countLetters;
                word.FinishIndex = source.Length;
            }

            return source.Substring(word.StartIndex, word.Length);
        }

        private struct Word
        {
            public int StartIndex { get; set; }
            public int FinishIndex { get; set; }
            public int CountLetters { get; set; }
            public int Length => FinishIndex - StartIndex;
        }
    }
}
