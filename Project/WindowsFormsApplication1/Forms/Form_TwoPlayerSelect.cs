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
    public partial class Form_TwoPlayerOptions : Form
    {
        public Form_TwoPlayerOptions()
        {
            InitializeComponent();
        }

        private void button_PlayerOneChoose_Click(object sender, EventArgs e)
        {
            Form_DiskSelect newForm = new Form_DiskSelect();
            if(newForm.ShowDialog()==DialogResult.OK)
            {
               pictureBox1.Image = newForm.ReturnSelected();
                newForm.Close();
            }
        }

        private void button_PlayerTwoChoose_Click(object sender, EventArgs e)
        {
            Form_DiskSelect newForm = new Form_DiskSelect();
            if (newForm.ShowDialog() == DialogResult.OK)
            {
                pictureBox2.Image = newForm.ReturnSelected();
                newForm.Close();
            }
        }

        private void button_Play_Click(object sender, EventArgs e)
        {
            Form_TwoPlayers newForm = new Form_TwoPlayers(textBox_Name.Text, textBox_PlayerTwoName.Text, pictureBox1.Image, pictureBox2.Image);
            newForm.Show();
            this.Close();
           
        }

        
    }
}
