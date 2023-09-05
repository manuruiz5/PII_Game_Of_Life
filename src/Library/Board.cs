using System;
using System.IO;
using System.Reflection.Metadata;

namespace PII_Game_Of_Life
{
    public class Board
    {
        private bool[,] gameBoard;
        
        public void SetBoard(bool[,] newBoard)
        {
            gameBoard = newBoard;
        }
        public bool[,] GetBoard()
        {
             return gameBoard;
        }
       
    }
}
