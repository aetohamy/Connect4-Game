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
    public partial class Form_TwoPlayers : Form
    {
        public int whoplays = 0;
        Board b;
        public Form_TwoPlayers()
        {
            InitializeComponent();
            b = new Board();
        }

        public Form_TwoPlayers(string Player1Name , string Player2Name , Image Player1Disk , Image Player2Disk)
        {
            InitializeComponent();
            b = new Board(new RedDisk(Player1Name,new Bitmap(Player1Disk)), new BlueDisk(Player2Name, new Bitmap(Player2Disk)));
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            Button caller = (Button) sender;
            int col = Int32.Parse(caller.Tag.ToString());
           
            if(b.CountDisksIn(col) == 7)
                caller.Enabled = false;
            
            
            //if (Form2.radio)
            //{
                b.WhoPlays(ref whoplays, col, b, tableLayoutPanel1 , toolStripStatusLabel1);
     
            /*  }
            else
            {
                b.who_plays(ref whoplays, col, b, tableLayoutPanel1);

                a.who_plays(ref whoplays, col, b, tableLayoutPanel1);

            }
            */
           
              
            b.CheckColumn();
            b.CheckRow1();
            b.CheckRow2();
            b.CheckDiagonal();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        

     

    }
}
