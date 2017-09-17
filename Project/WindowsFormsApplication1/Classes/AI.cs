using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApplication1
{
    class AI
    {
        private int Difficulty;
        private Board board;
        public AI()
        {
            Difficulty = 1;
        }

        public AI(int Diff)
        {
            Difficulty = Diff;
        }

        public void SetDifficulty(int Diff)
        {
            Difficulty = Diff;
        }

        public int GetDifficulty()
        {
            return Difficulty;
        }

        public int GetPlayerWinningColumn()
        {
            int MaxCount = 0;
            int WinningIndex = -1;
            #region Checking
            // FOR EACH COLUMN (i)
            for (int i = 0; i <= 7; i++)
            {
                int count = 0;
                // FOR EACH ROW (j) starting from the last row
                for (int j = 7; j >= 0; j--)
                {
                    // Number of Player1.Color in this column

                    //IF : The current cell is equal to Player1.Color => Increment the count 
                    if (board[j, i].Color == board.Player1.Color)
                        count++;

                    // IF : The current cell is equal to Player2.Color => Reset the count
                    else if (board[j, i].Color == board.Player2.Color)
                        count = 0;

                    //IF : The current cell is equal to none occupied cell => End the counting and check MAXCOUNT
                    else
                    {
                        if (MaxCount < count) { MaxCount = count; WinningIndex = i; }
                        break;
                    }

                }
            }
            #endregion
            #region Determining Move
            if (MaxCount <= 2)
                return -1;

            else
            {
                return WinningIndex;
            }
            #endregion
        }
        public int GetWinningColumn()
        {
            int MaxCount = 0;
            int WinningIndex = -1;
            #region Checking
            // FOR EACH COLUMN (i)
            for (int i = 0; i <= 7; i++)
            {
                int count = 0;
                // FOR EACH ROW (j) starting from the last row
                for (int j = 7; j >= 0; j--)
                {
                    // Number of Player1.Color in this column

                    //IF : The current cell is equal to Player1.Color => Increment the count 
                    if (board[j, i].Color == board.Player2.Color)
                        count++;

                    // IF : The current cell is equal to Player2.Color => Reset the count
                    else if (board[j, i].Color == board.Player1.Color)
                        count = 0;

                    //IF : The current cell is equal to none occupied cell => End the counting and check MAXCOUNT
                    else
                    {
                        if (MaxCount < count) { MaxCount = count; WinningIndex = i; }
                        break;
                    }

                }
            }
            #endregion
            #region Determining Move
            if (MaxCount <= 2)
                return -1;

            else
            {
                return WinningIndex;
            }
            #endregion
        }

        public bool isRowFull(int r)
        {
            for (int i = 0; i < 8; i++)
            {
                if (board[r, i].Color == "None")
                    return false;
            }
            return true;
        }


        public int GetPlayerWinningRow()
        {
            // FOREACH : ROW starting from the end of the rows
            for (int i = 7; i >= 0; i--)
            {
                int count = 0;
                int blankindex = -1;
                int lastindex = -1;
                int firstindex = -1;
                bool breakRow = false;
                if (isRowFull(i))
                {
                    continue;
                }
                // FOREACH : COLUMN in the row i
                for (int j = 0; j <= 7; j++)
                {
                    if (count == 2)
                    { breakRow = true; break; }
                    if (board.Player1.Color == board[i, j].Color)
                    {
                        if (firstindex == -1) { firstindex = j; }
                        count++;
                        lastindex = j;
                    }
                    else if (board.Player2.Color == board[i, j].Color)
                        count = 0;
                    else
                    {
                        if (board[i, j % 8].Color != board.Player2.Color)
                            blankindex = j;
                    }

                }

                if (breakRow)
                {
                    if (blankindex != -1)
                    {
                        return blankindex;
                    }
                    else
                    {
                        if (board[i, lastindex + 1].Color != board.Player2.Color)
                            return (lastindex + 1);
                        else
                            return (new Random().Next(1, 3) == 1) ? firstindex - 1 : -1;
                    }


                }
            }
            return -1;
        }

        public int GenerateMove(Board b)
        {
            board = b;
            // IF EASY
            if (Difficulty == 1)
            {
                int play = new Random().Next(0, 7);
                return play;
            }

            //IF NORMAL
            else
            {
                // IF : Computer will win in one of the columns
                if (GetWinningColumn() != -1)
                    return GetWinningColumn();
                //IF : Player will  win in one of the columns
                if (GetPlayerWinningColumn() != -1)
                    return GetPlayerWinningColumn();
                if (GetPlayerWinningRow() != -1)
                    return GetPlayerWinningRow();
                else
                    return new Random().Next(0, 7);


            }


        }

    }
}
