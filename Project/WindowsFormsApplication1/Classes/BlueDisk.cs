using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace WindowsFormsApplication1
{
    class BlueDisk : Disk
    {
        public BlueDisk()
        {
            Color = "Blue";
            DiskColor = WindowsFormsApplication1.Properties.Resources.f16_3;
        }

         public BlueDisk(String Name , Bitmap Image )
        {
            Color = Name;
            DiskColor = Image;
        }
    }
}
