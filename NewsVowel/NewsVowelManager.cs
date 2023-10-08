using NewsAPI.Constants;
using NewsAPI.Models;
using NewsAPI;
using NewsVowel.Models;
using NewsVowel.WordSearch;

namespace NewsVowel
{
    public class NewsVowelManager
    {
        private readonly NewsApiClient _client;
        private readonly InputUser _input;
        private readonly WordSearchManager _wordSearch;
        public NewsVowelManager(InputUser input, WordSearchManager wordSearch) 
        {
            _input = input;
            //TODO Dispose
            _client = new NewsApiClient(input.KeyApi);
            _wordSearch = wordSearch;
        }

        public void Run()
        {   
            var articlesResponse = _client.GetEverything(new EverythingRequest
            {
                Q = _input.Topic,
                SortBy = SortBys.PublishedAt,
            });

            if (articlesResponse.Status == Statuses.Ok)
            {
                var letters = CyrillicAndEnglishVowelLetters.Create();
                foreach (var article in articlesResponse.Articles)
                {
                    var word = _wordSearch.GetWord(article.Description, letters);
                    Print(article.Description, word);   
                }
            }
        }

        private void Print(string description, string word)
        {
            Console.WriteLine("------------------");
            Console.WriteLine("Фрагмент новости:");
            Console.WriteLine(description);
            Console.Write("Cлово с наибольшим количеством гласных: ");
            Console.Write(word);
            Console.WriteLine(" ");
        }

        public static NewsVowelManager Make(InputUser input) => new NewsVowelManager(input, new WordSearchManager());
    }
}
