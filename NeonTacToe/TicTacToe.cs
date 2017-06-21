using System;

namespace NeonTacToe
{
    class TicTacToe
    {
        private string[] m_sMatrixPositions;
        private int[] m_iPlayablePositions;
        private int m_iNumberOfTurns;

		public TicTacToe(string[] sMatrixPositions)
		{
			this.m_sMatrixPositions = sMatrixPositions;
			this.m_iPlayablePositions = new int[9] { 0, 0, 0, 0, 0, 0, 0, 0, 0 };
            this.m_iNumberOfTurns = 0;
		}

        public int INumberOfTurns
        {
            get
            {
                return m_iNumberOfTurns;
            }

			set
			{
				m_iNumberOfTurns = value;
			}
        }

        public string[] SMatrixPositions
        {
            get
            {
                return m_sMatrixPositions;
            }

            set
            {
                m_sMatrixPositions = value;
            }
        }

		public int[] IPlayablePositions
		{
			get
			{
				return m_iPlayablePositions;
			}

			set
			{
				m_iPlayablePositions = value;
			}
		}

        public bool VerifyGame()
        {
            INumberOfTurns++;
            int iWinnerPosition = -1;
			if ((SMatrixPositions[0] == SMatrixPositions[1] && SMatrixPositions[1] == SMatrixPositions[2])
			|| (SMatrixPositions[0] == SMatrixPositions[4] && SMatrixPositions[4] == SMatrixPositions[8])
			|| (SMatrixPositions[0] == SMatrixPositions[3] && SMatrixPositions[3] == SMatrixPositions[6]))
			{
				iWinnerPosition = 0;
			}
			else if (SMatrixPositions[1] == SMatrixPositions[4] && SMatrixPositions[4] == SMatrixPositions[7])
			{
				iWinnerPosition = 1;
			}
			else if ((SMatrixPositions[2] == SMatrixPositions[4] && SMatrixPositions[4] == SMatrixPositions[6])
					|| (SMatrixPositions[2] == SMatrixPositions[5] && SMatrixPositions[5] == SMatrixPositions[8]))
			{
				iWinnerPosition = 2;
			}
			else if (SMatrixPositions[3] == SMatrixPositions[4] && SMatrixPositions[4] == SMatrixPositions[5])
			{
				iWinnerPosition = 3;
			}
			else if (SMatrixPositions[6] == SMatrixPositions[7] && SMatrixPositions[7] == SMatrixPositions[8])
			{
				iWinnerPosition = 6;
			}

            try
            {
				if (SMatrixPositions[iWinnerPosition] == "X")
				{
					Console.WriteLine("Player 1 wins the game!");
					return false;
				}
				else if (SMatrixPositions[iWinnerPosition] == "O")
				{
					Console.WriteLine("Player 2 wins the game!");
					return false;
				}
            }
            catch (Exception ex)
            {
                if (INumberOfTurns == 9)
                {
					Console.WriteLine("It's a draw!");
					return false;
                }
            }

            return true;
        }

        public void GetInputFirstPlayer()
        {
            while (true)
            {
				Console.WriteLine("First player, choose your position [1 - 9]");
				int iInputInteger;
				string sUserInput = Console.ReadLine();
				bool bIsActionValid = int.TryParse(sUserInput, out iInputInteger);

				try
                {
					if (bIsActionValid && IPlayablePositions[iInputInteger - 1] == 0)
					{
						IPlayablePositions[iInputInteger - 1] = 1;
						break;
					}
                    else
                    {
                        Console.WriteLine("Ops. You typed something strange. Try again.");
                    }
                }
                catch (Exception e) {
                    Console.WriteLine("Ops. You typed something strange. Try again.");
				}

            }
        }

		public void GetInputSecondPlayer()
		{
			while (true)
			{
				Console.WriteLine("Second player, choose your position [1 - 9]");
				int iInputInteger;
				string sUserInput = Console.ReadLine();
				bool bIsActionValid = int.TryParse(sUserInput, out iInputInteger);

				try
				{
					if (bIsActionValid && IPlayablePositions[iInputInteger - 1] == 0)
					{
						IPlayablePositions[iInputInteger - 1] = 2;
						break;
					}
					else
					{
						Console.WriteLine("Ops. You typed something strange. Try again.");
					}
				}
				catch (Exception e)
				{
					Console.WriteLine("Ops. You typed something strange. Try again.");
				}

			}
		}

        public void ShowMatrix()
        {
            for (int i = 0; i < IPlayablePositions.Length; i++)
            {
                if (IPlayablePositions[i] == 1)
                {
                    SMatrixPositions[i] = "X";
                }
                else if (IPlayablePositions[i] == 2)
                {
                    SMatrixPositions[i] = "O";
                }
            }
            string[,] sMatrixTacToe = {
                { " ------ ", " ------ ", " ------ " },
                { "|      |", "|      |", "|      |" },
                { $"|   { SMatrixPositions[0] }  |", $"|   { SMatrixPositions[1] }  |", $"|   { SMatrixPositions[2] }  |" },
                { "|      |", "|      |", "|      |" },
                { " ------ ", " ------ ", " ------ " },
                { " ------ ", " ------ ", " ------ " },
                { "|      |", "|      |", "|      |" },
                { $"|   { SMatrixPositions[3] }  |", $"|   { SMatrixPositions[4] }  |", $"|   { SMatrixPositions[5] }  |" },
                { "|      |", "|      |", "|      |" },
                { " ------ ", " ------ ", " ------ " },
                { " ------ ", " ------ ", " ------ " },
                { "|      |", "|      |", "|      |" },
                { $"|   { SMatrixPositions[6] }  |", $"|   { SMatrixPositions[7] }  |", $"|   { SMatrixPositions[8] }  |" },
                { "|      |", "|      |", "|      |" },
                { " ------ ", " ------ ", " ------ " }
            };

            int iCounter = 1;

            Console.Clear();
            foreach (string row in sMatrixTacToe)
            {
                if (iCounter % 3 == 0)
                {
                    Console.WriteLine(row);
                }
                else
                {
                    Console.Write(row);
                }

                iCounter++;
            }
        }
    }
}
