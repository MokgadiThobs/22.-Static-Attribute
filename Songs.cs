using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _22.Static_Attribute
{
    internal class Program
    {
        static void Main(string[] args) 
        {
            Songs holiday = new Songs("Holiday", "Green Day", 1);
        Songs kashmir = new Songs("kashmir", "Led Zippelin", 2);

            Console.WriteLine(Songs.songCount);
            Console.ReadLine();
        }
    }
}
