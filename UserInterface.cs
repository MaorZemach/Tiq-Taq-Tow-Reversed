using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversed_TicTacToe_For_Console
{
    public class UserInterface
    {
        public static void RunGame()
        {
            GameLogics CurrentGame;
            int BoardSize = GetBoardSize();
            bool IsPlayerAgainstComputer = checkIfPlayerVersusTheComputer();
            CurrentGame = new GameLogics(BoardSize,IsPlayerAgainstComputer);
            MakeTurn(CurrentGame);
            //Ask for input size
            //Check Input with the game logics
            //Ask PVP or PVAI
            //Print empty board

            //while(not Q , not EndGame)
            //MakeTurn:
            //get X,Y choice until it's legal or Q
            //check validity and print error if Cell is taken

            //clear prev board and print new board

            //Check EndGame?
            //-no , switch player
            //-yes (if vertical / diagonal / horizontal win / TIE / Q) print winner & score
            //ask user if he wants new game (with same score and board size)



        }
        public static int GetBoardSize()
        {
            Console.WriteLine("Please enter the size of the game board (the board is a square shaped and its' size must be between 3 to 9):");
            string sizeOfTheBoard = Console.ReadLine();
            int BoardSize = int.Parse(sizeOfTheBoard);

            while (GameLogics.CheckGameBoardSize(BoardSize) == false || sizeOfTheBoard.All(char.IsDigit) == false)
            {
                if(sizeOfTheBoard.All(char.IsDigit) == false)
                {
                    Console.WriteLine("Invalid input. You must enter a number between 3 to 9:");
                    sizeOfTheBoard = Console.ReadLine();
                }
                else if(GameLogics.CheckGameBoardSize(BoardSize) == false)
                {
                    Console.WriteLine("Invalid input. The number is not in the range , please enter new number (The number must be between 3 to 9):");
                    sizeOfTheBoard = Console.ReadLine();
                }
            }
            BoardSize = int.Parse(sizeOfTheBoard);

            return BoardSize;
        }

        private static bool checkIfPlayerVersusTheComputer()
        {
            bool isPlayerAgainstComputer = false;
            Console.WriteLine("If you want to play against the computer press:'c' , if you want to play against another player press:'p'");
            string playerChoice = Console.ReadLine();

            while (playerChoice != "c" && playerChoice != "p")
            {
                Console.WriteLine("Invalid input. for game against the computer press:'c', for game against other player press:'p'");
                playerChoice = Console.ReadLine();
            }

            if (playerChoice == "c")
            {
                isPlayerAgainstComputer = true;
            }

            return isPlayerAgainstComputer;
        }

        private static void MakeTurn (GameLogics io_CurrentGame)
        {
            string PlayerInput;
            Console.WriteLine("If you want to make your turn press 'y' , else if you want to quit from the game press 'q'",Environment.NewLine);
            PlayerInput = Console.ReadLine();
            // if player press q so go to EndGame
            getPlayerMove(io_CurrentGame);
        }
          
        private static void getPlayerMove(GameLogics io_CurrGame)
        {
            int row = getAndCheckRow(io_CurrGame);
            int col = getAndCheckColumn(io_CurrGame);      
            PlayerMoveValidator(io_CurrGame, row, col);

        }

        private static void PlayerMoveValidator(GameLogics io_CurrGame, int i_row,int i_col)
        {
            int currRow = i_row;
            int currColumn = i_col;
            bool isMoveValid = false;

            while (isMoveValid = io_CurrGame.CheckIsCellEmpty(currRow, currColumn) == false)
            {
                Console.WriteLine("The cell is already taken please choose another one: ",Environment.NewLine);
                currRow = getAndCheckRow(io_CurrGame);
                currColumn = getAndCheckColumn(io_CurrGame);
            }
        }

        private static int getAndCheckRow(GameLogics io_CurrGame)
        {
            string stringRow;
            Console.WriteLine("Enter the row you want your symbol to be in:", Environment.NewLine);
            stringRow = Console.ReadLine();
            int row = int.Parse(stringRow);

            while (row < 1 || row > io_CurrGame.Board.BoardSize || stringRow.All(char.IsDigit) == false)
            {
                Console.WriteLine("Invalid input. Enter a number between 1 to {0}", io_CurrGame.Board.BoardSize);
                Console.WriteLine(Environment.NewLine);
                stringRow = Console.ReadLine();
                row = int.Parse(stringRow);
            }

            return row;
        }

        private static int getAndCheckColumn(GameLogics io_CurrGame)
        {
            string stringColumn;
            Console.WriteLine("Enter the column you want your symbol to be in:", Environment.NewLine);
            stringColumn = Console.ReadLine();
            int column = int.Parse(stringColumn);

            while (column < 1 || column > io_CurrGame.Board.BoardSize || stringColumn.All(char.IsDigit) == false)
            {
                Console.WriteLine("Invalid input. Enter a number between 1 to {0}", io_CurrGame.Board.BoardSize);
                Console.WriteLine(Environment.NewLine);
                stringColumn = Console.ReadLine();
                column = int.Parse(stringColumn);
            }

            return column;
        }
    }
}
