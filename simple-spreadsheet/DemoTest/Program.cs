using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.ConsoleColor;

namespace DemoTest
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {

                //Create SpreadSheet
                String _global = "";
                Console.Write("enter command: ");
                string _CreateSheet = Console.ReadLine();
                Common.CreateSpreadSheet(_CreateSheet);

                //End SpreadSheet

                //Create Number
                Console.Write("enter command: ");
                string _CreateNumber = Console.ReadLine();
                Common.Parameter1(_CreateSheet, _CreateNumber);

                //End Number

                //Create Number
                Console.ReadKey();
                Console.Clear();
                Console.Write("enter command: ");
                string _CreateNumber1 = Console.ReadLine();

                Common.Parameter2(_CreateSheet, _CreateNumber,_CreateNumber1);
                //End Number
                char[] separators = new char[] { ' ' };
                string[] _position = _CreateNumber.Split(separators);
                string[] _position1 = _CreateNumber1.Split(separators);
                _global = _position[1] + _position[2] + _position1[1] + _position1[2];
                int _val = int.Parse(_position[3]) + int.Parse(_position1[3]);

                //Create Number
                Console.ReadKey();
                Console.Clear();
                Console.Write("enter command: ");
                string _CreateNumber2 = Console.ReadLine();
                Common.Parameter3(_CreateSheet, _CreateNumber, _CreateNumber1, _CreateNumber2,_val);
                //End Number
                Console.Write("enter command: ");
                string _command2 = Console.ReadLine();
                if (_command2.ToUpper() == "Q")
                {
                    Environment.Exit(0);
                }

            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                Console.Read();
            }
        }
    }
}
