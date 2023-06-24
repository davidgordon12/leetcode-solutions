public class Solution {
    public bool IsValidSudoku(char[][] board) {
        var elements = new HashSet<char>(9);
        
        // check each row
        for(int row = 0; row < 9; row++) {
            elements.Clear();
            for(int col = 0; col < 9; col++) {
                if(board[row][col] != '.')
                {
                    if(elements.Contains(board[row][col])) 
                        return false;
                    else
                        elements.Add(board[row][col]);
                }
            }
        }

        // check each column
        for(int col = 0; col < 9; col++) {
            elements.Clear();
            for(int row = 0; row < 9; row++) {
                if(board[row][col] != '.')
                {
                    if(elements.Contains(board[row][col])) 
                        return false;
                    else
                        elements.Add(board[row][col]);
                }
            }
        }

        // check each 3x3 grid
        int x = 0, y = 0;
        while (x < 9 && y < 9) {
            elements.Clear();
            for(int row = 0 + y; row < 3 + y; row++) {
                for(int col = 0 + x; col < 3 + x; col++) {
                    if(board[row][col] != '.')
                    {
                        if(elements.Contains(board[row][col])) 
                            return false;
                        else
                            elements.Add(board[row][col]);
                    }
                }
            }

            // offset our row by 3. if we reach the last row, offset the column by 3, and reset y
            y += 3;
            if(y >= 8) 
            {
                x += 3;
                y = 0;
            }
        }

        return true;
    }
}