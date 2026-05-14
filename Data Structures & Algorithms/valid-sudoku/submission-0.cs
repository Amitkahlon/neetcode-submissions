public class Solution {
        public bool IsValidSudoku(char[][] board)
    {
        bool[,,] threeSqures = new bool[3, 3, 9];
        bool[,] rows = new bool[9, 9];
        bool[,] colulms = new bool[9, 9];

        for (int i = 0; i < 9; i++)
        {
            for (int j = 0; j < 9; j++)
            {
                char c = board[i][j];
                if (c == '.') continue;

                var dig = c - '0';
                dig--; // digits are 1-9 and array is 0-8


                if (rows[i, dig]) return false;
                if (colulms[j, dig]) return false;

                int squareRow = i / 3;
                int squareColum = j / 3;

                if (threeSqures[squareRow, squareColum, dig]) return false;

                threeSqures[squareRow, squareColum, dig] = true;
                rows[i, dig] = true;
                colulms[j, dig] = true;
            }
        }

        return true;
    }
}
