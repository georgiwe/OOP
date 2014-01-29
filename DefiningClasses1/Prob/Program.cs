using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

class Program
{
    static void Main()
    {
        if (File.Exists("inp.txt")) Console.SetIn(new StreamReader("inp.txt"));

        //Console.OutputEncoding = Encoding.UTF8;
        //Console.InputEncoding = Encoding.UTF8;

        string txt = Console.ReadLine();

        int n = int.Parse(Console.ReadLine());

        var answers = new List<string>();

        for (int i = 0; i < n; i++)
        {
            string srch = Console.ReadLine();

            if (Regex.IsMatch(srch, @"\b[(а-я)(a-z)]+\b"))
            {
                answers.Add("Place");
                continue;
            }

            MatchCollection sentences = Regex.Matches(txt, @"[^\.\?\!(\.\.\.)(\.\.)]*\b(" + srch + @")\b[^\.\?\!(\.\.\.)(\.\.)]*", RegexOptions.IgnoreCase);

            var wordsBefore = new List<string>();

            foreach (Match match in sentences)
            {
                MatchCollection inSent = Regex.Matches(match.Value, srch, RegexOptions.IgnoreCase);

                foreach (Match occ in inSent)
                {
                    string textBefore = match.Value.Substring(0, occ.Index - 1).Trim();

                    string wordBefore = Regex.Match(textBefore, @"\b\w+$").Value;

                    wordsBefore.Add(wordBefore);
                }
            }

            int person = 0;
            int place = 0;

            foreach (Match match in sentences)
            {
                var personWords = Regex.Matches(match.Value.Trim(),
@"\bс\b|\bсъс\b|\bот\b|\bвместо\b|\bд-р\.?\b|\bдр\.?\b|\bинж\.?\b|\bпреди\b|\bслед\b|\b\w*цар\w*\b|\b\w*крал\w*\b|\b\w*хан\w*\b|\b\w*кан\w*\b|\b\w*минист\w*\b|\b\w*президент\w*\b|\b.*г-н.*\b|\b.*г-жа.*\b|\bкойто\b|\bкогото\b|\bтой\b|\bкой\b|\bкого\b|\bкак\b|господин|госпожа|госпожица|\b\wов\b|\b\w+ова\b", RegexOptions.IgnoreCase);

                person += personWords.Count;

                var plceWords = Regex.Matches(match.Value.Trim(),
@"\bпри\b|\bна\b|близо|\bдо\b|\bв\b|\bвъв\b|извън|\bпред\b|\bнад\b|\bпод\b|\bулица\b|ул.|град|село|връх|север|юг|юго|южен|южна|запад|изто", RegexOptions.IgnoreCase);

                place += plceWords.Count;
            }

            if (person > place && person > 0) answers.Add("Person");
            else if (person < place && place > 0) answers.Add("Place");
            else answers.Add("Unknown");
        }

        Console.WriteLine(String.Join("\n", answers));
    }
}