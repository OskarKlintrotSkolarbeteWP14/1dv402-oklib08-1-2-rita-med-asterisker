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
            Console.Title = Strings.Console_Title;

            byte maxValue = 79;
            
            do
            {
                Console.Clear();

                //RenderDiamond renders the diamond (hence the name...) and uses ReadOddByte to  
                //get an input from user on how large diamond the user wants it to draw.
                RenderDiamond(ReadOddByte(Strings.Asterisk_Prompt, maxValue));
                Console.WriteLine();
                Console.Write(Strings.Continue_Prompt);
            } while (IsContinuing());
        }

        //Makes the Main loop until esc is pressed
        private static bool IsContinuing()
        {
            ConsoleKeyInfo esc;
            esc = Console.ReadKey();
            return esc.Key != ConsoleKey.Escape;

        }

        //Asks the user how large diamond it wants it to draw and also makes sure the input is valid
        private static byte ReadOddByte(string prompt = null, byte maxValue = 255)
        {
            byte readValue = 0;
            while (true)
            {
                try
                {
                    Console.Write(prompt, maxValue);
                    byte checkValue = byte.Parse(Console.ReadLine());

                    //Makes sure it's below maxValue and an odd number
                    if (checkValue > maxValue || (checkValue % 2 == 0))
                        throw new OverflowException();
                    readValue = checkValue;
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

        //Renders the diamond, sends data to RenderRow who makes the actual drawing
        private static void RenderDiamond(byte maxCount)
        {
            int addOrSub = 1; 
            int j = 0;
            for (int i = 0; i + j >= 0; i = i + addOrSub)
            {
                if (addOrSub > 0)
                {
                    RenderRow(maxCount - i - maxCount / 2, i + j);
                }
                else if (i + j != maxCount)
                {
                    RenderRow(maxCount - j - maxCount / 2, i + j);
                }
                j = i;
                //When the for loop hits maxCount, this if-statement makes it "reverse"
                if (i + j > maxCount)
                    addOrSub = -1;
            }
        }

        //Renders a row at the time 
        private static void RenderRow(int maxCount, int asteriskCount)
        {
            for (int i = 0; i < maxCount; i++)
            {
                Console.Write(" "); 
            }

            int j = 1;
            for (int i = 0; i < asteriskCount; i++)
            {
                if (j >= 0)
                    Console.Write("*");
                j = i;
            }
            Console.WriteLine(); 
        }
    }
}
