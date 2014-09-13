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

            byte maxValue = 79;
            
            do
            {
                Console.Clear();
                ReadOddByte(Strings.Asterisk_Prompt, maxValue);
                
            } while (IsContinuing());
        }
        private static bool IsContinuing()
        {
            ConsoleKeyInfo esc;
            esc = Console.ReadKey();
            return esc.Key != ConsoleKey.Escape;

        }
        private static byte ReadOddByte(string prompt = null, byte maxValue = 255)
        {
            byte readValue = 0;
            while (true)
            {
                try
                {
                    Console.Write(prompt, maxValue);
                    byte checkValue = byte.Parse(Console.ReadLine());
                    if (checkValue > maxValue || (checkValue % 2 == 0))
                        throw new OverflowException();
                    readValue = checkValue;
                    Console.WriteLine(readValue);
                    break;
                }
                catch (Exception)
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(Strings.Error_Message, maxValue);
                    Console.ResetColor();
                }
            }
            return readValue;
        }
        private static void RenderDiamond(byte maxCount)
        {

        }
        private static void RenderRow(int maxCount, int asteriskCount)
        {

        }
    }
}
