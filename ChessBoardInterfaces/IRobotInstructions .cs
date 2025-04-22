

namespace ChessBoardInterfaces
{
    /// <summary>
    /// Definition of Allowed Instructions
    /// </summary>
    public interface IRobotInstructions
    {
        void Place(int x, int y, string direction);
        void Turn(string direction);
        void Move();
        void PrintPosition();
    }
}
