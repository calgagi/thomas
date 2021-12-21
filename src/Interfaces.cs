using System;
using System.Collections.Generic;
using System.Text;

namespace thomas
{
    public interface IBoard
    {
        IEnumerable<IBoard> GenerateNextBoards();
        void Display();
    }

    public interface IPlayer
    {
        IBoard PlayMove(IBoard board);
        bool HasWon(IBoard board);
    }
}
