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
    public partial class Form_DiskSelect : Form
    {
        public Form_DiskSelect()
        {
            InitializeComponent();
        }

        public Image ReturnSelected()
        {
            if (radioButton_Green.Checked) 
            { 
                
                return pictureBox_Green.Image; 
            }
            else if (radioButton_SphereCyan.Checked) { 
                return pictureBox_SphereCyan.Image;
            }
            else if (radioButton_SphereViolet.Checked) { 
                return pictureBox_SphereViolet.Image;
            }
            else
            {
                return pictureBox_Violet.Image;
            }
        }

        private void button_Select_Click(object sender, EventArgs e)
        {
            
        }

      

      
    }
}
