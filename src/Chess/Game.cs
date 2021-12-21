using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace thomas.Chess
{
    class Game
    {
        private IBoard m_board;
        private List<IPlayer> m_players;

        public Game()
        {
            m_board = new Board();
            m_board.Display();
        }

        public Game(IBoard board, IPlayer[] players)
        {
            m_players = new List<IPlayer>(players);
            m_board = board;
            Play();
        }

        void Play()
        {
            int playerIndex = 0;
            while (!m_players[playerIndex].HasWon(m_board))
            {
                playerIndex = (playerIndex + 1) % m_players.Count;
                m_board = m_players[playerIndex].PlayMove(m_board);
            }
        }
    }
}
