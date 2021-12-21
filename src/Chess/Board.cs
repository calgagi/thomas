using System;
using System.Collections.Generic;
using System.Globalization;
using System.Text;

namespace thomas.Chess
{
    class Board : IBoard
    {
        public readonly int Rows = 8;
        public readonly int Cols = 8;
        private List<Piece> m_pieces = new();

        public Board()
        {
            m_pieces = new(32);

            // Pawns
            for (int i = 0; i < Rows; i++)
            {
                m_pieces.Add(new Piece(PieceColor.WHITE, PieceType.PAWN, 6, i));
                m_pieces.Add(new Piece(PieceColor.BLACK, PieceType.PAWN, 1, i));
            }

            // Rooks
            m_pieces.Add(new Piece(PieceColor.WHITE, PieceType.ROOK, 7, 0));
            m_pieces.Add(new Piece(PieceColor.WHITE, PieceType.ROOK, 7, 7));
            m_pieces.Add(new Piece(PieceColor.BLACK, PieceType.ROOK, 0, 0));
            m_pieces.Add(new Piece(PieceColor.BLACK, PieceType.ROOK, 0, 7));

            // Bishops
            m_pieces.Add(new Piece(PieceColor.WHITE, PieceType.BISHOP, 7, 2));
            m_pieces.Add(new Piece(PieceColor.WHITE, PieceType.BISHOP, 7, 5));
            m_pieces.Add(new Piece(PieceColor.BLACK, PieceType.BISHOP, 0, 2));
            m_pieces.Add(new Piece(PieceColor.BLACK, PieceType.BISHOP, 0, 5));

            // Knights
            m_pieces.Add(new Piece(PieceColor.WHITE, PieceType.KNIGHT, 7, 1));
            m_pieces.Add(new Piece(PieceColor.WHITE, PieceType.KNIGHT, 7, 6));
            m_pieces.Add(new Piece(PieceColor.BLACK, PieceType.KNIGHT, 0, 1));
            m_pieces.Add(new Piece(PieceColor.BLACK, PieceType.KNIGHT, 0, 6));

            // Queens
            m_pieces.Add(new Piece(PieceColor.WHITE, PieceType.QUEEN, 7, 3));
            m_pieces.Add(new Piece(PieceColor.BLACK, PieceType.QUEEN, 0, 3));

            // Kings
            m_pieces.Add(new Piece(PieceColor.WHITE, PieceType.KING, 7, 4));
            m_pieces.Add(new Piece(PieceColor.BLACK, PieceType.KING, 0, 4));
        }

        public void Display()
        {
            Piece[,] pieces = GetBoardArray();
            for (int i = 0; i < Rows; i++)
            {
                for (int j = 0; j < Cols; j++)
                {
                    Console.Write(Piece.GetDisplayCharacter(pieces[i, j]));
                }
                Console.WriteLine();
            }
        }

        private Piece[,] GetBoardArray()
        {
            Piece[,] res = new Piece[Rows, Cols];
            foreach (Piece piece in m_pieces)
            {
                res[piece.Row, piece.Column] = piece;
            }
            return res;
        }

        public IEnumerable<IBoard> GenerateNextBoards()
        {
            return null;
        }
    }
}
