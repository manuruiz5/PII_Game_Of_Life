using System;
using System.Threading;
using System.IO;
using System.Reflection.Metadata;
using System.Text;

namespace PII_Game_Of_Life
{
    class Program
    {
        static void Main(string[] args)
        {
            string filePath=@"board.txt";
            Board board= new Board();
            Importer.LoadBoard(board,filePath);
            while (true)
            {
                Console.Clear();
                Printer.Print(board);
                GameLogic.CalculateNextGeneration(board);
                Thread.Sleep(300);
            }
        }
    }
}
