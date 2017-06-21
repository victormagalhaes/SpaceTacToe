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

        //private static void ShowMatrix(string[,] sMatrixTicTacToe)
        //{
        //    int iCounter = 1;

        //    Console.Clear();
        //    foreach (string row in sMatrixTicTacToe)
        //    {
        //        if (iCounter % 3 == 0)
        //        {
        //            Console.WriteLine(row);
        //        }
        //        else
        //        {
        //            Console.Write(row);
        //        }

        //        iCounter++;
        //    }
        //}

        //private static string[,] CreateMatrix(string[] sMatrixByPosition)
        //{
        //    string[,] sMatrixTicTacToe = {
        //        { " ------ ", " ------ ", " ------ " },
        //        { "|      |", "|      |", "|      |" },
        //        { $"|   { sMatrixByPosition[0] }  |", $"|   { sMatrixByPosition[1] }  |", $"|   { sMatrixByPosition[2] }  |" },
        //        { "|      |", "|      |", "|      |" },
        //        { " ------ ", " ------ ", " ------ " },
        //        { " ------ ", " ------ ", " ------ " },
        //        { "|      |", "|      |", "|      |" },
        //        { $"|   { sMatrixByPosition[3] }  |", $"|   { sMatrixByPosition[4] }  |", $"|   { sMatrixByPosition[5] }  |" },
        //        { "|      |", "|      |", "|      |" },
        //        { " ------ ", " ------ ", " ------ " },
        //        { " ------ ", " ------ ", " ------ " },
        //        { "|      |", "|      |", "|      |" },
        //        { $"|   { sMatrixByPosition[6] }  |", $"|   { sMatrixByPosition[7] }  |", $"|   { sMatrixByPosition[8] }  |" },
        //        { "|      |", "|      |", "|      |" },
        //        { " ------ ", " ------ ", " ------ " }
        //    };

        //    return sMatrixTicTacToe;
        //}
    }
}
