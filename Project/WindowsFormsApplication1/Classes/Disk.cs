using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace WindowsFormsApplication1
{
    class Disk
    {
        public string Color { get; set; }
        public Bitmap DiskColor;

        public Disk()
        {
            Color = "None";
            DiskColor = WindowsFormsApplication1.Properties.Resources.f16_1;
        }


    }
}
