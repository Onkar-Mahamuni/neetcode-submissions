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
                int i = 0; 
                int ie = 0; 
                int j = 0; 
                int je = 0;

            if (k == 0){
                i = 0; 
                ie = 2; 
                j = 0; 
                je = 2;      
            }
            if (k == 1){
                i = 0; 
                ie = 2; 
                j = 3; 
                je = 5;      
            }
            if (k == 2){
                i = 0; 
                ie = 2; 
                j = 6; 
                je = 8;      
            }
            if (k == 3){
                i = 3; 
                ie = 5; 
                j = 0; 
                je = 2;      
            }
            if (k == 4){
                i = 3; 
                ie = 5; 
                j = 3; 
                je = 5;      
            }
            if (k == 5){
                i = 3; 
                ie = 5; 
                j = 6; 
                je = 8;      
            }
            if (k == 6){
                i = 6; 
                ie = 8; 
                j = 0; 
                je = 2;      
            }
            if (k == 7){
                i = 6; 
                ie = 8; 
                j = 3; 
                je = 5;      
            }
            if (k == 8){
                i = 6; 
                ie = 8; 
                j = 6; 
                je = 8;      
            }
            for ( ; i <= ie; i++)
            {
                for (j = (k % 3) * 3; j <= je; j++)
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
