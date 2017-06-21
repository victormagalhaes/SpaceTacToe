using System;

namespace NeonTacToe
{
    class Program
    {
        static void Main(string[] args)
        {
            TicTacToe tGame = new TicTacToe(sMatrixPositions: new string[] { "1", "2", "3", "4", "5", "6", "7", "8", "9" });
            bool bTheGameIsNotOver = true;

            tGame.ShowMatrix();

            while (bTheGameIsNotOver)
            {
                tGame.GetInputFirstPlayer();
                tGame.ShowMatrix();
                bTheGameIsNotOver = tGame.VerifyGame();

                if (bTheGameIsNotOver)
                {
					tGame.GetInputSecondPlayer();
					tGame.ShowMatrix();
					bTheGameIsNotOver = tGame.VerifyGame();
                }
            }
        }
    }
}
