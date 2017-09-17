using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Threading;
using System.Drawing;
namespace WindowsFormsApplication1
{


    class Board
    {
       private int CounterTopRight;
       private int CounterDownLeft;
       private int CounterDownRight;
       private int CounterTopLeft;
       public int CurRow, CurCol;
       public int EnterLeft1=0;
       public int EnterLeft2=0;
       public int EnterRight1 = 0;
       public int EnterRight2 = 0;
       public const int ROW_COUNT = 8;
       public const int COLUMN_COUNT = 8;
       public Disk[,] MainBoard;
       TableLayoutPanel Grid;
       public RedDisk Player1;
       public BlueDisk Player2;
     

        public Board()
        {
            Player1 = new RedDisk();
            Player2 = new BlueDisk();
            MainBoard = new Disk[ROW_COUNT, COLUMN_COUNT];
            Player1 = new RedDisk();
            Player2 = new BlueDisk();
            for (int i = 0; i < ROW_COUNT; i++)
                for (int j = 0; j < COLUMN_COUNT; j++)
                    MainBoard[i, j] = new Disk();
        }

        public Disk this[int row ,int column]
        {
            get { return MainBoard[row, column]; }
          
        }
        public Board(RedDisk player1 , BlueDisk player2)
        {
            Player1 = player1;
            Player2 = player2;
            MainBoard = new Disk[ROW_COUNT, COLUMN_COUNT];
            for (int i = 0; i < ROW_COUNT; i++)
                for (int j = 0; j < COLUMN_COUNT; j++)
                    MainBoard[i, j] = new Disk();
        }

        public void AddDisk(Disk disk, int col, TableLayoutPanel tableLayout1)
        {
            
            try
            {
                Grid = tableLayout1;
                for (int i = 7; i >= 0; i--)
                {
                  
                    if (MainBoard[i, col].Color == "None")
                    {
                        MainBoard[i, col] = disk;
                        PictureBox pb = (PictureBox)tableLayout1.GetControlFromPosition(col, i);
                        pb.Image = disk.DiskColor;
                        CurRow = i;
                        CurCol = col;
                        // MessageBox.Show(/*cur_col.ToString(),*/ cur_row.ToString());
                        break;

                    }
                    
                }
            }
            catch (Exception e) { MessageBox.Show("An index out of range exception has occured in the Add Disk Function"); }
        }

        public int CountDisksIn(int col)
        {

            int c = 0;
            for(int i = 7;i>=0;i--)
            {
                if (MainBoard[i, col].Color == "None")
                    break;
                c++;
            }
            return c;
        }
        public void WhoPlays(ref int turn, int colu, Board board, TableLayoutPanel tlpp , ToolStripLabel lbl)
        {
            if (turn % 2 == 0)
            {

                board.AddDisk(Player1, colu, tlpp);
                lbl.Text = Player2.Color +"'s Turn.";

            }
            else
            {

                board.AddDisk(Player2, colu, tlpp);
                lbl.Text = Player1.Color + "'s Turn.";
            }
            turn++;
        } //

        public void HighlightCell(int row , int col)
        {
            PictureBox pb = (PictureBox)Grid.GetControlFromPosition(col, row);
            Graphics g = pb.CreateGraphics();
            g.DrawRectangle(Pens.Red, new Rectangle(0, 0,58,42));
        }

