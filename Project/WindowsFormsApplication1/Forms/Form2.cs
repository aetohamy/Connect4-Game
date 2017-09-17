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
    
    public partial class Form2 : Form
    {
        
        public static bool radio;
        public Form2()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(radioButton_TwoPlayers.Checked)
            {
                radio = true;
                Form_TwoPlayerOptions newForm = new Form_TwoPlayerOptions();
                newForm.Show();
             
            }
            else if(radioButton_PlayerOne.Checked)
            {
                radio = false;
                Form_SinglePlayerOptions newForm = new Form_SinglePlayerOptions();
                newForm.Show();

            }
         
            
        }
     
        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
        
        }
        
        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            
        }
        
    }


}





