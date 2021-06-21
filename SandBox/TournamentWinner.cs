using System.Collections.Generic;
using System.Linq;

namespace AlgoExpert
{
    public class TournamentWinner
    {
        // O(n) Time | O(k) Space - where n is number of competitions and k is number of teams
        public string Solution1(List<List<string>> competitions, List<int> results)
        {
            var scores = new Dictionary<string, int>();
            for (int i = 0; i < competitions.Count; i++)
            {
                var competingTeams = competitions.ElementAt(i);
                var result = results.ElementAt(i);
                (string TeamName, int Points) homeTeam = (competingTeams.First(), result == 1? 3 : 0);
                if (!scores.ContainsKey(homeTeam.TeamName))
                    scores.Add(homeTeam.TeamName, homeTeam.Points);
                else 
                    scores[homeTeam.TeamName] += homeTeam.Points;

                (string TeamName, int Points) guestTeam = (competingTeams.Last(), result == 0? 3 : 0);
                if (!scores.ContainsKey(guestTeam.TeamName))
                    scores.Add(guestTeam.TeamName, guestTeam.Points);
                else 
                    scores[guestTeam.TeamName] += guestTeam.Points;
            }

            var maxScore = scores.Max(x => x.Value);

            return scores.First(x => x.Value == maxScore).Key;
        }
    }
}
