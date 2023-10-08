using NewsVowel.WordSearch;

namespace NewsVowel.Test.WordSearch
{
    public class WordSearch
    {
        [Theory]
        [InlineData("", "")]
        [InlineData(" ", "")]
        [InlineData("������", "������")]
        [InlineData("!������", "������")]
        [InlineData(" ������", "������")]
        [InlineData("������ ", "������")]
        [InlineData("!������!", "������")]
        [InlineData("������  ���!", "������")]
        [InlineData("��", "")]
        public void WordSearch_GetWord(string source, string expected)
        {
            var search = new WordSearchManager();
            var word = search.GetWord(source, CyrillicAndEnglishVowelLetters.Create());

            Assert.Equal(expected, word);
        }
    }
}