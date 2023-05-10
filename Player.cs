using System;
using System.Text;

namespace B23_Ex02_LiorRoife_206257826_MaorZemach_206273690
{
   public class Player
    {
        private readonly char m_PlayerSymbol;
        private readonly string m_PlayerName;
        private int m_Score;

        public Player(char i_Symbol, string i_Name)
        {
            m_PlayerSymbol = i_Symbol;
            m_PlayerName = i_Name;
            m_Score = 0;
        }

        public char Symbol
        {
            get
            {
                return m_PlayerSymbol;
            }
        }

        public string Name
        {
            get
            {
                return m_PlayerName;
            }
        }

        public int Score
        {
            get
            {
                return m_Score;
            }
            set
            {
                m_Score = value;
            }
        }
    }
}
