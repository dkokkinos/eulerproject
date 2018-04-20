using Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Problems_0_50.P22_NamesScores
{
    public class NamesScoresSolution : ISolvable
    {
        public void Solve()
        {
            string[] names = this.GetNames();
            Array.Sort(names, StringComparer.InvariantCulture);

            long total_sum = 0;
            foreach(var name in names)
            {
                int wordScore = GetWordScore(name);
                int index = Array.IndexOf(names, name) + 1;

                total_sum += wordScore * index;
            }

            Console.WriteLine("total of all the name scores in the file is " + total_sum);
        }

        int GetWordScore(string word)
        {
            int score = 0;
            foreach(var c in word)
            {
                score += this.GetScoreOfLetter(c);
            }
            return score;
        }

        int GetScoreOfLetter(char letter)
        {
            char upper = char.ToUpper(letter);
            int _base = (int)'A';
            int _curr = (int)upper - _base;
            return _curr+1;
        }

        private string[] GetNames()
        {
            var res = System.IO.File.ReadAllText("p022_names.txt").Replace("\"", string.Empty);
            return res.Split(',');
        }
    }
}
