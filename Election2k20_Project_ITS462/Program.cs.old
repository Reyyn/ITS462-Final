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
    class Program
    {
        //state, winnerName, candiate1,partyname1,partytotalvotes1,partypercntage1,candidate2,partyname2,partytotalvotes2,partypercntage2
        public static string[] GADATA = new string[10];
        public static string[] ALDATA = new string[10];
        public static string[] AKDATA = new string[10];
        public static string[] AZDATA = new string[10];
        public static string[] ARDATA = new string[10];
        public static string[] CADATA = new string[10];
        public static string[] CODATA = new string[10];
        public static string[] CTDATA = new string[10];
        public static string[] DEDATA = new string[10];
        public static string[] FLDATA = new string[10];
        public static string[] HIDATA = new string[10];
        public static string[] IDDATA = new string[10];
        public static string[] ILDATA = new string[10];
        public static string[] INDATA = new string[10];
        public static string[] IADATA = new string[10];
        public static string[] KSDATA = new string[10];
        public static string[] KYDATA = new string[10];
        public static string[] LADATA = new string[10];
        public static string[] MEDATA = new string[10];
        public static string[] MDDATA = new string[10];
        public static string[] MADATA = new string[10];
        public static string[] MIDATA = new string[10];
        public static string[] MNDATA = new string[10];
        public static string[] MSDATA = new string[10];
        public static string[] MODATA = new string[10];
        public static string[] MTDATA = new string[10];
        public static string[] NEDATA = new string[10];
        public static string[] NVDATA = new string[10];
        public static string[] NHDATA = new string[10];
        public static string[] NJDATA = new string[10];
        public static string[] NMDATA = new string[10];
        public static string[] NYDATA = new string[10];
        public static string[] NCDATA = new string[10];
        public static string[] NDDATA = new string[10];
        public static string[] OHDATA = new string[10];
        public static string[] OKDATA = new string[10];
        public static string[] ORDATA = new string[10];
        public static string[] PADATA = new string[10];
        public static string[] RIDATA = new string[10];
        public static string[] SCDATA = new string[10];
        public static string[] SDDATA = new string[10];
        public static string[] TNDATA = new string[10];
        public static string[] TXDATA = new string[10];
        public static string[] UTDATA = new string[10];
        public static string[] VTDATA = new string[10];
        public static string[] VADATA = new string[10];
        public static string[] WashingtonDATA = new string[10];
        public static string[] WADATA = new string[10];
        public static string[] WestVirginiaDATA = new string[10];
        public static string[] WIDATA = new string[10];
        public static string[] WYDATA = new string[10];
        public static string USAPRESIDENT = "";
        public static int BidenFinalCount;
        public static int TrumpFinalcount;
        static void Main(string[] args)
        {
            Webscrapper();

            /* TEST CODE FOR DBACCESS MODULE
            DBAccess db = new DBAccess();
            db.OpenConnection();
            State state = new State("TEST");
            state.Candidate1 = "Carrot";
            state.Candidate2 = "Potato";
            state.Winner = "Turnip";
            state.Party1 = "Mario";
            state.Party2 = "Peach";
            state.Votes1 = 1234;
            state.Votes2 = 4321;
            state.Percent1 = 30.0f;
            state.Percent2 = 60.0f;
            db.StoreVotes(state);
            db.CloseConnection();*/

            Console.ReadLine();

        }
        private static async Task Webscrapper() {
            await ParseData();
            Console.WriteLine(BidenFinalCount + "==========" + TrumpFinalcount + "\n Result: " + USAPRESIDENT);
            //**********************************connect to database and insert data here in the Webscrapper******************************************
        }
        private static async Task ParseData() {
            await GetHtmlAsyncGeorgia();
            await GetHtmlAsyncAlabama();
            await GetHtmlAsyncAlaska();
            await GetHtmlAsyncArizona();
            await GetHtmlAsyncArkansas();
            await GetHtmlAsyncCalifornia();
            await GetHtmlAsyncColorado();
            await GetHtmlAsyncConnecticut();
            await GetHtmlAsyncDelaware();
            await GetHtmlAsyncFlorida();
            await GetHtmlAsyncHawaii();
            await GetHtmlAsyncIdaho();
            await GetHtmlAsyncIllinois();
            await GetHtmlAsyncIndiana();
            await GetHtmlAsyncIowa();
            await GetHtmlAsyncKansas();
            await GetHtmlAsyncKentucky();
            await GetHtmlAsyncLouisiana();
            await GetHtmlAsyncMaine();
            await GetHtmlAsyncMaryland();
            await GetHtmlAsyncMassachusetts();
            await GetHtmlAsyncMichigan();
            await GetHtmlAsyncMinnesota();
            await GetHtmlAsyncMississippi();
            await GetHtmlAsyncMissouri();
            await GetHtmlAsyncMontana();
            await GetHtmlAsyncNebraska();
            await GetHtmlAsyncNevada();
            await GetHtmlAsyncNewHampshire();
            await GetHtmlAsyncNewJersey();
            await GetHtmlAsyncNewMexico();
            await GetHtmlAsyncNewYork();
            await GetHtmlAsyncNorthcarolina();
            await GetHtmlAsyncNorthDakota();
            await GetHtmlAsyncOhio();
            await GetHtmlAsyncOklahoma();
            await GetHtmlAsyncOregon();
            await GetHtmlAsyncPennsylvania();
            await GetHtmlAsyncRhodeIsland();
            await GetHtmlAsyncSouthCarolina();
            await GetHtmlAsyncSouthDakota();
            await GetHtmlAsyncTennessee();
            await GetHtmlAsyncTexas();
            await GetHtmlAsyncUtah();
            await GetHtmlAsyncVermont();
            await GetHtmlAsyncVirginia();
            await GetHtmlAsyncWashington();
            await GetHtmlAsyncWashingtonDC();
            await GetHtmlAsyncWestVirginia();
            await GetHtmlAsyncwisconsin();
            await GetHtmlAsyncwyoming();
            await FinalCount();
        }
        private static async Task FinalCount() {
            var url = "https://www.politico.com/2020-election/results/president/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            BidenFinalCount = int.Parse(htmlDoucment.DocumentNode.Descendants("span").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2606097951 count mobile")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*'));
            TrumpFinalcount = int.Parse(htmlDoucment.DocumentNode.Descendants("span").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1236422167 count mobile")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*'));
            if (BidenFinalCount >= 270)
            {
                USAPRESIDENT = "Jeo Biden is the President of the UNITED STATES";
            }
            else if (TrumpFinalcount >= 270)
            {
                USAPRESIDENT = "Donald Trump is the President of the UNITED STATES";
            }
            else {
                USAPRESIDENT = "Waiting for all Votes to be counted";
            }


        }
        private static async Task GetHtmlAsyncGeorgia()
        {
            var url = "https://www.politico.com/2020-election/results/georgia/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r','\n','\t', '*');
            var candidate_Name2 = candidate_Row[1].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row[1].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t','*');
            var partyTotalVotes2 = candidate_Row[1].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row[1].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;         
            }

            //store the data in to tem. golbal array. 
            GADATA[0] = (string)stateName;
            GADATA[1] = (string)stateWinner;
            GADATA[2] = (string)candidate_Name1;
            GADATA[3] = (string)partyName1;
            GADATA[4] = (string)partyTotalVotes1;
            GADATA[5] = (string)partyPercentage1;
            GADATA[6] = (string)candidate_Name2;
            GADATA[7] = (string)partyName2;
            GADATA[8] = (string)partyTotalVotes2;
            GADATA[9] = (string)partyPercentage2;
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: "+ stateWinner+"\n");
            Console.WriteLine("Candidate Name: "+candidate_Name1 + "\nParty Name: "+partyName1);
            Console.WriteLine("Total Votes: "+partyTotalVotes1 + "\nPercentage " + partyPercentage1+"\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
        }
        private static async Task GetHtmlAsyncAlabama()
        {
            var url = "https://www.politico.com/2020-election/results/alabama/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            ALDATA[0] = (string)stateName;
            ALDATA[1] = (string)stateWinner;
            ALDATA[2] = (string)candidate_Name1;
            ALDATA[3] = (string)partyName1;
            ALDATA[4] = (string)partyTotalVotes1;
            ALDATA[5] = (string)partyPercentage1;
            ALDATA[6] = (string)candidate_Name2;
            ALDATA[7] = (string)partyName2;
            ALDATA[8] = (string)partyTotalVotes2;
            ALDATA[9] = (string)partyPercentage2;

        }
        private static async Task GetHtmlAsyncAlaska()
        {
            var url = "https://www.politico.com/2020-election/results/alaska/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row[1].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row[1].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row[1].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row[1].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }

            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            AKDATA[0] = (string)stateName;
            AKDATA[1] = (string)stateWinner;
            AKDATA[2] = (string)candidate_Name1;
            AKDATA[3] = (string)partyName1;
            AKDATA[4] = (string)partyTotalVotes1;
            AKDATA[5] = (string)partyPercentage1;
            AKDATA[6] = (string)candidate_Name2;
            AKDATA[7] = (string)partyName2;
            AKDATA[8] = (string)partyTotalVotes2;
            AKDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncArizona()
        {
            var url = "https://www.politico.com/2020-election/results/arizona/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            AZDATA[0] = (string)stateName;
            AZDATA[1] = (string)stateWinner;
            AZDATA[2] = (string)candidate_Name1;
            AZDATA[3] = (string)partyName1;
            AZDATA[4] = (string)partyTotalVotes1;
            AZDATA[5] = (string)partyPercentage1;
            AZDATA[6] = (string)candidate_Name2;
            AZDATA[7] = (string)partyName2;
            AZDATA[8] = (string)partyTotalVotes2;
            AZDATA[9] = (string)partyPercentage2;

        }
        private static async Task GetHtmlAsyncArkansas()
        {
            var url = "https://www.politico.com/2020-election/results/arkansas/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            ARDATA[0] = (string)stateName;
            ARDATA[1] = (string)stateWinner;
            ARDATA[2] = (string)candidate_Name1;
            ARDATA[3] = (string)partyName1;
            ARDATA[4] = (string)partyTotalVotes1;
            ARDATA[5] = (string)partyPercentage1;
            ARDATA[6] = (string)candidate_Name2;
            ARDATA[7] = (string)partyName2;
            ARDATA[8] = (string)partyTotalVotes2;
            ARDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncCalifornia()
        {
            var url = "https://www.politico.com/2020-election/results/california/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            CADATA[0] = (string)stateName;
            CADATA[1] = (string)stateWinner;
            CADATA[2] = (string)candidate_Name1;
            CADATA[3] = (string)partyName1;
            CADATA[4] = (string)partyTotalVotes1;
            CADATA[5] = (string)partyPercentage1;
            CADATA[6] = (string)candidate_Name2;
            CADATA[7] = (string)partyName2;
            CADATA[8] = (string)partyTotalVotes2;
            CADATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncColorado()
        {
            var url = "https://www.politico.com/2020-election/results/colorado/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            CODATA[0] = (string)stateName;
            CODATA[1] = (string)stateWinner;
            CODATA[2] = (string)candidate_Name1;
            CODATA[3] = (string)partyName1;
            CODATA[4] = (string)partyTotalVotes1;
            CODATA[5] = (string)partyPercentage1;
            CODATA[6] = (string)candidate_Name2;
            CODATA[7] = (string)partyName2;
            CODATA[8] = (string)partyTotalVotes2;
            CODATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncConnecticut()
        {
            var url = "https://www.politico.com/2020-election/results/connecticut/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            CTDATA[0] = (string)stateName;
            CTDATA[1] = (string)stateWinner;
            CTDATA[2] = (string)candidate_Name1;
            CTDATA[3] = (string)partyName1;
            CTDATA[4] = (string)partyTotalVotes1;
            CTDATA[5] = (string)partyPercentage1;
            CTDATA[6] = (string)candidate_Name2;
            CTDATA[7] = (string)partyName2;
            CTDATA[8] = (string)partyTotalVotes2;
            CTDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncDelaware()
        {
            var url = "https://www.politico.com/2020-election/results/delaware/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            DEDATA[0] = (string)stateName;
            DEDATA[1] = (string)stateWinner;
            DEDATA[2] = (string)candidate_Name1;
            DEDATA[3] = (string)partyName1;
            DEDATA[4] = (string)partyTotalVotes1;
            DEDATA[5] = (string)partyPercentage1;
            DEDATA[6] = (string)candidate_Name2;
            DEDATA[7] = (string)partyName2;
            DEDATA[8] = (string)partyTotalVotes2;
            DEDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncFlorida()
        {
            var url = "https://www.politico.com/2020-election/results/florida/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            FLDATA[0] = (string)stateName;
            FLDATA[1] = (string)stateWinner;
            FLDATA[2] = (string)candidate_Name1;
            FLDATA[3] = (string)partyName1;
            FLDATA[4] = (string)partyTotalVotes1;
            FLDATA[5] = (string)partyPercentage1;
            FLDATA[6] = (string)candidate_Name2;
            FLDATA[7] = (string)partyName2;
            FLDATA[8] = (string)partyTotalVotes2;
            FLDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncHawaii()
        {
            var url = "https://www.politico.com/2020-election/results/hawaii/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            HIDATA[0] = (string)stateName;
            HIDATA[1] = (string)stateWinner;
            HIDATA[2] = (string)candidate_Name1;
            HIDATA[3] = (string)partyName1;
            HIDATA[4] = (string)partyTotalVotes1;
            HIDATA[5] = (string)partyPercentage1;
            HIDATA[6] = (string)candidate_Name2;
            HIDATA[7] = (string)partyName2;
            HIDATA[8] = (string)partyTotalVotes2;
            HIDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncIdaho()
        {
            var url = "https://www.politico.com/2020-election/results/idaho/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            IDDATA[0] = (string)stateName;
            IDDATA[1] = (string)stateWinner;
            IDDATA[2] = (string)candidate_Name1;
            IDDATA[3] = (string)partyName1;
            IDDATA[4] = (string)partyTotalVotes1;
            IDDATA[5] = (string)partyPercentage1;
            IDDATA[6] = (string)candidate_Name2;
            IDDATA[7] = (string)partyName2;
            IDDATA[8] = (string)partyTotalVotes2;
            IDDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncIllinois()
        {
            var url = "https://www.politico.com/2020-election/results/illinois/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            ILDATA[0] = (string)stateName;
            ILDATA[1] = (string)stateWinner;
            ILDATA[2] = (string)candidate_Name1;
            ILDATA[3] = (string)partyName1;
            ILDATA[4] = (string)partyTotalVotes1;
            ILDATA[5] = (string)partyPercentage1;
            ILDATA[6] = (string)candidate_Name2;
            ILDATA[7] = (string)partyName2;
            ILDATA[8] = (string)partyTotalVotes2;
            ILDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncIndiana()
        {
            var url = "https://www.politico.com/2020-election/results/indiana/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            INDATA[0] = (string)stateName;
            INDATA[1] = (string)stateWinner;
            INDATA[2] = (string)candidate_Name1;
            INDATA[3] = (string)partyName1;
            INDATA[4] = (string)partyTotalVotes1;
            INDATA[5] = (string)partyPercentage1;
            INDATA[6] = (string)candidate_Name2;
            INDATA[7] = (string)partyName2;
            INDATA[8] = (string)partyTotalVotes2;
            INDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncIowa()
        {
            var url = "https://www.politico.com/2020-election/results/iowa/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            IADATA[0] = (string)stateName;
            IADATA[1] = (string)stateWinner;
            IADATA[2] = (string)candidate_Name1;
            IADATA[3] = (string)partyName1;
            IADATA[4] = (string)partyTotalVotes1;
            IADATA[5] = (string)partyPercentage1;
            IADATA[6] = (string)candidate_Name2;
            IADATA[7] = (string)partyName2;
            IADATA[8] = (string)partyTotalVotes2;
            IADATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncKansas()
        {
            var url = "https://www.politico.com/2020-election/results/kansas/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            KSDATA[0] = (string)stateName;
            KSDATA[1] = (string)stateWinner;
            KSDATA[2] = (string)candidate_Name1;
            KSDATA[3] = (string)partyName1;
            KSDATA[4] = (string)partyTotalVotes1;
            KSDATA[5] = (string)partyPercentage1;
            KSDATA[6] = (string)candidate_Name2;
            KSDATA[7] = (string)partyName2;
            KSDATA[8] = (string)partyTotalVotes2;
            KSDATA[9] = (string)partyPercentage2;
        }
        
        private static async Task GetHtmlAsyncKentucky()
        {
            var url = "https://www.politico.com/2020-election/results/kentucky/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            KYDATA[0] = (string)stateName;
            KYDATA[1] = (string)stateWinner;
            KYDATA[2] = (string)candidate_Name1;
            KYDATA[3] = (string)partyName1;
            KYDATA[4] = (string)partyTotalVotes1;
            KYDATA[5] = (string)partyPercentage1;
            KYDATA[6] = (string)candidate_Name2;
            KYDATA[7] = (string)partyName2;
            KYDATA[8] = (string)partyTotalVotes2;
            KYDATA[9] = (string)partyPercentage2;
        }

        private static async Task GetHtmlAsyncLouisiana()
        {
            var url = "https://www.politico.com/2020-election/results/louisiana/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            LADATA[0] = (string)stateName;
            LADATA[1] = (string)stateWinner;
            LADATA[2] = (string)candidate_Name1;
            LADATA[3] = (string)partyName1;
            LADATA[4] = (string)partyTotalVotes1;
            LADATA[5] = (string)partyPercentage1;
            LADATA[6] = (string)candidate_Name2;
            LADATA[7] = (string)partyName2;
            LADATA[8] = (string)partyTotalVotes2;
            LADATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncMaine()
        {
            var url = "https://www.politico.com/2020-election/results/maine/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            MEDATA[0] = (string)stateName;
            MEDATA[1] = (string)stateWinner;
            MEDATA[2] = (string)candidate_Name1;
            MEDATA[3] = (string)partyName1;
            MEDATA[4] = (string)partyTotalVotes1;
            MEDATA[5] = (string)partyPercentage1;
            MEDATA[6] = (string)candidate_Name2;
            MEDATA[7] = (string)partyName2;
            MEDATA[8] = (string)partyTotalVotes2;
            MEDATA[9] = (string)partyPercentage2;
        }
       
        private static async Task GetHtmlAsyncMaryland()
        {
            var url = "https://www.politico.com/2020-election/results/maryland/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            MDDATA[0] = (string)stateName;
            MDDATA[1] = (string)stateWinner;
            MDDATA[2] = (string)candidate_Name1;
            MDDATA[3] = (string)partyName1;
            MDDATA[4] = (string)partyTotalVotes1;
            MDDATA[5] = (string)partyPercentage1;
            MDDATA[6] = (string)candidate_Name2;
            MDDATA[7] = (string)partyName2;
            MDDATA[8] = (string)partyTotalVotes2;
            MDDATA[9] = (string)partyPercentage2;
        }
        
        private static async Task GetHtmlAsyncMassachusetts()
        {
            var url = "https://www.politico.com/2020-election/results/massachusetts/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            MADATA[0] = (string)stateName;
            MADATA[1] = (string)stateWinner;
            MADATA[2] = (string)candidate_Name1;
            MADATA[3] = (string)partyName1;
            MADATA[4] = (string)partyTotalVotes1;
            MADATA[5] = (string)partyPercentage1;
            MADATA[6] = (string)candidate_Name2;
            MADATA[7] = (string)partyName2;
            MADATA[8] = (string)partyTotalVotes2;
            MADATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncMichigan()
        {
            var url = "https://www.politico.com/2020-election/results/michigan/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            MIDATA[0] = (string)stateName;
            MIDATA[1] = (string)stateWinner;
            MIDATA[2] = (string)candidate_Name1;
            MIDATA[3] = (string)partyName1;
            MIDATA[4] = (string)partyTotalVotes1;
            MIDATA[5] = (string)partyPercentage1;
            MIDATA[6] = (string)candidate_Name2;
            MIDATA[7] = (string)partyName2;
            MIDATA[8] = (string)partyTotalVotes2;
            MIDATA[9] = (string)partyPercentage2;
        }
        
        private static async Task GetHtmlAsyncMinnesota()
        {
            var url = "https://www.politico.com/2020-election/results/minnesota/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            MNDATA[0] = (string)stateName;
            MNDATA[1] = (string)stateWinner;
            MNDATA[2] = (string)candidate_Name1;
            MNDATA[3] = (string)partyName1;
            MNDATA[4] = (string)partyTotalVotes1;
            MNDATA[5] = (string)partyPercentage1;
            MNDATA[6] = (string)candidate_Name2;
            MNDATA[7] = (string)partyName2;
            MNDATA[8] = (string)partyTotalVotes2;
            MNDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncMississippi()
        {
            var url = "https://www.politico.com/2020-election/results/mississippi/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            MSDATA[0] = (string)stateName;
            MSDATA[1] = (string)stateWinner;
            MSDATA[2] = (string)candidate_Name1;
            MSDATA[3] = (string)partyName1;
            MSDATA[4] = (string)partyTotalVotes1;
            MSDATA[5] = (string)partyPercentage1;
            MSDATA[6] = (string)candidate_Name2;
            MSDATA[7] = (string)partyName2;
            MSDATA[8] = (string)partyTotalVotes2;
            MSDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncMissouri()
        {
            var url = "https://www.politico.com/2020-election/results/missouri/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            MODATA[0] = (string)stateName;
            MODATA[1] = (string)stateWinner;
            MODATA[2] = (string)candidate_Name1;
            MODATA[3] = (string)partyName1;
            MODATA[4] = (string)partyTotalVotes1;
            MODATA[5] = (string)partyPercentage1;
            MODATA[6] = (string)candidate_Name2;
            MODATA[7] = (string)partyName2;
            MODATA[8] = (string)partyTotalVotes2;
            MODATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncMontana()
        {
            var url = "https://www.politico.com/2020-election/results/montana/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            MTDATA[0] = (string)stateName;
            MTDATA[1] = (string)stateWinner;
            MTDATA[2] = (string)candidate_Name1;
            MTDATA[3] = (string)partyName1;
            MTDATA[4] = (string)partyTotalVotes1;
            MTDATA[5] = (string)partyPercentage1;
            MTDATA[6] = (string)candidate_Name2;
            MTDATA[7] = (string)partyName2;
            MTDATA[8] = (string)partyTotalVotes2;
            MTDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncNebraska()
        {
            var url = "https://www.politico.com/2020-election/results/nebraska/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            NEDATA[0] = (string)stateName;
            NEDATA[1] = (string)stateWinner;
            NEDATA[2] = (string)candidate_Name1;
            NEDATA[3] = (string)partyName1;
            NEDATA[4] = (string)partyTotalVotes1;
            NEDATA[5] = (string)partyPercentage1;
            NEDATA[6] = (string)candidate_Name2;
            NEDATA[7] = (string)partyName2;
            NEDATA[8] = (string)partyTotalVotes2;
            NEDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncNevada()
        {
            var url = "https://www.politico.com/2020-election/results/nevada/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            NVDATA[0] = (string)stateName;
            NVDATA[1] = (string)stateWinner;
            NVDATA[2] = (string)candidate_Name1;
            NVDATA[3] = (string)partyName1;
            NVDATA[4] = (string)partyTotalVotes1;
            NVDATA[5] = (string)partyPercentage1;
            NVDATA[6] = (string)candidate_Name2;
            NVDATA[7] = (string)partyName2;
            NVDATA[8] = (string)partyTotalVotes2;
            NVDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncNewHampshire()
        {
            var url = "https://www.politico.com/2020-election/results/new-hampshire/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            NHDATA[0] = (string)stateName;
            NHDATA[1] = (string)stateWinner;
            NHDATA[2] = (string)candidate_Name1;
            NHDATA[3] = (string)partyName1;
            NHDATA[4] = (string)partyTotalVotes1;
            NHDATA[5] = (string)partyPercentage1;
            NHDATA[6] = (string)candidate_Name2;
            NHDATA[7] = (string)partyName2;
            NHDATA[8] = (string)partyTotalVotes2;
            NHDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncNewJersey()
        {
            var url = "https://www.politico.com/2020-election/results/new-jersey/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            NJDATA[0] = (string)stateName;
            NJDATA[1] = (string)stateWinner;
            NJDATA[2] = (string)candidate_Name1;
            NJDATA[3] = (string)partyName1;
            NJDATA[4] = (string)partyTotalVotes1;
            NJDATA[5] = (string)partyPercentage1;
            NJDATA[6] = (string)candidate_Name2;
            NJDATA[7] = (string)partyName2;
            NJDATA[8] = (string)partyTotalVotes2;
            NJDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncNewMexico()
        {
            var url = "https://www.politico.com/2020-election/results/new-mexico/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            NMDATA[0] = (string)stateName;
            NMDATA[1] = (string)stateWinner;
            NMDATA[2] = (string)candidate_Name1;
            NMDATA[3] = (string)partyName1;
            NMDATA[4] = (string)partyTotalVotes1;
            NMDATA[5] = (string)partyPercentage1;
            NMDATA[6] = (string)candidate_Name2;
            NMDATA[7] = (string)partyName2;
            NMDATA[8] = (string)partyTotalVotes2;
            NMDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncNewYork()
        {
            var url = "https://www.politico.com/2020-election/results/new-york/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            NYDATA[0] = (string)stateName;
            NYDATA[1] = (string)stateWinner;
            NYDATA[2] = (string)candidate_Name1;
            NYDATA[3] = (string)partyName1;
            NYDATA[4] = (string)partyTotalVotes1;
            NYDATA[5] = (string)partyPercentage1;
            NYDATA[6] = (string)candidate_Name2;
            NYDATA[7] = (string)partyName2;
            NYDATA[8] = (string)partyTotalVotes2;
            NYDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncNorthcarolina()
        {
            var url = "https://www.politico.com/2020-election/results/north-carolina/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row[1].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row[1].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row[1].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row[1].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }

            //store the data in to tem. golbal array. 
            NCDATA[0] = (string)stateName;
            NCDATA[1] = (string)stateWinner;
            NCDATA[2] = (string)candidate_Name1;
            NCDATA[3] = (string)partyName1;
            NCDATA[4] = (string)partyTotalVotes1;
            NCDATA[5] = (string)partyPercentage1;
            NCDATA[6] = (string)candidate_Name2;
            NCDATA[7] = (string)partyName2;
            NCDATA[8] = (string)partyTotalVotes2;
            NCDATA[9] = (string)partyPercentage2;
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
        }
        private static async Task GetHtmlAsyncNorthDakota()
        {
            var url = "https://www.politico.com/2020-election/results/north-dakota/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            NDDATA[0] = (string)stateName;
            NDDATA[1] = (string)stateWinner;
            NDDATA[2] = (string)candidate_Name1;
            NDDATA[3] = (string)partyName1;
            NDDATA[4] = (string)partyTotalVotes1;
            NDDATA[5] = (string)partyPercentage1;
            NDDATA[6] = (string)candidate_Name2;
            NDDATA[7] = (string)partyName2;
            NDDATA[8] = (string)partyTotalVotes2;
            NDDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncOhio()
        {
            var url = "https://www.politico.com/2020-election/results/ohio/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            OHDATA[0] = (string)stateName;
            OHDATA[1] = (string)stateWinner;
            OHDATA[2] = (string)candidate_Name1;
            OHDATA[3] = (string)partyName1;
            OHDATA[4] = (string)partyTotalVotes1;
            OHDATA[5] = (string)partyPercentage1;
            OHDATA[6] = (string)candidate_Name2;
            OHDATA[7] = (string)partyName2;
            OHDATA[8] = (string)partyTotalVotes2;
            OHDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncOklahoma()
        {
            var url = "https://www.politico.com/2020-election/results/oklahoma/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            OKDATA[0] = (string)stateName;
            OKDATA[1] = (string)stateWinner;
            OKDATA[2] = (string)candidate_Name1;
            OKDATA[3] = (string)partyName1;
            OKDATA[4] = (string)partyTotalVotes1;
            OKDATA[5] = (string)partyPercentage1;
            OKDATA[6] = (string)candidate_Name2;
            OKDATA[7] = (string)partyName2;
            OKDATA[8] = (string)partyTotalVotes2;
            OKDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncOregon()
        {
            var url = "https://www.politico.com/2020-election/results/oregon/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            ORDATA[0] = (string)stateName;
            ORDATA[1] = (string)stateWinner;
            ORDATA[2] = (string)candidate_Name1;
            ORDATA[3] = (string)partyName1;
            ORDATA[4] = (string)partyTotalVotes1;
            ORDATA[5] = (string)partyPercentage1;
            ORDATA[6] = (string)candidate_Name2;
            ORDATA[7] = (string)partyName2;
            ORDATA[8] = (string)partyTotalVotes2;
            ORDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncPennsylvania()
        {
            var url = "https://www.politico.com/2020-election/results/pennsylvania/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            PADATA[0] = (string)stateName;
            PADATA[1] = (string)stateWinner;
            PADATA[2] = (string)candidate_Name1;
            PADATA[3] = (string)partyName1;
            PADATA[4] = (string)partyTotalVotes1;
            PADATA[5] = (string)partyPercentage1;
            PADATA[6] = (string)candidate_Name2;
            PADATA[7] = (string)partyName2;
            PADATA[8] = (string)partyTotalVotes2;
            PADATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncRhodeIsland()
        {
            var url = "https://www.politico.com/2020-election/results/rhode-island/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            RIDATA[0] = (string)stateName;
            RIDATA[1] = (string)stateWinner;
            RIDATA[2] = (string)candidate_Name1;
            RIDATA[3] = (string)partyName1;
            RIDATA[4] = (string)partyTotalVotes1;
            RIDATA[5] = (string)partyPercentage1;
            RIDATA[6] = (string)candidate_Name2;
            RIDATA[7] = (string)partyName2;
            RIDATA[8] = (string)partyTotalVotes2;
            RIDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncSouthCarolina()
        {
            var url = "https://www.politico.com/2020-election/results/south-carolina/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            SCDATA[0] = (string)stateName;
            SCDATA[1] = (string)stateWinner;
            SCDATA[2] = (string)candidate_Name1;
            SCDATA[3] = (string)partyName1;
            SCDATA[4] = (string)partyTotalVotes1;
            SCDATA[5] = (string)partyPercentage1;
            SCDATA[6] = (string)candidate_Name2;
            SCDATA[7] = (string)partyName2;
            SCDATA[8] = (string)partyTotalVotes2;
            SCDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncSouthDakota()
        {
            var url = "https://www.politico.com/2020-election/results/south-dakota/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            SDDATA[0] = (string)stateName;
            SDDATA[1] = (string)stateWinner;
            SDDATA[2] = (string)candidate_Name1;
            SDDATA[3] = (string)partyName1;
            SDDATA[4] = (string)partyTotalVotes1;
            SDDATA[5] = (string)partyPercentage1;
            SDDATA[6] = (string)candidate_Name2;
            SDDATA[7] = (string)partyName2;
            SDDATA[8] = (string)partyTotalVotes2;
            SDDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncTennessee()
        {
            var url = "https://www.politico.com/2020-election/results/tennessee/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            TNDATA[0] = (string)stateName;
            TNDATA[1] = (string)stateWinner;
            TNDATA[2] = (string)candidate_Name1;
            TNDATA[3] = (string)partyName1;
            TNDATA[4] = (string)partyTotalVotes1;
            TNDATA[5] = (string)partyPercentage1;
            TNDATA[6] = (string)candidate_Name2;
            TNDATA[7] = (string)partyName2;
            TNDATA[8] = (string)partyTotalVotes2;
            TNDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncTexas()
        {
            var url = "https://www.politico.com/2020-election/results/texas/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            TXDATA[0] = (string)stateName;
            TXDATA[1] = (string)stateWinner;
            TXDATA[2] = (string)candidate_Name1;
            TXDATA[3] = (string)partyName1;
            TXDATA[4] = (string)partyTotalVotes1;
            TXDATA[5] = (string)partyPercentage1;
            TXDATA[6] = (string)candidate_Name2;
            TXDATA[7] = (string)partyName2;
            TXDATA[8] = (string)partyTotalVotes2;
            TXDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncUtah()
        {
            var url = "https://www.politico.com/2020-election/results/utah/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            UTDATA[0] = (string)stateName;
            UTDATA[1] = (string)stateWinner;
            UTDATA[2] = (string)candidate_Name1;
            UTDATA[3] = (string)partyName1;
            UTDATA[4] = (string)partyTotalVotes1;
            UTDATA[5] = (string)partyPercentage1;
            UTDATA[6] = (string)candidate_Name2;
            UTDATA[7] = (string)partyName2;
            UTDATA[8] = (string)partyTotalVotes2;
            UTDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncVermont()
        {
            var url = "https://www.politico.com/2020-election/results/vermont/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            VTDATA[0] = (string)stateName;
            VTDATA[1] = (string)stateWinner;
            VTDATA[2] = (string)candidate_Name1;
            VTDATA[3] = (string)partyName1;
            VTDATA[4] = (string)partyTotalVotes1;
            VTDATA[5] = (string)partyPercentage1;
            VTDATA[6] = (string)candidate_Name2;
            VTDATA[7] = (string)partyName2;
            VTDATA[8] = (string)partyTotalVotes2;
            VTDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncVirginia()
        {
            var url = "https://www.politico.com/2020-election/results/virginia/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            VADATA[0] = (string)stateName;
            VADATA[1] = (string)stateWinner;
            VADATA[2] = (string)candidate_Name1;
            VADATA[3] = (string)partyName1;
            VADATA[4] = (string)partyTotalVotes1;
            VADATA[5] = (string)partyPercentage1;
            VADATA[6] = (string)candidate_Name2;
            VADATA[7] = (string)partyName2;
            VADATA[8] = (string)partyTotalVotes2;
            VADATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncWashington()
        {
            var url = "https://www.politico.com/2020-election/results/washington/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            WashingtonDATA[0] = (string)stateName;
            WashingtonDATA[1] = (string)stateWinner;
            WashingtonDATA[2] = (string)candidate_Name1;
            WashingtonDATA[3] = (string)partyName1;
            WashingtonDATA[4] = (string)partyTotalVotes1;
            WashingtonDATA[5] = (string)partyPercentage1;
            WashingtonDATA[6] = (string)candidate_Name2;
            WashingtonDATA[7] = (string)partyName2;
            WashingtonDATA[8] = (string)partyTotalVotes2;
            WashingtonDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncWashingtonDC()
        {
            var url = "https://www.politico.com/2020-election/results/washington-dc/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            WADATA[0] = (string)stateName;
            WADATA[1] = (string)stateWinner;
            WADATA[2] = (string)candidate_Name1;
            WADATA[3] = (string)partyName1;
            WADATA[4] = (string)partyTotalVotes1;
            WADATA[5] = (string)partyPercentage1;
            WADATA[6] = (string)candidate_Name2;
            WADATA[7] = (string)partyName2;
            WADATA[8] = (string)partyTotalVotes2;
            WADATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncWestVirginia()
        {
            var url = "https://www.politico.com/2020-election/results/west-virginia/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            WestVirginiaDATA[0] = (string)stateName;
            WestVirginiaDATA[1] = (string)stateWinner;
            WestVirginiaDATA[2] = (string)candidate_Name1;
            WestVirginiaDATA[3] = (string)partyName1;
            WestVirginiaDATA[4] = (string)partyTotalVotes1;
            WestVirginiaDATA[5] = (string)partyPercentage1;
            WestVirginiaDATA[6] = (string)candidate_Name2;
            WestVirginiaDATA[7] = (string)partyName2;
            WestVirginiaDATA[8] = (string)partyTotalVotes2;
            WestVirginiaDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncwisconsin()
        {
            var url = "https://www.politico.com/2020-election/results/wisconsin/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner dem-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            WIDATA[0] = (string)stateName;
            WIDATA[1] = (string)stateWinner;
            WIDATA[2] = (string)candidate_Name1;
            WIDATA[3] = (string)partyName1;
            WIDATA[4] = (string)partyTotalVotes1;
            WIDATA[5] = (string)partyPercentage1;
            WIDATA[6] = (string)candidate_Name2;
            WIDATA[7] = (string)partyName2;
            WIDATA[8] = (string)partyTotalVotes2;
            WIDATA[9] = (string)partyPercentage2;
        }
        private static async Task GetHtmlAsyncwyoming()
        {
            var url = "https://www.politico.com/2020-election/results/wyoming/";
            var httpCilent = new HttpClient();
            var html = await httpCilent.GetStringAsync(url);
            //Console.WriteLine(html.Result);
            // Console.Read();
            var htmlDoucment = new HtmlDocument();
            htmlDoucment.LoadHtml(html);
            var stateName = (htmlDoucment.DocumentNode.Descendants("h3").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2658823684 ")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var candidate_Row = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row winner gop-winner")).ToList();
            var candidate_Row2 = htmlDoucment.DocumentNode.Descendants("tr").Where(node => node.GetAttributeValue("class", "").Equals("jsx-2677388595 candidate-row")).ToList();
            // get candidate names 
            var candidate_Name1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var candidate_Name2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1912693590 name-only candidate-short-name")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            // get party names
            var partyName1 = (candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label gop")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper());
            var partyName2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("jsx-1420258095 party-label dem")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*').ToUpper();
            //get total votes 
            var partyTotalVotes1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyTotalVotes2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-votes-next-to-percent jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            //get Percentage Votes
            var partyPercentage1 = candidate_Row[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var partyPercentage2 = candidate_Row2[0].Descendants("div").Where(node => node.GetAttributeValue("class", "").Equals("candidate-percent-only jsx-3830922081")).FirstOrDefault().InnerText.Trim('\r', '\n', '\t', '*');
            var stateWinner = "";
            if (decimal.Parse(partyPercentage1.Trim('%')) >= decimal.Parse(partyPercentage2.Trim('%')))
            {
                stateWinner = candidate_Name1;
            }
            else
            {
                stateWinner = candidate_Name2;
            }
            Console.WriteLine("=================================================================================================");
            Console.WriteLine("State Name: " + stateName + " Winner: " + stateWinner + "\n");
            Console.WriteLine("Candidate Name: " + candidate_Name1 + "\nParty Name: " + partyName1);
            Console.WriteLine("Total Votes: " + partyTotalVotes1 + "\nPercentage " + partyPercentage1 + "\n");

            Console.WriteLine("Candidate Name: " + candidate_Name2 + "\nParty Name: " + partyName2);
            Console.WriteLine("Total Votes: " + partyTotalVotes2 + "\nPercentage " + partyPercentage2);
            Console.WriteLine("=================================================================================================");
            WYDATA[0] = (string)stateName;
            WYDATA[1] = (string)stateWinner;
            WYDATA[2] = (string)candidate_Name1;
            WYDATA[3] = (string)partyName1;
            WYDATA[4] = (string)partyTotalVotes1;
            WYDATA[5] = (string)partyPercentage1;
            WYDATA[6] = (string)candidate_Name2;
            WYDATA[7] = (string)partyName2;
            WYDATA[8] = (string)partyTotalVotes2;
            WYDATA[9] = (string)partyPercentage2;
        }

    }
}
