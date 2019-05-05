using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;
namespace MapAnalysis
{
    public static class BMPnormalization
    {
        public static void NormalizeColor(ref Bitmap BMP)
        {
            for (int y = 0; y < BMP.Height; y++)
            {
                for (int x = 0; x < BMP.Width; x++)
                {
                    Color P = BMP.GetPixel(x, y);
                    if (P.R == P.G && P.G == P.B && P.R > 127)
                    {
                        BMP.SetPixel(x, y, Color.White);
                        continue;
                    }
                    else if (P.R == P.G && P.G == P.B && P.R <= 127)
                    {
                        BMP.SetPixel(x, y, Color.Black);
                    }
                    else
                    {
                        BMP.SetPixel(x, y, Color.Green);
                    }
                }
            }
        }

        public static void SetFocus(ref Bitmap BMP,int x, int y)
        {
            for (int j = 0; j < BMP.Height; j++)
            {
                BMP.SetPixel(x, j, Color.Red);
            }
            for (int i = 0; i < BMP.Width; i++)
            {
                BMP.SetPixel(i, y, Color.Red);
            }
        }
    }
}
