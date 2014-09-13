using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _1_2_rita_med_asterisker
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Rita med asterisker - nivå C";
            
            do
            {
                Console.Clear();
                
            } while (IsContinuing());
        }
        private static bool IsContinuing()
        {
            ConsoleKeyInfo esc;
            esc = Console.ReadKey();
            return esc.Key != ConsoleKey.Escape;

        }
        //private static byte ReadOddByte(string prompt = null, byte maxValue = 255)
        //{

        //}
        private static void RenderDiamond(byte maxCount)
        {

        }
        private static void RenderRow(int maxCount, int asteriskCount)
        {

        }
    }
}
