using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IDF_Project
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            Terrorist a = new Terrorist("s", 2, true, ["ff"]);
            Console.WriteLine(a.IsStatus());
            a.ChangeStatus();
            Console.WriteLine(a.IsStatus());
        }
            
        
    }
}
