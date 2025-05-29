using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Project
{
    public class Menu
    {
        static Simulator simulator = new Simulator();
        IDF idf = simulator.GetIDF();
        Hamas hams = simulator.GetHamas();
        Aman aman = simulator.GetAman();
        StrikeLog strikeLog = simulator.GetStrikeLog();
        StrikeExecution strikeExecution = simulator.GetStrikeExecution();
        DataAnalyzer dataAnalyzer = simulator.GetDataAnilyzer();


        public void ShowMenue()
        {
            
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.BackgroundColor = ConsoleColor.DarkGray;
            Console.WriteLine("=== Menue ===");
            Console.ResetColor();
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.Write(
                "1 >>> Identifying the terrorist with the most intelligence reports.\n" +
                "2 >>> Getting the most dangerous terrorist on the basis of quality rating.\n" +
                "3 >>> Displays all available attack units and ammunition inventory.\n" +
                "4 >>> Assault by ID number.\n" +
                "0 >>> Exit\n" +
                "Enter your choice : ");
            Console.ResetColor();

        }

        public string GetChoice()
        {
            string[] options = new string[] { "0", "1", "2", "3", "4" }; 
            string choice = Console.ReadLine();
            
            while (! options.Contains(choice))
            {
                Console.WriteLine("Invalid choice, please try again : ");
                choice = Console.ReadLine();
            }
            return choice;
        }
        
        public void MakeChoice(string choice)
        {
            switch (choice)
            {
                case "1" :
                    dataAnalyzer.MostReportedTerorist(aman.GetReportDic());
                    break;
                case "2":
                    dataAnalyzer.GetMostDangerousTerrorist(hams.GetAliveTerroristList(),aman);
                    break;
                case "3" :
                    dataAnalyzer.GetAllStrikeOptions(idf);
                    break;
                case "4":
                    strikeExecution.MakeStrike(strikeLog, hams, idf, aman);
                    strikeLog.PrintLastLog();
                break;
            }
            

        }

        public void RumMenue()
        {
            string choice = "";
            do
            {
                ShowMenue();
                choice = GetChoice();
                MakeChoice(choice);
            }
            while (!choice.Equals("0"));
        }
    }
}
