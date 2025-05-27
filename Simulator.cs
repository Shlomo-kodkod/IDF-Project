using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Project
{
    class Simulator
    {
        public Simulator()
        {
            HamasAndTerrorist();
            IdfAndStrike();
            InitAmanReport();
            
        }
        
        Random random = new Random();
        Hamas hamas = new Hamas(1987,"عز الدين الحداد");
        IDF idf = new IDF(1948, "Lieutenant General Eyal Zamir");
        Aman aman = new Aman();
        

        void HamasAndTerrorist()
        {
            string[] arabicNames = { "Ahmed", "Mohammed", "Youssef", "Ali", "Hassan", "Ibrahim", "Omar", "Khaled", "Tariq", "Faisal", "Nasser", "Ziad", "Samir", "Mustafa", "Jamal" };
            string[] weapons = {"Knife","Gun","M16","AK47"};
            
            for (int i = 0; i < random.Next(5,11); i++)
            {
                Terrorist terrorist = new Terrorist(arabicNames[random.Next(0, arabicNames.Length)],i,random.Next(1,6),true,InitWeapon());
                hamas.AddStrikOption(terrorist);
            }
            string[] InitWeapon()
            {
                List<string> weaponlist = new List<string>();

                for (int i = 0; i < random.Next(1,4); i++)
                {
                    weaponlist.Add(weapons[random.Next(0,weapons.Length)]);
                }
                return weaponlist.ToArray();
            }
            
            
            
        }

        void IdfAndStrike()
        {
            idf.AddStrikeOption(new F16());
            idf.AddStrikeOption(new Zik());
            idf.AddStrikeOption(new M109());

            for (int i = 0; i < random.Next(0, 10); i++)
            {
                int choice = random.Next(0, 3);
                switch (choice)
                {
                    case 0:
                        idf.AddStrikeOption(new F16());
                        break;
                    case 1:
                        idf.AddStrikeOption(new Zik());
                        break;
                    case 2:
                        idf.AddStrikeOption(new M109());
                        break;
                }
            }
        }
        
        void InitAmanReport()
        {
            string[] targetType = { "buildings", "open areas", "people", "vehicles" };
            for (int i = 0; i < random.Next(10,20); i++)
            {
                Terrorist terrorist = hamas.GetTerroristList()[random.Next(0, hamas.GetTerroristList().Count)];
                string lastLocition = targetType[random.Next(0, targetType.Length)];
                DateTime timeStemp = GetRandomTime();
                
                ReportAman report = new ReportAman(terrorist,lastLocition,timeStemp);
                aman.AddReport(report);
            }
            
            DateTime GetRandomTime()
            {
                Random random = new Random();
                return DateTime.Now.AddHours(-random.NextDouble() * 24);
            }
        }







    }
}
