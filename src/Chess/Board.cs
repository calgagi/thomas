using System;
using System.Collections.Generic;
using System.Text;

namespace thomas.Chess
{
    class Board
    {
        public int Rows { get; private set; }
        public int Cols { get; private set; }

        private Piece[,] m_pieces;

        public Board(int rows, int cols)
        {
            m_pieces = new Piece[rows, cols];
            Rows = rows;
            Cols = cols;
        }

        /// <summary>
        /// Initializes the board to the passed in 2D array of Pieces.
        /// </summary>
        public Board(Piece[,] pieces)
        {
            m_pieces = pieces;
            Rows = m_pieces.GetLength(0);
            Cols = m_pieces.GetLength(1);
        }

        private bool IsValidSpot(int row, int col)
        {
            return row < Rows && col < Cols && row >= 0 && col >= 0;
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
            if (!IsValidSpot(row, col))
            {
                throw new Exception("IsOccupied: Not a valid board position to check");
            }
            return !(m_pieces[row, col] is Empty);
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

            for (int row = 0; row < Rows; row++)
            {
                for (int col = 0; col < Cols; col++)
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
