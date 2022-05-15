namespace Checkers.Engine
{
    public class Matrix
    {
        private int[,] _matrix;

        /// <summary>
        ///  Init and fill matrix
        /// </summary>
        public Matrix()
        {
            this._matrix = new int[8, 8] // [rows,columns]
            {
                {0, 2, 0, 2, 0, 2, 0, 2},
                {2, 0, 2, 0, 2, 0, 2, 0},
                {0, 2, 0, 2, 0, 2, 0, 2},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {0, 0, 0, 0, 0, 0, 0, 0},
                {1, 0, 1, 0, 1, 0, 1, 0},
                {0, 1, 0, 1, 0, 1, 0, 1},
                {1, 0, 1, 0, 1, 0, 1, 0}
            };
        }

        /// <summary>
        /// Returns available turn positions for specified piece
        /// </summary>
        /// <param name="r">row</param>
        /// <param name="c">column</param>
        public Position[] GetAvailablePositions(int r, int c)
        {
            // detect type
            return null;
        }
        
    }
}
