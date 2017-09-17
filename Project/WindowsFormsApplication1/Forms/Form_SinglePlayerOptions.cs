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
    public partial class Form_SinglePlayerOptions : Form
    {
        public Form_SinglePlayerOptions()
        {
            InitializeComponent();
        }

        private void button_PlayerOneChoose_Click(object sender, EventArgs e)
        {
            Form_DiskSelect newForm = new Form_DiskSelect();
            if (newForm.ShowDialog() == DialogResult.OK)
            {
                pictureBox1.Image = newForm.ReturnSelected();
                newForm.Close();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem != null && comboBox1.SelectedItem.ToString()!="")
            {
                int diff = (comboBox1.SelectedItem.ToString()=="Easy") ? 1 : 2;
                Form_SinglePlayer newForm = new Form_SinglePlayer(diff,textBox1.Text,pictureBox1.Image);
                newForm.Show();
                this.Close();
              
            }
            
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
