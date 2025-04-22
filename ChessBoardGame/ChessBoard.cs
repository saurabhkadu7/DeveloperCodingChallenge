using ChessBoardInterfaces;

namespace ChessBoardGame
{
    /// <summary>
    /// 3 * 3 Chess Board dimensions 
    /// </summary>
    public class ChessBoard : IChessBoard
    {
        // Board dimensions
        private const int Width = 3;
        private const int Height = 3;

        public bool IsValidPosition(int x, int y)
        {
            return x >= 0 && x < Height && y >= 0 && y < Width;
        }
    }
}
