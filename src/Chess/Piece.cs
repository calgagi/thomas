using System;
using System.Collections.Generic;
using System.Text;

namespace thomas.Chess
{
    public enum PieceType
    {
        EMPTY = 0,
        PAWN = 1,
        KNIGHT = 2,
        BISHOP = 3,
        ROOK = 4,
        QUEEN = 5,
        KING = 6
    };

    public enum PieceColor
    {
        WHITE = 1,
        BLACK = 2
    };

    class Piece
    {
        private readonly PieceColor m_color;
        private bool m_hasMoved;
        private PieceType m_type;

        /// <summary>
        /// Takes in an PieceType and int of what color the piece is (0 = white, 1 = black)
        /// </summary>
        public Piece(PieceType type, PieceColor color)
        {
            m_color = color;
            m_hasMoved = false;
            m_type = type;

            return;
        }

        public PieceColor GetColor()
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

    class PieceService
    {
        private Piece[,,] m_pieces;
        private bool m_hasInited = false;
        private int[,,] m_moves;

        public void Init()
        {
            if (m_hasInited)
                return;

            GeneratePieces();
            GenerateMoves();

            m_hasInited = true;
            return;
        }

        public void GeneratePieces()
        {
            PieceType[] pieceTypes = (PieceType[])Enum.GetValues(typeof(PieceType));
            PieceColor[] pieceColors = (PieceColor[])Enum.GetValues(typeof(PieceColor));

            m_pieces = new Piece[pieceTypes.Length, pieceColors.Length, 2];

            for (int i = 0; i < pieceTypes.Length; i++)
            {
                for (int j = 0; j < pieceColors.Length; j++)
                {
                    m_pieces[i, j, 0] = new Piece(pieceTypes[i], pieceColors[j]);
                    m_pieces[i, j, 1] = new Piece(pieceTypes[i], pieceColors[j]);
                    m_pieces[i, j, 1].Move();
                }
            }

            return;
        }

        public void 

        public Piece Piece(PieceType type, PieceColor color, bool moved)
        {
            Init();
            return m_pieces[(int)type, (int)color, (moved ? 1 : 0)];
        }

        public int[,] GetMoveList(PieceType type)
        {

        }
    }
}
