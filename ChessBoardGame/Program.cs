
using ChessBoardInterfaces;

namespace ChessBoardGame
{
    class Program
    {
        /// <summary>
        /// starting point of Chess Board Game
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        { 
            IChessBoard chessBoard = new ChessBoard();
            IRobotInstructions robotInstructions = new RobotInstructions(chessBoard);

            GamePlayer player = new GamePlayer(robotInstructions);
            player.start();

        }
    }
}
