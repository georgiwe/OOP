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
        //if (File.Exists("inp.txt")) Console.SetIn(new StreamReader("inp.txt"));

        string text = Console.ReadLine();

        int n = int.Parse(Console.ReadLine());

        var answers = new List<String>();

        for (int i = 0; i < n; i++)
        {
            string searchFor = Console.ReadLine();

            var matches = Regex.Matches(searchFor, @"\b[А-Я][а-я]*\.*\b");

            if (matches.Count >= 3)
            {
                answers.Add("Person");
                continue;
            }

            matches = Regex.Matches(text, @"(\b\w+\b)*\b(" + searchFor + @")\b(\b\w+\b)*", RegexOptions.IgnoreCase);

            var wordsBefore = new List<string>();

            foreach (Match match in matches)
            {
                string left = text.Substring(match.Index - 25, 25).Trim();

                string lastWord = Regex.Match(left, @"\b\w+$").Value;

                wordsBefore.Add(lastWord);
            }

            int person = 0;
            int place = 0;
            int dunno = 0;

            for (int j = 0; j < wordsBefore.Count; j++)
            {
                bool mtch = false;

                if (Regex.IsMatch(wordsBefore[j], @"при|на|близо|до|в|във|извън|пред|над|под|улица|ул.|град|село|връх", RegexOptions.IgnoreCase))
                {
                    place++;
                    mtch = true;
                }

                if (Regex.IsMatch(wordsBefore[j], @"с|със|от|вместо|д-р|др\.?|инж\.?|преди|след|\w*цар\w*|\w*крал\w*|\w*хан\w*|\w*кан\w*|\w*минист\w*|\w*президент\w*|.*г-н.*|.*г-жа.*", RegexOptions.IgnoreCase))
                {
                    person++;
                    mtch = true;
                }

                if (!mtch) dunno++;
            }

            if (person >= place && person >= dunno)
            {
                answers.Add("Person");
            }
            else if (place >= person && place >= dunno)
            {
                answers.Add("Place");
            }
            else
            {
                answers.Add("Unknown");
            }
        }

        Console.WriteLine(String.Join("\n", answers)); ;
    }
}