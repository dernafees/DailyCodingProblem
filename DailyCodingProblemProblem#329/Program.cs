using System;
using System.Collections.Generic;

namespace DailyCodingProblemProblem_329_Hard_
{
    class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> guy_preferences = new Dictionary<string, List<string>>()
        {
            {"andrew" , new List<string>(){"caroline","abigail","betty"}},
            {"bill" , new List<string>(){"caroline","betty","abigail"}},
            {"chester" , new List<string>(){"betty","caroline","abigail"}}
        };
            Dictionary<string, List<string>> gal_preferences = new Dictionary<string, List<string>>()
        {
            {"abigail" , new List<string>(){"andrew", "bill", "chester"}},
            {"betty" , new List<string>(){"bill", "andrew", "chester"}},
            {"caroline" , new List<string>(){"bill", "chester", "andrew"}}
        };
            var couples = GetCouples(guy_preferences, gal_preferences, 3);
            foreach (var couple in couples)
            {
                Console.WriteLine($"couple: {couple.Key} + {couple.Value}");
            }
        }

        public static Dictionary<string, string> GetCouples(
             Dictionary<string, List<string>> guys_preferences,
              Dictionary<string, List<string>> gal_preferences, int size)
        {

            Dictionary<string, string> pairup = new Dictionary<string, string>();
            Dictionary<string, int> pairedWithScore = new Dictionary<string, int>();
            Queue<string> guyQueue = new Queue<string>(guys_preferences.Keys);

            while (guyQueue.Count > 0)
            {
                var guy = guyQueue.Dequeue();
                for (var x = 0; x < size; x++)
                {
                    if (!pairedWithScore.ContainsKey(guys_preferences[guy][x]))
                    {
                        pairup.Add(guys_preferences[guy][x], guy);
                        pairedWithScore.Add(guys_preferences[guy][x], gal_preferences[guys_preferences[guy][x]].IndexOf(guy));
                        break;
                    }

                    if (pairedWithScore[guys_preferences[guy][x]] > gal_preferences[guys_preferences[guy][x]].IndexOf(guy))
                    {
                        guyQueue.Enqueue(pairup[guys_preferences[guy][x]]);
                        pairup.Remove(guys_preferences[guy][x]);
                        pairup.Add(guys_preferences[guy][x], guy);
                        pairedWithScore[guys_preferences[guy][x]] = gal_preferences[guys_preferences[guy][x]].IndexOf(guy);
                        break;
                    }
                }
            }
            return pairup;
        }
    }
}
