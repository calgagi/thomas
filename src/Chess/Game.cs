using System;
using System.Collections.Generic;
using System.Text;

namespace thomas.Chess
{
    class Game : IGame
    {
        private Board m_board;
        private bool m_hasEnded;
        private bool m_turn;

        void IGame.Setup()
        {
            m_turn = false;
            m_hasEnded = false;
            m_board = new Board(8, 8);

        }

        void IGame.Play()
        {

        }

        void IGame.Display()
        {

        }

        bool IGame.HasEnded()
        {
            return m_hasEnded;
        }
    }
}
