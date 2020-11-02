using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapFiltres
{
    class ChangeImage
    {
        PictureBox pictureBox { get; set; }
        
        public ChangeImage (PictureBox pictureBox)
        {
            this.pictureBox = pictureBox;
        }
      
        public void applyFilter (IFilter filter)
        {
            pictureBox.Image = filter.Apply();
        }
    }
}
