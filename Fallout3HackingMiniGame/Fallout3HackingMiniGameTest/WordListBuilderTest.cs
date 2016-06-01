using Fallout3HackingMiniGame.Domain;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Collections.Generic;

namespace Fallout3HackingMiniGameTest
{
    [TestClass]
    public class WordListBuilderTest
    {
        [TestMethod]
        public void WhenGettingWordListForGame_GivenNumberOfWordsAndLengthOfWordAndAWordList_ShouldReturnListOfWordsWithCorrectCountAndLengths()
        {
            var testWordList = new List<string> { "test", "test2", "test3", "rest", "best" };

            var wordListBuilder = new WordListBuilder();

            testWordList = wordListBuilder.GetWordsForGame(3, 4, testWordList);

            Assert.AreEqual(true, testWordList != null);
            Assert.AreEqual(3, testWordList.Count);

            Assert.AreEqual(true, testWordList[0].Length == 4);
            Assert.AreEqual(true, testWordList[1].Length == 4);
            Assert.AreEqual(true, testWordList[2].Length == 4);
        }

        [TestMethod]
        public void WhenGettingWordListForGame_GivenNumberOfWordsLessThanListCountAndLengthOfWordAndAWordList_ShouldReturnListOfWordsWithCorrectCountAndLengths()
        {
            var testWordList = new List<string> { "test", "test2", "test3", "rest", "best" };

            var wordListBuilder = new WordListBuilder();

            testWordList = wordListBuilder.GetWordsForGame(1, 4, testWordList);

            Assert.AreEqual(true, testWordList != null);
            Assert.AreEqual(1, testWordList.Count);

            Assert.AreEqual(true, testWordList[0].Length == 4);
        }
    }
}