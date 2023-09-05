using System;
using System.IO;
using System.Reflection.Metadata;

namespace PII_Game_Of_Life
{
    public class Importer
    {
        public static void LoadBoard(Board board, string filePath)
        {
            string content = File.ReadAllText(filePath);
            string[] contentLines = content.Split('\n');
            bool[,] parsedBoard = new bool[contentLines.Length, contentLines[0].Length];
        
            for (int y = 0; y < contentLines.Length; y++)
            {
                for (int x = 0; x < contentLines[y].Length; x++)
                {
                    if (contentLines[y][x] == '1')
                    {
                        parsedBoard[x, y] = true;
                    }
                }
            }
            board.SetBoard(parsedBoard);
        }
    }
}