using System;
using System.Text;


namespace B23_Ex02_LiorRoife_206257826_MaorZemach_206273690
{
   public class UserInterface
   {
        private static Game m_CurrentGame;
        public static void RunGame()
        {
            
           
            for (int i = 0; i < boardSize; i++)
            {
                board.Append(i + 1 + "  ");
                if (i == (boardSize - 1))
                {
                    board.Append("|");
                }
            }

            Console.WriteLine(board);
        }

        public static void GameData()
        {
            int boardSize = getTheBoardSize();
            bool isPlayerVersusComputer = checkIfPlayerVresusTheComputer();

            if(isPlayerVersusComputer == true)
            {
                m_CurrentGame = new Game(boardSize,"Player 1","Computer", isPlayerVersusComputer);
            }
            else
            {
                m_CurrentGame = new Game(boardSize, "Player 1", "Player 2", isPlayerVersusComputer);
            }
        }
        public static void PrintBoard(Game i_CurrGame)
        {
            StringBuilder board = new StringBuilder();

        }

        private static int getTheBoardSize()
        {
            Console.WriteLine("Please enter the size of the game board(The size must be between 3 to 9):");
            string sizeOfTheBoard = Console.ReadLine();
            int BoardSize = int.Parse(sizeOfTheBoard);

            while(Game.isTheSizeOfTheBoardValid(BoardSize) == false)
            {
                Console.WriteLine("Invalid input. The number is not in the range , please enter new number (The size must be between 3 to 9):");
                sizeOfTheBoard = Console.ReadLine();
            }
            BoardSize = int.Parse(sizeOfTheBoard);
            return BoardSize;
        }

        private static bool checkIfPlayerVresusTheComputer()
        {
            bool isPlayerAgainstComputer = false;
            Console.WriteLine("If you want to play against the computer press:'c' , if you want to play against another player press: 'p'");
            string playerChoice = Console.ReadLine();

            while (playerChoice != "c" && playerChoice!="p")
            {
                Console.WriteLine("Invalid input. for game against the computer press:'c', for game against other player press:'p'");
                playerChoice = Console.ReadLine();
            }

            if(playerChoice == "c")
            {
                isPlayerAgainstComputer = true;
            }

            return isPlayerAgainstComputer;
        }    
   }
}
