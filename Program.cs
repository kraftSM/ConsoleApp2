using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Net.Mime.MediaTypeNames;

namespace ConsoleApp2
{
    internal class Program
    {
        static string ShowColor()
        { return "Green"; }

        static void Main(string[] args)
        {
            /*
            string YurName, MyName, InpStr = "Ohh";

            string sName = " !! ";
            bool bHavePet = false;
            byte bAge = 0;
            double dFootSize = 0.0;
            DateTime dtBrthDay = DateTime.Today;
  
            // 4.1.10 
            
             var a = 6;
            var b = 7;

            if (a == b)
            {
                Console.WriteLine("4.1.0 Условие истинно");
            }
            else if (b < 10)
            {
                Console.WriteLine("4.1.0 Значение b = {0} меньше 10", b);
            }
            else
            {
                Console.WriteLine("Значение b = {0} больше 10", b);
            }
            // 4.1.11
            if (a == b)
            {
                Console.WriteLine(" 4.1.1 Условие истинно");
            }
            else
            {
                Console.WriteLine("4.1.1 Условие ложно");
            }
            */
            // 4.1.15
            /*
            var a = 6;
            var b = 7;
            var c = a != b ? a + b : b;

            Console.WriteLine(c);
         */   

            // B12-1-8  
            //Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
            // var color = Console.ReadLine();
            /* 
             // B12-1-9?
            if (color == "red")
            {
                Console.BackgroundColor = ConsoleColor.Red;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is red!");
            }

            else if (color == "green")
            {
                Console.BackgroundColor = ConsoleColor.Green;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is green!");
            }
            else
            {
                Console.BackgroundColor = ConsoleColor.Cyan;
                Console.ForegroundColor = ConsoleColor.Black;

                Console.WriteLine("Your color is cyan!");
            }
            */
            //// B12-1-9
            /*
             *Console.WriteLine("B12-1-9");
            switch (color)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":
                    
                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;

                default:

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Yellow; 
                    Console.WriteLine("Default case: Your color is Red/Yellow!");

                    break;
            };
            */
            /*
            for (int i = 5; i >1; i--)
            {
                Console.WriteLine("Iteration = {0} ...", i);
                Console.ReadKey();
                switch (Console.ReadLine()) 
                {
                    case "Red":
                        Console.BackgroundColor = ConsoleColor.Red;
                        Console.ForegroundColor = ConsoleColor.Black;

                        break;
                    default:
                        Console.BackgroundColor = ConsoleColor.Green;
                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        break;
                }
            }
            
            //// T4-2-10
            Console.WriteLine("T4-2-10: Цикл While");
            int w = 0;

            while ( w< 3)
            {
                Console.WriteLine(w);

                Console.WriteLine("Напишите свой любимый цвет на английском с маленькой буквы");
                switch (Console.ReadLine())
                    {
                        case "red":
                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Black;

                            Console.WriteLine("Your color is red!");
                            break;

                        case "green":
                            Console.BackgroundColor = ConsoleColor.Green;
                            Console.ForegroundColor = ConsoleColor.Black;

                            Console.WriteLine("Your color is green!");
                            break;

                        case "cyan":

                            Console.BackgroundColor = ConsoleColor.Cyan;
                            Console.ForegroundColor = ConsoleColor.Black;

                            Console.WriteLine("Your color is cyan!");
                            break;

                        default:

                            Console.BackgroundColor = ConsoleColor.Red;
                            Console.ForegroundColor = ConsoleColor.Yellow;
                            Console.WriteLine("Default case: Your color is Red/Yellow!");

                            break;
                    };
                 w++;
            }
*/
            Console.WriteLine("T4-2-10: Цикл Do .. While");
            int t = 0;
            do
            {
                Console.WriteLine("T4-2-10: Цикл Do .. While {0}",t);
                Console.WriteLine("Напишите цвет");
                var text = Console.ReadLine();
                if (text == "stop")
                {
                    Console.WriteLine("Цикл остановлен");
                    break;
                }
                SetConsoleColors(text);
                t++;
            }
            while(t<5);
            
            Console.WriteLine("Press key to exit ..."); 
            Console.ReadKey();
        }        
        static void ShowAll(string strVal, bool boolVal, byte byteVal, double doublVal, DateTime dtVal)
        {
            const string strName = "Name";
            const string boolName = "Have a Pet";
            const string byteName = "Age";
            const string dublName = "Foot size";
            const string dateName = "Birth Day is: ";

            Console.WriteLine("ShowAll: {0} = {1}", strName, strVal);
            Console.WriteLine("ShowAll: {0} = {1}", boolName, boolVal);
            Console.WriteLine("ShowAll: {0} = {1}", byteName, byteVal);
            Console.WriteLine("ShowAll: {0} = {1}", dublName, doublVal);
            Console.WriteLine("ShowAll: {0} = {1}", dateName, dtVal);
        }
        static void SetConsoleColors(string col)
        {
            switch (col)
            {
                case "red":
                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is red!");
                    break;

                case "green":
                    Console.BackgroundColor = ConsoleColor.Green;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is green!");
                    break;

                case "cyan":

                    Console.BackgroundColor = ConsoleColor.Cyan;
                    Console.ForegroundColor = ConsoleColor.Black;

                    Console.WriteLine("Your color is cyan!");
                    break;

                default:

                    Console.BackgroundColor = ConsoleColor.Red;
                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine("Default case: Your color is Red/Yellow!");

                    break;
            };
        }
     
    }
}
