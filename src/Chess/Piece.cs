using System;
using System.Collections.Generic;
using System.Text;

namespace thomas.Chess
{
    public enum PieceType
    {
        Empty = 0x0,
        Pawn = 0x1,
        Knight = 0x2,
        Bishop = 0x4,
        Rook = 0x8,
        Queen = 0x10,
        King = 0x20
    };

    class Piece
    {
        private readonly int m_color;
        private bool m_hasMoved;

        /// <summary>
        /// Takes in an PieceType and int of what color the piece is (0 = white, 1 = black)
        /// </summary>
        protected Piece(PieceType type, int color)
        {
            m_color = color;
            m_hasMoved = false;
            m_type = type;
        }

        PieceType m_type;

        public int GetColor()
        {
            return m_color;
        }

        public bool HasMoved()
        {
            return m_hasMoved;
        }

        public void Move()
        {
            m_hasMoved = true;
            return;
        }

        public PieceType Type()
        {
            return m_type;
        }
    }
}
