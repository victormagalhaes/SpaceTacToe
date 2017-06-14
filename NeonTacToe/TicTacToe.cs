namespace NeonTacToe
{
    class TicTacToe
    {
        private string[] m_sMatrixPositions;
        private string[,] m_sMatrixTacToe;

        public TicTacToe(string[] sMatrixPositions)
        {
            this.m_sMatrixPositions = sMatrixPositions;
            this.m_sMatrixTacToe = {
                { " ------ ", " ------ ", " ------ " },
                { "|      |", "|      |", "|      |" },
                { $"|   { sMatrixPositions[0] }  |", $"|   { sMatrixPositions[1] }  |", $"|   { sMatrixPositions[2] }  |" },
                { "|      |", "|      |", "|      |" },
                { " ------ ", " ------ ", " ------ " },
                { " ------ ", " ------ ", " ------ " },
                { "|      |", "|      |", "|      |" },
                { $"|   { sMatrixPositions[3] }  |", $"|   { sMatrixPositions[4] }  |", $"|   { sMatrixPositions[5] }  |" },
                { "|      |", "|      |", "|      |" },
                { " ------ ", " ------ ", " ------ " },
                { " ------ ", " ------ ", " ------ " },
                { "|      |", "|      |", "|      |" },
                { $"|   { sMatrixPositions[6] }  |", $"|   { sMatrixPositions[7] }  |", $"|   { sMatrixPositions[8] }  |" },
                { "|      |", "|      |", "|      |" },
                { " ------ ", " ------ ", " ------ " }
            };

            CreateMatrix(SMatrixPositions);
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

        public string[,] SMatrixTacToe
        {
            get
            {
                return m_sMatrixTacToe;
            }

            set
            {
                m_sMatrixTacToe = value;
            }
        }

        public void CreateMatrix(string[] sMatrixByPosition)
        {
            SMatrixTacToe = {
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
        }
    }
}
