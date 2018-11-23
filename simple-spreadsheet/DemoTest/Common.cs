using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoTest
{
    class Common
    {
        // Action for first number
        public static void Parameter1(string _CreateSheet, string _CreateNumber)
        {
            if (_CreateNumber.Trim() == _CreateNumber && _CreateNumber.IndexOf(" ") > -1)
            {
                char[] separators = new char[] { ' ' };
                string[] _position = _CreateNumber.Split(separators);
                if (_position.Length == 4)
                {
                    if (_position[0].ToUpper() == "N")
                    {
                        Console.Clear();
                        CreateSpreadSheet(_CreateSheet);
                        DisplayTextSpecificLocation(int.Parse(_position[1]), int.Parse(_position[2]), int.Parse(_position[3]));

                    }
                    else
                    {
                        Console.WriteLine("Not a valid command!!");
                        Console.Read();
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid format!!");
                    Console.Read();
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Entered format not correct!!");
                Environment.Exit(0);
            }
        }
        // Action for first number
        public static void Parameter2(string _CreateSheet, string _CreateNumber, string _CreateNumber1)
        {
            if (_CreateNumber1.Trim() == _CreateNumber1 && _CreateNumber1.IndexOf(" ") > -1)
            {
                char[] separators = new char[] { ' ' };
                string[] _position = _CreateNumber1.Split(separators);
                if (_position.Length == 4)
                {
                    if (_position[0].ToUpper() == "N")
                    {

                        Parameter1(_CreateSheet, _CreateNumber);
                        DisplayTextSpecificLocation(int.Parse(_position[1]), int.Parse(_position[2]), int.Parse(_position[3]));
                    }
                    else
                    {
                        Console.WriteLine("Not a valid command!!");
                        Console.Read();
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid format!!");
                    Console.Read();
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Entered format not correct!!");
                Console.Read();
                Environment.Exit(0);
            }
        }
        // Action for Sum
        public static void Parameter3(string _CreateSheet, string _CreateNumber, string _CreateNumber1, string _CreateNumber2, int output)
        {
            if (_CreateNumber2.Trim() == _CreateNumber2 && _CreateNumber2.IndexOf(" ") > -1)
            {
                char[] separators = new char[] { ' ' };
                string[] _position = _CreateNumber2.Split(separators);
                if (_position.Length == 7)
                {
                    if (_position[0].ToUpper() == "S")
                    {
                        Parameter2(_CreateSheet, _CreateNumber, _CreateNumber1);
                        DisplayTextSpecificLocation(int.Parse(_position[5]), int.Parse(_position[6]), output);
                    }
                    else
                    {
                        Console.WriteLine("Not a valid command!!");
                        Console.Read();
                        Environment.Exit(0);
                    }
                }
                else
                {
                    Console.WriteLine("Not a valid format!!");
                    Console.Read();
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Entered format not correct!!");
                Console.Read();
                Environment.Exit(0);
            }
        }
        // Action for SpreadSheet
        public static void CreateSpreadSheet(string _CreateSheet)
        {
            if (_CreateSheet.Trim() == _CreateSheet && _CreateSheet.IndexOf(" ") > -1)
            {
                char[] separators = new char[] { ' ' };
                string[] _position = _CreateSheet.Split(separators);
                if (_position[0].ToUpper() == "C")
                {
                    DrawBox(int.Parse(_position[1]), int.Parse(_position[2]));
                }
                else
                {
                    Console.WriteLine("Not a valid command!!");
                    Console.Read();
                    Environment.Exit(0);
                }
            }
            else
            {
                Console.WriteLine("Entered format not correct!!");
                Console.Read();
                Environment.Exit(0);
            }
        }
        // Used to disply content in proper coordinates
        public static void DisplayTextSpecificLocation(int x, int y, int Text)
        {
            y = y - 1;
            Console.ForegroundColor = ConsoleColor.Red;
            Console.SetCursorPosition(x, y);
            Console.Write(Text);
            Console.ResetColor();
        }

        static void DrawLine(int w, char ends, char mids)
        {
            Console.Write(ends);
            for (int i = 1; i < w - 1; ++i)
                Console.Write(mids);
            Console.WriteLine(ends);
        }

        static void DrawBox(int w, int h)
        {
            h = h + 1;
            DrawLine(w, '-', '-');
            for (int i = 1; i < h - 1; ++i)
                DrawLine(w, '|', ' ');
            DrawLine(w, '-', '-');
        }
    }
}
