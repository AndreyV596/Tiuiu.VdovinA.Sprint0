using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Tiuiu.VdovinA.Sprint0.Task2.V0.Lib;

namespace Tiuiu.VdovinA.Sprint0.Task2.V0
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DataService.GetMessage("Игорь"));
           
            Console.ReadKey();
        }
    }
}
