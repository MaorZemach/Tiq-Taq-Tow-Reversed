using System;
using System.Text;


namespace B23_Ex02_LiorRoife_206257826_MaorZemach_206273690
{
    public class Game
    {
        private const int k_MinimumSizeOfBoard = 3;
        private const int k_MaximumSizeOfBoard = 9;
        public const char k_PlayerOneSymbol = 'X';
        public const char k_PlayerTwoSymbol = 'O';
        private GameBoard m_CurrentGameBoard;
        private Player m_PlayerOne;
        private Player m_PlayerTwo;
        private readonly bool r_IsPlayerVresusComputer;

        public Game(int i_BoardSize, string i_PlayerOneName, string i_PlayerTwoName, bool i_IsComputerPlaying)
        {
            m_PlayerOne = new Player(k_PlayerOneSymbol, i_PlayerOneName);
            m_PlayerTwo = new Player(k_PlayerTwoSymbol, i_PlayerTwoName);
            m_CurrentGameBoard = new GameBoard(i_BoardSize);
            r_IsPlayerVresusComputer = i_IsComputerPlaying;
        }

        public static bool isTheSizeOfTheBoardValid(int i_BoardSize)
        {
            bool isTheSizeValid = false;
            if(i_BoardSize>= k_MinimumSizeOfBoard||i_BoardSize<=k_MaximumSizeOfBoard)
            {
                isTheSizeValid = true;
            }

            return isTheSizeValid;
        }

        public Player FirstPlayer
        {
            get
            {
                return m_PlayerOne;
            }
        }

        public Player PlayerTwo
        {
            get
            {
                return m_PlayerTwo;
            }
        }

        public bool IsPlayerVersusComputer
        {
            get
            {
                return r_IsPlayerVresusComputer;
            }
        }
    }
}
