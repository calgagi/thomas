using System;
using System.Collections.Generic;
using System.Text;

namespace thomas.Chess
{
    /// <summary>
    /// A descriptor used to determine what color a piece is.
    /// </summary>
    public enum PieceColor
    {
        WHITE = 0,
        BLACK = 1,
        NOCOLOR = 2
    };

    public abstract class Piece
    {
        private readonly PieceColor m_color;
        private bool m_hasMoved;
        private readonly bool m_infiniteDistance;

        /// <summary>
        /// Takes in an PieceColor and 
        /// </summary>
        public Piece(PieceColor color, bool infiniteDistance)
        {
            m_color = color;
            m_hasMoved = false;

            return;
        }

        /// <summary>
        /// Returns what color the piece is.
        /// </summary>
        public PieceColor GetColor()
        {
            return m_color;
        }

        /// <summary>
        /// Returns whether or not the piece has moved yet (useful for castling, en passant, etc.)
        /// </summary>
        /// <returns></returns>
        public bool HasMoved()
        {
            return m_hasMoved;
        }

        /// <summary>
        /// Sets the piece to have moved.
        /// </summary>
        public void Move()
        {
            m_hasMoved = true;
            return;
        }

        /// <summary>
        /// Returns whether or not the piece can move infinitely in 1 turn.
        /// </summary>
        /// <returns></returns>
        public bool HasInfiniteDistance()
        {
            return m_infiniteDistance;
        }

        /// <summary>
        /// Returns an array of delta coordinates (r, c) that describe how a piece can move.
        /// </summary>
        public abstract int[,] GetMoveList();
    }

    public class King : Piece
    {
        public King(PieceColor color) : base(color, false)
        {
        }

        public static int[,] MoveList = new int[,] { { 0, 1 }, { 0, -1 }, { 1, 0 }, { 1, -1 }, { 1, 1 }, { -1, 0 }, { -1, -1 }, { -1, 1 } };

        public override int[,] GetMoveList()
        {
            return MoveList;
        }
    }

    public class Queen : Piece
    {
        public Queen(PieceColor color) : base(color, true)
        {
        }

        public static int[,] MoveList = new int[,] { { 0, 1 }, { 0, -1 }, { 1, 0 }, { 1, -1 }, { 1, 1 }, { -1, 0 }, { -1, -1 }, { -1, 1 } };

        public override int[,] GetMoveList()
        {
            return MoveList;
        }
    }

    public class Rook : Piece
    {
        public Rook(PieceColor color) : base(color, true)
        {
        }

        public static int[,] MoveList = new int[,] { { 1, 0 }, { -1, 0 }, { 0, -1 }, { 0, 1 } };

        public override int[,] GetMoveList()
        {
            return MoveList;
        }
    }

    public class Bishop : Piece
    {
        public Bishop(PieceColor color) : base(color, true)
        {
        }

        public static int[,] MoveList = new int[,] { { 1, -1 }, { 1, 1 }, { -1, -1 }, { -1, 1 } };

        public override int[,] GetMoveList()
        {
            return MoveList;
        }
    }

    public class Knight : Piece
    {
        public Knight(PieceColor color) : base(color, false)
        {
        }

        public static int[,] MoveList = new int[,] { { 2, -1 }, { 2, 1 }, { -2, -1 }, { -2, 1 }, { 1, -2 }, { 1, 2 }, { -1, -2 }, { -1, 2 } };

        public override int[,] GetMoveList()
        {
            return MoveList;
        }
    }

    public class Pawn : Piece
    {
        public Pawn(PieceColor color) : base(color, false)
        {
        }

        /// <summary>
        /// The Pawn's move list should be implemented by Board since all of Pawn's moves are determined by the Board state.
        /// </summary>
        public override int[,] GetMoveList()
        {
            return null;
        }
    }

    public class Empty : Piece
    {
        public Empty() : base(PieceColor.NOCOLOR, false)
        {
        }

        public override int[,] GetMoveList()
        {
            return null;
        }
    }
}
