using System.Collections.Generic;

namespace WordWrap_Kata
{
    // http://ccd-school.de/coding-dojo/function-katas/textumbruch/
    public static class WordWrap
    {
        public static string[] CreateLines(string[] worte, int maxLineLength)
        {
            var lines = new List<string>();

            var i = 0;
            var line = "";
            while (true)
            {
                if (i == worte.Length)
                {
                    if (line.Length != 0)
                    {
                        lines.Add(line);
                    }
                    break;
                }

                string nextWord = worte[i];

                if (string.IsNullOrWhiteSpace(line) && (nextWord.Length > maxLineLength))
                {
                    string head = nextWord.Substring(0, maxLineLength);
                    string body = nextWord.Substring(maxLineLength);
                    lines.Add(head);
                    worte[i] = body;
                }
                else
                {
                    int futureLength = line.Length + nextWord.Length + (line.Length > 0 ? 1 : 0);
                    if (futureLength <= maxLineLength)
                    {
                        line += (line.Length > 0 ? " " : "") + nextWord;
                        i++;
                    }
                    else
                    {
                        lines.Add(line);
                        line = "";
                    }
                }
            }

            return lines.ToArray();
        }
    }
}