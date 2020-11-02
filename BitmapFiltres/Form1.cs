using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BitmapFiltres
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Bitmap image;
        List<IFilter> filtres;
        ChangeImage changeImage;
        private void button1_Click(object sender, EventArgs e)
        {
            image = new Bitmap("c:\\1\\1.jpg");
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.Image = image;
            filtres = new List<IFilter>();
            filtres.Add(new Negative(image));
            filtres.Add(new BlackAndWhite(image));
            filtres.Add(new ShadesOfGray(image));
            trackBar1.Maximum = filtres.Count-1;

        }
       
        private void Form1_Load(object sender, EventArgs e)
        {
            changeImage = new ChangeImage(pictureBox1);
         
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            changeImage.applyFilter(filtres[trackBar1.Value]);
        }
    }
}
