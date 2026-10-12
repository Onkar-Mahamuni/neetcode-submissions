public class Solution {
    public bool IsValidSudoku(char[][] board) {
        HashSet<string> hs = new();

        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if(char.IsDigit(board[i][j]))
                    if(!hs.Add($"{i}:{board[i][j]}"))
                        return false;
            }
        }

        hs = new HashSet<string>();
        for (int i = 0; i < board.Length; i++)
        {
            for (int j = 0; j < board[i].Length; j++)
            {
                if(char.IsDigit(board[i][j]))
                    if(!hs.Add($"{j}:{board[i][j]}"))
                        return false;
            }
        }

        hs = new HashSet<string>();
        for(int k = 0; k < 9; k++){
            int startRow = (k / 3) * 3;
            int startCol = (k % 3) * 3;

            for (int i = startRow ; i < startRow + 3; i++)
            {
                for (int j = startCol ; j < startCol + 3; j++)
                {
                    if(char.IsDigit(board[i][j]))
                        if(!hs.Add($"{k}:{board[i][j]}"))
                            return false;
                }
            }
        }

        return true;
    }
}
