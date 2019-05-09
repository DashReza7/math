using System;

namespace Lecturers
{
    class Program
    {
        static string currentNum;
        static string lecturersSymbol;
        static int correctAnswers;
        static void Main(string[] args)
        {
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.Write("Other lecturers symbol : ");
            lecturersSymbol = Console.ReadLine();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            for (int i = 0; i < 10; i++)
            {
                clearNums();
                addToString(i, "A");
                for (int j = 0; j < 10; j++)
                {
                    if (currentNum.Substring(j, 1) == lecturersSymbol.ToString())
                    {
                        addToString(j, "B");
                        for (int f = 0; f < 10; f++)
                        {
                            if (currentNum.Substring(f, 1) == lecturersSymbol.ToString())
                            {
                                addToString(f, "C");
                                checkTartib();
                                addToString(f, lecturersSymbol.ToString());
                            }
                        }
                        addToString(j, lecturersSymbol.ToString());
                    }
                }
            }
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("------------------------------------------------------");
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine("Correct base answers = " + correctAnswers);
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine("All of aanswers = " + correctAnswers + " * 7!   =   " + (correctAnswers * 5040));
            Console.ReadLine();
        }
        static void clearNums()
        {
            currentNum = "";
            for (int i = 0; i < 10; i++)
            {
                currentNum += lecturersSymbol;
            }
        }
        static void checkTartib()
        {
            int Acount = 0;
            int Bcount = 0;
            int Ccount = 0;
            for (int i = 0; i < 10; i++)
            {
                string curLetter = currentNum.Substring(i, 1);
                if (curLetter == "A")
                    Acount = i;
                else if (curLetter == "B")
                    Bcount = i;
                else if (curLetter == "C")
                    Ccount = i;
            }

            if (Acount < Bcount && Bcount < Ccount)
            {
                correctAnswers++;
                Console.WriteLine(currentNum);
            }
        }

        static void addToString(int from, string whatToAdd)
        {
            string connectionStr = "";
            for (int i = 0; i < 10; i++)
            {
                if (i != from)
                {
                    connectionStr += currentNum.Substring(i, 1);
                }
                else
                {
                    connectionStr += whatToAdd;
                }
            }
            currentNum = connectionStr;
        }
    }
}
