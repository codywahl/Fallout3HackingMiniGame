using System;
using System.Collections.Generic;
using System.Linq;

namespace Fallout3HackingMiniGame.Domain
{
    public class WordListBuilder
    {

        public List<string> GetWordsForGame(int numberOfWords, int lengthOfWords, List<string> wordList)
        {
            wordList = GetWordListOfCorrectLength(wordList, lengthOfWords);
            wordList = SelectCertianNumberOfRandomWordsFromList(wordList, numberOfWords);

            return wordList;
        }

        private List<string> GetWordListOfCorrectLength(List<string> wordList, int lengthOfWords)
        {
            return wordList.Where(word => word.Length == lengthOfWords).ToList();
        }

        private List<string> SelectCertianNumberOfRandomWordsFromList(List<string> wordList, int numberOfWords)
        {
            var wordListCount = wordList.Count(); // Stored to prevent multiple iterations over the wordlist.

            if (numberOfWords >= wordListCount)
            {
                return wordList;
            }

            var arrayPositions = new List<int>();
            var newWordList = new List<string>();
            var random = new Random();

            while (arrayPositions.Count < numberOfWords)
            {
                var randomPosition = random.Next(0, wordListCount);

                if (!arrayPositions.Contains(randomPosition))
                {
                    arrayPositions.Add(randomPosition);
                }
            }

            foreach (var position in arrayPositions)
            {
                newWordList.Add(wordList.ElementAt(position));
            }

            return newWordList;
        }
    }
}