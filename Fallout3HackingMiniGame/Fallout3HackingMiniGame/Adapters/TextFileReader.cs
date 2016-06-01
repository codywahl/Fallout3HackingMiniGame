using Fallout3HackingMiniGame.Properties;
using System.Collections.Generic;
using System.IO;
using System.Linq;

namespace Fallout3HackingMiniGame.Adapters
{
    public static class TextFileReader
    {
        public static IEnumerable<string> GetWordsFromTextFile()
        {
            return File.ReadLines(Resources.enable1).ToList();
        }
    }
}