        public void CheckColumn()
        {
            int count = 0;
            List<Tuple<int, int>> WonIndex = new List<Tuple<int, int>>();
            
            for (int i = CurRow; i <= 7; i++)
            {
                if (MainBoard[i, CurCol].Color == Player1.Color)
                {
                    WonIndex.Add(new Tuple<int, int>(i , CurCol ));
                    if (count >= 3)
                    {
                        
                        MessageBox.Show(Player1.Color+" won in column");
                        foreach (var Index in WonIndex)
                        {
                            HighlightCell(Index.Item1, Index.Item2);
                        }
                        Form_NewGame newForm = new Form_NewGame();
                        if (newForm.ShowDialog() == DialogResult.OK)
                            Application.Restart();
                        else
                            Application.Exit();
                        break;
                    }
                    count++;
                }
                else if (MainBoard[i, CurCol].Color == Player2.Color)
                {
                    count = 0;
                    break;

                }
            }
            for (int i = CurRow; i <= 7; i++)
            {
                if (MainBoard[i, CurCol].Color == Player2.Color)
                {
                    WonIndex.Add(new Tuple<int, int>(i, CurCol));
                    if (count >= 3)
                    {
                        
                        MessageBox.Show(Player2.Color +" won in column");
                       
                        Form_TwoPlayers a = new Form_TwoPlayers();
                        a.Hide();
                        foreach (var Index in WonIndex)
                        {
                            HighlightCell(Index.Item1, Index.Item2);
                        }
                        Form_NewGame newForm = new Form_NewGame();
                        if (newForm.ShowDialog() == DialogResult.OK)
                            Application.Restart();
                        else
                            Application.Exit();
                        break;
                    }
                    count++;
                }
                else if (MainBoard[i, CurCol].Color == Player1.Color)
                {
                    count = 0;
                    break;
                }
            }
        } //

        public void CheckRow1()
        {
            int count = 0;
            List<Tuple<int, int>> WonIndex = new List<Tuple<int, int>>();
            for (int i = 0; i <= 7; i++)
            {
                if (MainBoard[CurRow, i].Color == Player1.Color)
                {
                    WonIndex.Add(new Tuple<int, int>(CurRow, i));
                    if (count >= 3)
                    {
                        
                        MessageBox.Show(Player1.Color+" won in row");
                        
                        foreach (var Index in WonIndex)
                        {
                            HighlightCell(Index.Item1, Index.Item2);
                        }
                        Form_NewGame newForm = new Form_NewGame();
                        if (newForm.ShowDialog() == DialogResult.OK)
                            Application.Restart();
                        else
                            Application.Exit();
                        break;
                    }
                    count++;
                }
                else if ((MainBoard[CurRow, i].Color == Player2.Color) || ((MainBoard[CurRow, i].Color == "None")))
                {
                    count = 0;
                }
            }
        } //

        public void CheckRow2()
        {
            int count = 0;
            List<Tuple<int, int>> WonIndex = new List<Tuple<int, int>>();
            for (int i = 0; i <= 7; i++)
            {
                if (MainBoard[CurRow, i].Color == Player2.Color)
                {
                    WonIndex.Add(new Tuple<int, int>(CurRow, i));
                    if (count >= 3)
                    {
                        
                        MessageBox.Show(Player2.Color+" won in row");
                        Form_NewGame newForm = new Form_NewGame();
                        if (newForm.ShowDialog() == DialogResult.OK)
                            Application.Restart();
                        else
                            Application.Exit();
                        break;
                    }
                    count++;
                }
                else if (MainBoard[CurRow, i].Color == Player1.Color || ((MainBoard[CurRow, i].Color == "None")))
                {
                    count = 0;
                }
            }
        } //


        public void CheckDiagonal()
        {


            DownLeft();
            TopRight();
            if (EnterLeft1 == 0 && EnterLeft2==0)
            {
                Diagonal(CounterTopRight, CounterDownLeft);
                   
            }
            DownRight();
            TopLeft();
            if (EnterRight1 == 0 && EnterRight2 == 0)
            {
                Diagonal(CounterDownRight, CounterTopLeft);
            }

            
        }

        public void Diagonal(int Counter1, int Counter2)
        {
            string CurrentColour =MainBoard[CurRow, CurCol].Color;

            if (Counter1 + Counter2 > 4)
            {
                
                MessageBox.Show(CurrentColour + "Diagonal Win"); // We need to know the colour of the player.

                Form_NewGame newForm = new Form_NewGame();
                if (newForm.ShowDialog() == DialogResult.OK)
                    Application.Restart();
                else
                    Application.Exit();
            }
            
        }
       
       
        
