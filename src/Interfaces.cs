using System;
using System.Collections.Generic;
using System.Text;

namespace thomas
{
    public interface IGame
    {
        void Setup();
        void Play();
        void Display();
        bool HasEnded();
    }

    public interface IAlgorithm
    {
        double Evaluate();
    }

    public interface IPlayer
    {

    }
}
