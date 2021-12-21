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
        WHITE,
        BLACK,
        NOCOLOR
    };

    public enum PieceType
    {
        PAWN,
        KNIGHT,
        BISHOP,
        ROOK,
        QUEEN,
        KING
    };

    public class Piece
    {
        private int m_row;
        private int m_col;

        public readonly PieceColor Color;
        public readonly PieceType Type;

        public bool HasMoved { get; private set; } = false;

        /// <summary>
        /// Takes in an PieceColor and 
        /// </summary>
        public Piece(PieceColor color, PieceType type, int row, int col)
        {
            Color = color;
            Type = type;
            m_row = row;
            m_col = col;
        }

        public int Column
        {
            get 
            { 
                return m_col; 
            }
            set 
            {
                m_col = value;
                HasMoved = true;
            }
        }

        public int Row
        {
            get
            {
                return m_row;
            }
            set
            {
                m_row = value;
                HasMoved = true;
            }
        }

        public static char GetDisplayCharacter(Piece piece)
        {
            switch (piece?.Type)
            {
                case PieceType.PAWN:
                    return 'P';
                case PieceType.KNIGHT:
                    return 'N';
                case PieceType.BISHOP:
                    return 'B';
                case PieceType.ROOK:
                    return 'R';
                case PieceType.QUEEN:
                    return 'Q';
                case PieceType.KING:
                    return 'K';
                default:
                    return ' ';
            }
        }
    }
}