        public void TopRight()
        {
           
            int counter = 0;       
            int x = CurRow;
            int y = CurCol;
            
            string cur_colour = MainBoard[x, y].Color;
            List<Tuple<int, int>> WonIndex = new List<Tuple<int, int>>();
            while (x >= 0 && y <= 7 && cur_colour == MainBoard[x, y].Color)
            {
                x--;
                y++;
                counter++;
                WonIndex.Add(new Tuple<int, int>(x+1, y-1));
            }

            CounterTopRight = counter;
            
            if (counter == 4)
            {
                MessageBox.Show(cur_colour + " top right wins");
               
                
               
                foreach(var Index in WonIndex)
               {
                   HighlightCell(Index.Item1, Index.Item2);
               }

                Form_NewGame newForm = new Form_NewGame();
                if (newForm.ShowDialog() == DialogResult.OK)
                    Application.Restart();
                else
                    Application.Exit();
             EnterLeft1 = 1;
            }
            else
            { counter = 0; }        
            
        
        }
        public void DownLeft()
        {
            int counter = 0;
            int x = CurRow;
            int y = CurCol;
           
            string cur_colour = MainBoard[x, y].Color;
            List<Tuple<int, int>> WonIndex = new List<Tuple<int, int>>();


            while (  x <=7 && y >= 0 &&cur_colour == MainBoard[x, y].Color) 
            {
                x++;
                y--;
                counter++;
                WonIndex.Add(new Tuple<int, int>(x-1 , y+1 ));
            }
            CounterDownLeft = counter;
            if (counter == 4)
            {
                MessageBox.Show(cur_colour+" down left wins");

                

                foreach (var Index in WonIndex)
                {
                    HighlightCell(Index.Item1, Index.Item2);
                }

               EnterLeft2 = 1;
               Form_NewGame newForm = new Form_NewGame();
               if (newForm.ShowDialog() == DialogResult.OK)
                   Application.Restart();
               else
                   Application.Exit();
            }
            else
            { 
                counter = 0;
            
            }
            
         
        }

        public void DownRight()
        {

            int counter = 0;
            int x = CurRow;
            int y = CurCol;
           
            string cur_colour = MainBoard[x, y].Color;
            List<Tuple<int, int>> WonIndex = new List<Tuple<int, int>>();


            while ( x <= 7 && y <= 7&&cur_colour == MainBoard[x, y].Color )
            {
                x++;
                y++;
                counter++;
                WonIndex.Add(new Tuple<int, int>(x-1 , y-1 ));
              
            }
            CounterDownRight = counter;
            if (counter == 4)
            {
                MessageBox.Show(cur_colour +" down right wins");
                

                foreach (var Index in WonIndex)
                 {
                    HighlightCell(Index.Item1, Index.Item2);
                }

                EnterRight1 = 1;
                Form_NewGame newForm = new Form_NewGame();
                if (newForm.ShowDialog() == DialogResult.OK)
                    Application.Restart();
                else
                    Application.Exit();
            }
            else
            { counter = 0; }

        }

        public void TopLeft()
        {

            int counter = 0;
            int x = CurRow;
            int y = CurCol;
           
            string cur_colour = MainBoard[x, y].Color;
            List<Tuple<int, int>> WonIndex = new List<Tuple<int, int>>();


            while (x >= 0 && y >= 0 && cur_colour == MainBoard[x, y].Color)
            {
                x--;
                y--;
                counter++;
                WonIndex.Add(new Tuple<int, int>(x+1 , y+1 ));
                
            }
            CounterTopLeft = counter;
            if (counter == 4)
            {
                System.Media.SystemSounds.Beep.Play();
                MessageBox.Show(cur_colour + " top left wins");
                

                foreach (var Index in WonIndex)
                {
                    HighlightCell(Index.Item1, Index.Item2);
                }     
                EnterRight2 = 1;
                Form_NewGame newForm = new Form_NewGame();
                if (newForm.ShowDialog() == DialogResult.OK)
                    Application.Restart();
                else
                    Application.Exit();
            }
            else
            { counter = 0; }

         
        }


      /*  public void two_players()
        {

           who_plays(ref int , int , Board , TableLayoutPanel );
            
           check_column();
           check_row_R();
           check_row_B();
           check_diagonal();

        }
        */
     
        
        } //
    }







