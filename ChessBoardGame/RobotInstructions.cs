using ChessBoardInterfaces;
using System;

namespace ChessBoardGame
{
    /// <summary>
    /// In this class added all Robot Instrucations Implementation
    /// </summary>
    public class RobotInstructions : IRobotInstructions
    {
        private IChessBoard chessBoard;
        private int robotPosAtRow;
        private int robotPosAtCol;
        private string robotDirection;

        public RobotInstructions(IChessBoard chessBoard)
        {
            this.chessBoard = chessBoard;
        }

        public void Move()
        {
            int newRow = robotPosAtRow;
            int newColumn = robotPosAtCol;

            switch (robotDirection?.ToUpper())
            {
                case "NORTH":
                    newRow++;
                    break;

                case "EAST":
                    newColumn++;
                    break;

                case "WEST":
                    newColumn--;
                    break;
                case "SOUTH":
                    newRow--;
                    break;
            }

            if(chessBoard.IsValidPosition(newRow,newColumn))
            {
                robotPosAtRow=newRow;
                robotPosAtCol=newColumn;
            }
            else
            {
                Console.WriteLine("Stop! Going to fall!");
            }
        }

        public void Place(int x, int y, string direction)
        {

            if (chessBoard.IsValidPosition(x, y))
            {
                robotPosAtRow = x;
                robotPosAtCol = y;
                this.robotDirection = direction;
            }
            else
            {
                Console.WriteLine("Invalid position");
            }
        }

        public void PrintPosition()
        {
            Console.WriteLine($"{robotPosAtCol},{robotPosAtRow},{robotDirection}");
        }

        public void Turn(string direction)
        {
            this.robotDirection = direction;
        }
    }
}
