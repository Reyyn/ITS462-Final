/* PNW ITS462 
 * Fall 2020
 * Final Project
 * Yash Patel 
 * */
using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace Election2k20_Project_ITS462
{
    class Program {
        static string[] districts = { "georgia", "alabama", "alaska", "arizona", "arkansas",
                                    "california", "colorado", "conneticut", "deleware", "florida",
                                    "hawaii", "idaho", "illinois", "indiana", "iowa",
                                    "kansas", "kentucky", "louisiana", "maine", "maryland",
                                    "massachusetts", "michigan", "minnesota", "missisippi", "wyoming",
                                    "missouri", "montana", "nerbaska", "nevada", "new-hampshire",
                                    "new-jersey", "new-mexico", "new-york", "north-carolina", "north-dakota",
                                    "ohio", "oklahoma", "oregon", "pennsylvania", "rhode-island",
                                    "south-carolina", "south-dakota", "tennessee", "texas", "utah",
                                    "vermont", "virginia", "washington", "washington-dc", "west-virginia",
                                    "wisconsin"
        };

        static List<State> data = new List<State>(51);

        public static void Main(string[] args) {
            Webscapper();

            Console.ReadLine();
        }

        public static async Task Webscapper() {
            foreach (var d in districts) {
                Console.WriteLine(d);
                await GetHtmlAsync(d);
            }
        }

        public static async Task GetHtmlAsync(string district) {
            var url = "https://www.politico.com/2020-election/results/" + district + "/";
            var httpClient = new HttpClient();
            var html = await httpClient.GetStringAsync(url);

            //if (page.parse("some line that says we won demo")) {
            //    DemoHtml(district);
            //}
            //.. for each page variant

            
        }

        public static async Task DemoHTML(string district) {

            // put crap here

            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");

            State s = new State(stateName);
            s.Candidate1 = candidate_Name1;
            s.Candidate2 = candidate_Name2;
            s.Party1 = partyName1;
            s.Party2 = partyName2;
            s.Percent1 = float.Parse(partyPercentage1);
            s.Percent2 = float.Parse(partyPercentage2);
            s.Votes1 = int.Parse(partyTotalVotes1);
            s.Votes2 = int.Parse(partyTotalVotes2);
            s.Winner = stateWinner;

            data.Add(s);
        }
        public static async Task RepHTML(string district) {
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");

            State s = new State(stateName);
            s.Candidate1 = candidate_Name1;
            s.Candidate2 = candidate_Name2;
            s.Party1 = partyName1;
            s.Party2 = partyName2;
            s.Percent1 = float.Parse(partyPercentage1);
            s.Percent2 = float.Parse(partyPercentage2);
            s.Votes1 = int.Parse(partyTotalVotes1);
            s.Votes2 = int.Parse(partyTotalVotes2);
            s.Winner = stateWinner;

            data.Add(s);
        }
        public static async Task UndecidedHTML(string district) {
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");

            State s = new State(stateName);
            s.Candidate1 = candidate_Name1;
            s.Candidate2 = candidate_Name2;
            s.Party1 = partyName1;
            s.Party2 = partyName2;
            s.Percent1 = float.Parse(partyPercentage1);
            s.Percent2 = float.Parse(partyPercentage2);
            s.Votes1 = int.Parse(partyTotalVotes1);
            s.Votes2 = int.Parse(partyTotalVotes2);
            s.Winner = stateWinner;

            data.Add(s);
        }
    }
}
