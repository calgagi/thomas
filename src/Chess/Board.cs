using System;
using System.Collections.Generic;
using System.Text;

namespace thomas.Chess
{
    class Board
    {
        private Piece[,] m_pieces;
        public Board(int rows, int cols)
        {
            m_pieces = new Empty[8, 8];
        }
    }
}
