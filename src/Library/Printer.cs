using System;
using System.IO;
using System.Reflection.Metadata;
using System.Text;

namespace PII_Game_Of_Life
{
    public class Printer
    {
        public static void Print(Board board)
        {
            bool[,] currentBoard=board.GetBoard();
            int boardWidth=currentBoard.GetLength(0);
            int boardHeight=currentBoard.GetLength(1);

            StringBuilder s=new StringBuilder();
            for (int y = 0; y < boardHeight; y++)
            {
                for (int x = 0; x < boardWidth; x++)
                {
                    if (currentBoard[x,y])
                    {
                        s.Append("|X|");
                    }
                    else
                    {
                        s.Append("___");
                    }
                }
                s.Append("\n");
            }
            Console.WriteLine(s.ToString());
            
        }
         
    }
}