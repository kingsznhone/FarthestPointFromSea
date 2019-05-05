using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace MapAnalysis
{
    public struct PBorder
    {
        public int x;
        public int y;
    }

    public struct PLand
    {
        public int x;
        public int y;
        public float dist;
    }

    public class Ruler
    {
        int landcount = 0;
        int bordercount = 0;

        PLand[] PLs;
        PBorder[] PBs;

        public Ruler(Bitmap source)
        {
            ScanPixel(source);
        }

        private void ScanPixel(Bitmap source)
        {
            int BIndex = 0;
            int LIndex = 0;
            PBorder bufferBorder = new PBorder();
            PLand bufferLand = new PLand();
            //first scan
            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    Color P = source.GetPixel(x, y);

                    //white pixel == null
                    if (P.R == P.G && P.G == P.B && P.R > 127)
                    {
                        continue;
                    }

                    //black pixel == border
                    else if (P.R == P.G && P.G == P.B && P.R <= 127)
                    {
                        bordercount++;
                    }

                    //green pixel = land
                    else 
                    {
                        landcount++;
                    }
                }
            }
            PLs = new PLand[landcount];
            PBs = new PBorder[bordercount];

            //second scan
            for (int y = 0; y < source.Height; y++)
            {
                for (int x = 0; x < source.Width; x++)
                {
                    Color P = source.GetPixel(x, y);

                    //white pixel == null
                    if (P.R == P.G && P.G == P.B && P.R > 192)
                    {
                        continue;
                    }

                    //black pixel == border
                    else if (P.R == P.G && P.G == P.B && P.R <= 192)
                    {
                        bufferBorder.x = x;
                        bufferBorder.y = y;
                        PBs[BIndex] = bufferBorder;
                        BIndex++;
                    }

                    //green pixel = land
                    else
                    {
                        bufferLand.x = x;
                        bufferLand.y = y;
                        PLs[LIndex] = bufferLand;
                        LIndex++;
                    }
                }
            }
        }

        public PLand ComputeDist()
        {
            float[] buffer = new float[PBs.Length];

            //brute search
            for (int i = 0;  i < PLs.Length; i++)
            {
                for (int j = 0; j < PBs.Length; j++)
                {
                    PLand PL = PLs[i];
                    PBorder PB = PBs[j];
                    float D = (float)(Math.Pow(((double)PB.x - (double)PL.x), 2)+ Math.Pow(((double)PB.y - (double)PL.y), 2));
                    buffer[j] = D;
                }
                PLs[i].dist = buffer.Min();
            }

            //find max
            int indexMAX = 0;
            float maxdistbuffer = 0;
            for(int i=0;i<PLs.Length;i++)
            {
                
                if (PLs[i].dist>maxdistbuffer)
                {
                    maxdistbuffer = PLs[i].dist;
                    indexMAX = i;
                }
            }
            PLand result = PLs[indexMAX];
            return result;
        }
    }
}
