using System;
using System.Collections.Generic;
using System.Text;

namespace thomas.Chess
{
    class Board
    {
        private readonly int m_rows = 8;
        private readonly int m_cols = 8;
        private Piece[,] m_pieces;

        public Board()
        {
            m_pieces = new Piece[m_rows, m_cols];
        }

        public Board(Piece[,] pieces)
        {
            m_pieces = pieces;
        }

        private bool IsValidSpot(int row, int col)
        {
            return row < m_rows && col < m_cols && row >= 0 && col >= 0;
        }

        /// <summary>
        /// Moves Piece at [srcRow, srcCol] to [destRow, destCol]. Returns true if successful.
        /// </summary>
        public bool Move(int srcRow, int srcCol, int destRow, int destCol)
        {
            if (!IsValidSpot(srcRow, srcCol) || !IsValidSpot(destRow, destCol))
                return false;

            m_pieces[destRow, destCol] = m_pieces[srcRow, srcCol];
            m_pieces[srcRow, srcCol] = new Empty();

            return true;
        }
        
        private bool IsOccupied(int row, int col)
        {
            return !IsValidSpot(row, col) || !m_pieces[row, col].IsEmpty();
        }

        public List<Tuple<int,int>> GetMoves(int row, int col)
        {
            List<Tuple<int, int>> offsets = new List<Tuple<int, int>>();
            if (!IsOccupied(row, col))
                return offsets;

            int[,] moveDirections = m_pieces[row, col].GetMoveDirections();

            for (int i = 0; i < moveDirections.Length; i++)
            {
                
            }

            return offsets;
        }

        public Board Copy()
        {
            Board boardToReturn = new Board();
            

            return boardToReturn;
        }
        
        /// <summary>
        /// Generates all possible board states for a certain color
        /// </summary>
        public List<Board> GenerateAllBoards(int color)
        {
            List<Board> generatedBoards = new List<Board>();

            for (int row = 0; row < m_rows; row++)
            {
                for (int col = 0; col < m_cols; col++)
                {
                    if (m_pieces[row, col].GetColor() == color)
                    {
                        foreach (Tuple<int, int> location in GetMoves(row, col))
                        {
                            Board copy = this;
                        }
                    }
                }
            }

            return generatedBoards;
        }
    }
}
