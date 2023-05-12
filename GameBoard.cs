using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ex02.ConsoleUtils;

namespace Reversed_TicTacToe_For_Console
{
    public class GameBoard
    {
        private int m_AmountOfMarkedBoardCells;
        private int m_BoardSize;
        public char[,] m_GameBoard;

        public GameBoard(int i_BoardSize)
        {
            m_AmountOfMarkedBoardCells = 0;
            m_BoardSize = i_BoardSize;
            m_GameBoard = new char[m_BoardSize, m_BoardSize];
            gameBoardInitialization();
        }

        public int AmountOfMarkedBoardCells
        {
            get
            {
                return m_AmountOfMarkedBoardCells;
            }
            set
            {
                m_AmountOfMarkedBoardCells = value;
            }
        }

        public int BoardSize
        {
            get
            {
                return m_BoardSize;
            }
            set
            {
                m_BoardSize = value;
            }
        }

        private void gameBoardInitialization()
        {
            for (int row = 0; row < m_BoardSize; row++)
            {
                for (int col = 0; col < m_BoardSize; col++)
                {
                    m_GameBoard[row, col] = ' ';
                }
            }
        }

        public void PrintBoard()
        {
            StringBuilder boardBuilder = new StringBuilder();

            // Print first row of numbers
            boardBuilder.Append("  ");
            for (int colNum = 0; colNum < m_BoardSize; colNum++)
            {
                boardBuilder.Append($"{colNum + 1}   ");
            }
            boardBuilder.AppendLine();

            // Print each row
            for (int rowNum = 0; rowNum < m_BoardSize; rowNum++)
            {
                boardBuilder.Append($"{rowNum + 1}|");
                for (int colNum = 0; colNum < m_BoardSize; colNum++)
                {
                    boardBuilder.Append($" {GetCellValue(rowNum, colNum)} |");
                }
                boardBuilder.AppendLine();

                boardBuilder.Append(" ");
                for (int colNum = 0; colNum < ((m_BoardSize) * 4) + 1; colNum++)
                {
                    boardBuilder.Append("=");
                }
                boardBuilder.AppendLine();
            }

            // Print the built board string
            Console.WriteLine(boardBuilder.ToString());
        }

        public char GetCellValue(int i_Row, int i_Col)
        {
            return m_GameBoard[i_Row, i_Col];
        }
    }
}
