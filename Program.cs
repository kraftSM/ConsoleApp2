using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
// Basic version on GitHub V 0.1 + local
namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string YurName,MyName, InpStr;
            eColors favcolor = eColors.Red;
            string sName =" !! ";
            bool bHavePet = false;
            byte bAge =0;
            double dFootSize =0.0;

            ShowAll(sName, bHavePet, bAge, dFootSize);

            MyName = "Serge";
            YurName = "Незнакомец";
            Console.WriteLine("Здравствуйте  {0}, мое имя {1}. \n А как ваше?", YurName,MyName);
            InpStr = Console.ReadLine();
            Console.WriteLine("You say "+ InpStr);

            //Console.WriteLine(" max Int= {0} ", int.MaxValue);
            //Console.WriteLine(" min Int= {0} ", int.MinValue);
            
            //string str = Console.ReadLine() ;
            

            // T= 3.5.2
            Console.WriteLine("\tПривет,\n мир!");
            // T= 3.5.3
            bAge = 50; 
            Console.WriteLine($"мой возраст {bAge}\n");
            // T= 3.5.4
            Console.WriteLine("{0}\n{1}\n{2}", sName, bAge, favcolor);

            // Console.WriteLine("\u0023"); // uchar output
            Console.ReadKey();

        }

        static void ShowAll(string strVal, bool boolVal, byte byteVal, double doublVal)
        {
            const string strName = "Name";
            const string boolName = "Have a Pet";
            const string byteName = "Age";
            const string dublName = "Foot size";

            Console.WriteLine("ShowAll: {0} = {1}", strName, strVal);
            Console.WriteLine("ShowAll: {0} = {1}", boolName, boolVal);
            Console.WriteLine("ShowAll: {0} = {1}", byteName, byteVal);
            Console.WriteLine("ShowAll: {0} = {1}", dublName, doublVal);         
        }
        enum eColors : byte
        { Black,
          Red, 
          Green
        }

    }
}
