using System;
using System.IO;
using System.Reflection.Metadata;

namespace PII_Game_Of_Life
{
    public class GameLogic
    {
        public static void CalculateNextGeneration(Board board)
        {
            bool[,] currentBoard=board.GetBoard();
            int boardWidth=currentBoard.GetLength(0);
            int boardHeight=currentBoard.GetLength(1);
            bool[,] cloneBoard=new bool[boardWidth, boardHeight];

            for (int x = 0; x < boardWidth; x++)
            {
                for (int y = 0; y < boardHeight; y++)
                {
                    int aliveNeighbors=CalculateAliveNeighbors(currentBoard, x,y);
                    cloneBoard[x,y]=GetCellNextState(currentBoard[x,y],aliveNeighbors);
                }
            }

            board.SetBoard(cloneBoard);
        }

        private static int CalculateAliveNeighbors(bool[,] board, int x,int y)
        {
            int aliveNeighbors=0;
            int boardWidth=board.GetLength(0);
            int boardHeight=board.GetLength(1);
            for (int i = x-1; i <= x+1; i++)           
            {
                for (int j = y-1; j <= y+1; j++)
                {
                    if (i>=0 && i<boardWidth && j>=0 && j<boardHeight && board[i,j])
                    {
                        if (i!=x || j!=y)
                        {
                            aliveNeighbors++;
                        }
                    }
                }
            }
            return aliveNeighbors;
        }
        private static bool GetCellNextState(bool currentCellState,int aliveNeighbors)
        {
            if (currentCellState && (aliveNeighbors<2 || aliveNeighbors>3))
            {
                return false;
            }
            else if (!currentCellState && aliveNeighbors==3)
            {
                return true;
            }
            else
            {
                return currentCellState;
            }
        }
    }
}