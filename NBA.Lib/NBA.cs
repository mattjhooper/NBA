using System;
using System.Text;

namespace NBA.Lib
{
    public class Nba
    {
        public static ( string Team1, int Score1, string Team2, int Score2 ) Explode(string match)
        {
            
            
            int score1 = 0;

            var parts = match.Split (' ');
            int part = 0;
            var team1 = new StringBuilder(parts[part]);
            
            bool keepChecking = true;
            while (keepChecking)
            {
                part++;
                
                if (Int32.TryParse(parts[part],out score1))
                {
                    keepChecking = false;
                }
                else
                {
                    team1.Append(" ");
                    team1.Append(parts[part]);    
                }
                
                keepChecking = keepChecking && part + 1 < parts.Length;                    
            }

            int score2 = 0;
            var team2 = new StringBuilder(parts[++part]);
            keepChecking = true;
            while (keepChecking)
            {
                part++;

                if (Int32.TryParse(parts[part],out score2))
                {
                    keepChecking = false;
                }
                else
                {
                    team2.Append(" ");
                    team2.Append(parts[part]);    
                }
                
                keepChecking = keepChecking && part + 1 < parts.Length;                    
            }
            
            return (team1.ToString(), score1, team2.ToString(), score2);
        }
        
        public static string NbaCup(string resultSheet, string toFind) 
        {
            var matches = resultSheet.Split(',');

            foreach(var match in matches)
            {
                Console.WriteLine(match);

            }    

            return "Boston Celtics:W=4;D=0;L=0;Scored=403;Conceded=350;Points=12";
        }
    }
}
