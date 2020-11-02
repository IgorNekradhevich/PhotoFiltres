using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BitmapFiltres
{
    class BlackAndWhite : IFilter
    {
        private Bitmap _oldImage;
        private Bitmap _newImage;
        public BlackAndWhite(Bitmap image)
        {
            _oldImage = image;
        }
        public Bitmap Apply()
        {
            Color pixel;
            int height = _oldImage.Height;
            int width = _oldImage.Width;

            _newImage = new Bitmap(width, height);

            for (int h = 0; h < height; h++)
                for (int w = 0; w < width; w++)
                {
                    pixel = _oldImage.GetPixel(w, h);
                    int sum = (pixel.R + pixel.G + pixel.B) / 3;
                    if (sum>130)
                    pixel = Color.Black;
                    else
                        pixel = Color.White;
                    _newImage.SetPixel(w, h, pixel);
                }
            return _newImage;
        }

        public Bitmap Cancel()
        {
            return _oldImage;
        }

        public void changeImage(Bitmap image)
        {
            _oldImage = image;
        }
    }
}
