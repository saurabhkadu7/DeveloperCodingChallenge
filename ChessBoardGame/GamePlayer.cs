using ChessBoardInterfaces;
using System;

namespace ChessBoardGame
{
    /// <summary>
    ///  In this class provide user-friendly interface of game.
    /// </summary>
    public class GamePlayer
    {
        private IRobotInstructions robotInstructions;
        public GamePlayer(IRobotInstructions robotInstructions)
        {
            this.robotInstructions = robotInstructions;
        }

        public void start()
        {
            Console.WriteLine("Please enter instructions:");

            bool isFirstInstruction = true;

            while (true)
            {
                // Get Instrucation from player
                string input = Console.ReadLine();

                // Split the input into separate parts
                string[] arrInstrcut = input.Split(' ');

                if(isFirstInstruction && arrInstrcut[0].ToUpper() != "PLACE")
                {
                    Console.WriteLine("Error: First instruction must be PLACE");
                    continue;
                }

                // Process the instructions
                switch (arrInstrcut[0].ToUpper())
                { 
                    case "PLACE":
                        if (arrInstrcut.Length == 4)
                        {
                            int row, col;
                            if (int.TryParse(arrInstrcut[1], out row) && int.TryParse(arrInstrcut[2], out col))
                            {
                                robotInstructions.Place(col, row, arrInstrcut[3]);
                            }
                            else
                            {
                                Console.WriteLine("Invalid instruction!! Please provide input as Robot Place, Row, Column, and Valid Directions.");
                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid instruction!! Please provide input as Robot Place, Row, Column, and Valid Directions.");
                            Console.ReadLine();
                        }
                        break;

                    case "PRINT":
                        robotInstructions.PrintPosition();
                        break;

                    case "TURN":
                        if(arrInstrcut.Length==2)
                        {
                            robotInstructions.Turn(arrInstrcut[1]);
                        }
                        break;

                    case "MOVE":
                        robotInstructions.Move();
                        break;

                }

                isFirstInstruction = false;
            }
        }
    }
}
