using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApplication1
{
    class RedDisk : Disk
    {

        public RedDisk()
        {
            Color = "Red";
            DiskColor = WindowsFormsApplication1.Properties.Resources.f16_2;
        }

        public RedDisk(String Name , Bitmap Image )
        {
            Color = Name;
            DiskColor = Image;
        }
    }
}
