using System;
using System.Collections.Generic;
using System.Text;

namespace thomas.Chess
{
    abstract class Piece
    {
        protected int[,] m_moveDirections;
        private bool m_color;
        private bool m_hasMoved;
        private bool m_moveInDirectionForever;

        // <summary>
        // Takes in bool of what color the piece is (false = white, true = black).
        // </summary>
        public Piece(bool color, bool moveInDirectionForever)
        {
            m_color = color;
            m_hasMoved = false;
            m_moveInDirectionForever = moveInDirectionForever;
        }

        // <summary>
        // Returns 2D array of offsets in directions that piece can move.
        // </summary>
        public int[,] GetMoveDirections()
        {
            return m_moveDirections;
        }

        public bool GetColor()
        {
            return m_color;
        }

        public bool HasMoved()
        {
            return m_hasMoved;
        }

        public bool CanMoveInDirectionForever()
        {
            return m_moveInDirectionForever;
        }
    }

    class Empty : Piece
    {
        public Empty() : base(false, false)
        {
            m_moveDirections = null;
        }
    }

    class King : Piece
    {
        public King(bool color) : base(color, false)
        {
            // Note: we don't keep track of castling here
            m_moveDirections = new int[,] { { 1, 1 }, { -1, 1 }, { -1, -1 }, { 1, -1 }, { -1, 0 }, { 1, 0 }, { 0, -1 }, { 0, 1 } };
        }
    }
    
    class Queen : Piece
    {
        public Queen(bool color) : base(color, true)
        {
            m_moveDirections = new int[,] { { 1, 1 }, { -1, 1 }, { -1, -1 }, { 1, -1 }, { -1, 0 }, { 1, 0 }, { 0, -1 }, { 0, 1 } };
        }
    }

    class Rook : Piece
    {
        public Rook(bool color) : base(color, true)
        {
            // Note: we don't keep track of castling here
            m_moveDirections = new int[,] { { -1, 0 }, { 1, 0 }, { 0, -1 }, { 0, 1 } };
        }
    }

    class Bishop : Piece
    {
        public Bishop(bool color) : base(color, true)
        {
            m_moveDirections = new int[,] { { 1, 1 }, { -1, 1 }, { -1, -1 }, { 1, -1 } };
        }
    }

    class Knight : Piece
    {
        public Knight(bool color) : base(color, false)
        {
            m_moveDirections = new int[,] { { 2, 1 }, { -2, 1 }, { -2, -1 }, { 2, -1 }, { -1, 2 }, { 1, 2 }, { 1, -2 }, { -1, -2 } };
        }
    }

    class Pawn : Piece
    {
        public Pawn(bool color) : base(color, false)
        {
            // Note: we don't keep track of en passant, first move 2-space move, or capture moves here
            m_moveDirections = color ? new int[,] { { 1, 0 } } : new int[,] { { 1, 0 } };
        }
    }
}
