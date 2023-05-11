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
        public void GetBoardSize()
        {
            Console.WriteLine("Please enter the size of the game board (the board is a square shaped and its' size must be between 3 to 9):");
            string sizeOfTheBoard = Console.ReadLine();
            int BoardSize = int.Parse(sizeOfTheBoard);

            while (GameLogics.CheckGameBoardSize(BoardSize) == false)
            {
                Console.WriteLine("Invalid input. The number is not in the range , please enter new number (The size must be between 3 to 9):");
                sizeOfTheBoard = Console.ReadLine();
            }
            BoardSize = int.Parse(sizeOfTheBoard);
            return BoardSize;
        }
    }
}
