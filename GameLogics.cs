using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reversed_TicTacToe_For_Console
{
    public class GameLogics
    {
        private const int k_MinimumSizeOfBoard = 3;
        private const int k_MaximumSizeOfBoard = 9;
        public const char k_PlayerOneSymbol = 'X';
        public const char k_PlayerTwoSymbol = 'O';
        private Player m_PlayerOne;
        private Player m_PlayerTwo;
        private GameBoard m_CurrentGameBoard;
        private readonly bool r_IsPlayerVsAI;
        private int m_PlayerTurn;
        public GameLogics(int i_BoardSize, bool i_IsPlayerVsAI)
        {
            m_PlayerOne = new Player(k_PlayerOneSymbol);
            m_PlayerTwo = new Player(k_PlayerTwoSymbol);
            m_CurrentGameBoard = new GameBoard(i_BoardSize);
            r_IsPlayerVsAI = i_IsPlayerVsAI;
            m_PlayerTurn = 1;
        }

        public static bool CheckGameBoardSize(int i_BoardSize)
        {
            bool isTheSizeValid = false;
            if (i_BoardSize >= k_MinimumSizeOfBoard && i_BoardSize <= k_MaximumSizeOfBoard)
            {
                isTheSizeValid = true;
            }

            return isTheSizeValid;
        }

        public bool CheckIsCellEmpty(int i_row, int i_col)
        {
            bool isCellEmpty = false;

            if (Board.TheGameBoard[i_row, i_col]==' ')
            {
                isCellEmpty = true;
            }

            return isCellEmpty;
        }

        public Player PlayerOne
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

        public bool IsPlayerVsAI
        {
            get
            {
                return r_IsPlayerVsAI;
            }
        }

        public GameBoard Board
        {
            get
            {
                return m_CurrentGameBoard;
            }
        }



        //CheckWin :
        //CheckHorizontal  
        public bool CheckHorizontal(ref int io_numOfPlayer)
        {
            bool isPlayerWon = false;
            int playerOneCounter = 0;
            int playerTwoCounter = 0;

            for (int row = 0; row < Board.BoardSize; row++)
            {
                for (int col = 0; col < Board.BoardSize; col++)
                {
                    if (Board.TheGameBoard[col, row] == PlayerOne.PlayerSymbol)
                    {
                        playerOneCounter++;
                    }
                    if (Board.TheGameBoard[col, row] == PlayerTwo.PlayerSymbol)
                    {
                        playerTwoCounter++;
                    }
                }
                if (playerOneCounter == Board.BoardSize || playerTwoCounter == Board.BoardSize)
                {
                    if(playerOneCounter== Board.BoardSize)
                    {
                        io_numOfPlayer = 2;
                    }
                    else
                    {
                        io_numOfPlayer = 1;
                    }
                    isPlayerWon = true;
                }
                playerOneCounter = 0;
                playerTwoCounter = 0;
            }

            return isPlayerWon;
        }
        //CheckDiagonal
        public bool CheckDiagonal(ref int io_numOfPlayerWon)
        {
            bool isPlayerWon = false;
            int col = Board.BoardSize - 1;
            int playerOneCounter = 0;
            int playerTwoCounter = 0;

            for (int i = 0; i < Board.BoardSize; i++)
            {
                if (Board.TheGameBoard[i, i] == PlayerOne.PlayerSymbol)
                {
                    playerOneCounter++;
                }
                if (Board.TheGameBoard[i, i] == PlayerTwo.PlayerSymbol)
                {
                    playerTwoCounter++;
                }
                if (playerOneCounter == Board.BoardSize || playerTwoCounter == Board.BoardSize)
                {
                   if(playerOneCounter == Board.BoardSize)
                   {
                        io_numOfPlayerWon = 2;
                   }
                   else
                   {
                        io_numOfPlayerWon = 1;
                   }
                    isPlayerWon = true;
                }
            }
            playerOneCounter = 0;
            playerTwoCounter = 0;
            
            for (int row = 0; row < Board.BoardSize; row++)
            {
                if (Board.TheGameBoard[row, col] == PlayerOne.PlayerSymbol)
                {
                    playerOneCounter++;
                }
                if (Board.TheGameBoard[row, col] == PlayerTwo.PlayerSymbol)
                {
                    playerTwoCounter++;
                }

                col--;
                if (playerOneCounter == Board.BoardSize || playerTwoCounter == Board.BoardSize)
                {
                    if (playerOneCounter == Board.BoardSize)
                    {
                        io_numOfPlayerWon = 2;
                    }
                    else
                    {
                        io_numOfPlayerWon = 1;
                    }
                    isPlayerWon = true;
                }
            }

            return isPlayerWon;
        }
        //CheckVertical
        public bool CheckVertical(ref int io_numOfPlayerWon)
        {
            bool isPlayerWon = false;
            int playerOneCounter = 0;
            int playerTwoCounter = 0;

            for (int row = 0; row < Board.BoardSize; row++)
            {
                for (int col = 0; col < Board.BoardSize; col++)
                {
                    if (Board.TheGameBoard[row, col] == PlayerOne.PlayerSymbol)
                    {
                        playerOneCounter++;
                    }
                    if (Board.TheGameBoard[row, col] == PlayerTwo.PlayerSymbol)
                    {
                        playerTwoCounter++;
                    }
                }
                if (playerOneCounter == Board.BoardSize || playerTwoCounter == Board.BoardSize)
                {
                  if(playerOneCounter == Board.BoardSize)
                  {
                        io_numOfPlayerWon = 2;
                  }
                  else
                  {
                        io_numOfPlayerWon = 1;
                  }
                    isPlayerWon = true;
                }
                playerOneCounter = 0;
                playerTwoCounter = 0;
            }

            return isPlayerWon;
        }

        //IsTheBoardFull:
        public bool CheckIfDraw()
        {
            bool draw = true;
            for (int rowIndex = 0; rowIndex < Board.BoardSize; rowIndex++)
            {
                for (int colIndex = 0; colIndex < Board.BoardSize; colIndex++)
                {
                    if (Board.TheGameBoard[colIndex, rowIndex] == ' ')
                    {
                        draw = false;
                    }
                }
            }
            return draw;
        }
        //(IsTie)

        //IsEndGame:
        //(Tie or Win Or Q)

        //UpdateBoardAfterTurn

        //IncreaseWinnerScore
    }
}