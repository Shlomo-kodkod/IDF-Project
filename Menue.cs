using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Project
{
    public class Menue
    {
        static Simulator simulator = new Simulator();
        public void ShowMenue()
        {
            Console.Write("=== Menue ===\n" +
                "1 >>> Identifying the terrorist with the most intelligence reports.\n" +
                "2 >>> Displays all available attack units and ammunition inventory.\n" +
                "3 >>> Getting the most dangerous terrorist on the basis of quality rating.\n" +
                "4 >>> Assault by ID number.\n" +
                "0 >>> Exit\n" +
                "Enter your choice:");
        }

        public string GetChoice()
        {
            string[] options = new string[] { "0", "1", "2", "3", "4" }; 
            string choice = Console.ReadLine();
            
            while (! options.Contains(choice))
            {
                Console.WriteLine("Invalid choice, please try again: ");
                choice = Console.ReadLine();
            }
            return choice;
        }
        
        public void MakeChoice(string choice)
        {
            switch (choice)
            {case "1" :
                simulator.GetDataAnilyzer().MostReportedTerorist(simulator.GetAman().GetReportDic());
                break;
                case "2" :
                simulator.GetDataAnilyzer().GetAllStrikeOptions(simulator.GetIDF());
                break;
                case "3":
                simulator.GetDataAnilyzer().GetMostDangerousTerrorist(simulator.GetHamas().GetAliveTerroristList());
                break;
                case "4":
                // simulator.GetStrikeExecution().MakeStrike(simulator.);
                simulator.GetStrikeLog().PrintLastLog();
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
