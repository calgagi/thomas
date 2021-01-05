using System;

namespace thomas
{
    class Program
    {
        static void Main(string[] args)
        {
            IGame game = new Chess.Game();

            while (!game.HasEnded())
            {
                game.Play();
                game.Display();
            }

            return;
        }
    }
}
