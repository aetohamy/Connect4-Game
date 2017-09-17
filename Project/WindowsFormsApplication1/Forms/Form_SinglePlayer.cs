using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApplication1
{
    public partial class Form_SinglePlayer : Form
    {
        int Difficulty;
        Board MainBoard;
        public int whoplays = 0;
        public Form_SinglePlayer(int Diff , String Player1Name , Image Player1Disk)
        {
            InitializeComponent();
            Difficulty = Diff;
            MainBoard = new Board(new RedDisk(Player1Name, new Bitmap(Player1Disk)),new BlueDisk());

        }

         public async void Button_Click(object sender , EventArgs e)
         {
             Button caller = (Button)sender;
             int col = Int32.Parse(caller.Tag.ToString());

             if (MainBoard.CountDisksIn(col) == 7)
                 caller.Enabled = false;

             AI ArtificialIntelligence = new AI(Difficulty);

                 MainBoard.WhoPlays(ref whoplays, col, MainBoard, tableLayoutPanel1, toolStripStatusLabel1);



                 MainBoard.CheckColumn();             

                 MainBoard.CheckRow1();
                 MainBoard.CheckRow2();
                 MainBoard.CheckDiagonal();
                 DisableAllButtons();   //Disable all  the buttons so that the player cannot do a move in the AI's turn
                 await Task.Delay(1000); // Waits for 1 sec before making the AI play 
                 MainBoard.WhoPlays(ref whoplays, ArtificialIntelligence.GenerateMove(MainBoard), MainBoard, tableLayoutPanel1, toolStripStatusLabel1);
                 MainBoard.CheckColumn();

                 MainBoard.CheckRow1();
                 MainBoard.CheckRow2();
                 MainBoard.CheckDiagonal();
                 EnableAllButtons();  // Re-enables all the buttons 
         }

        public void DisableAllButtons()
         {
             button1.Enabled = false;
             button2.Enabled = false;
             button3.Enabled = false;
             button4.Enabled = false;
             button5.Enabled = false;
             button6.Enabled = false;
             button7.Enabled = false;
             button8.Enabled = false;
         }

        public void EnableAllButtons()
        {
            button1.Enabled = true;
            button2.Enabled = true;
            button3.Enabled = true;
            button4.Enabled = true;
            button5.Enabled = true;
            button6.Enabled = true;
            button7.Enabled = true;
            button8.Enabled = true;
        }

        private void Form_SinglePlayer_Load(object sender, EventArgs e)
        {

        }

    }
}
