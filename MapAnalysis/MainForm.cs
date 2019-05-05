using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
namespace MapAnalysis
{
    public partial class MainForm : Form
    {
        Bitmap BMP;
        Ruler C ;
        public MainForm()
        {
            InitializeComponent();
        }

        private void ImportBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (openFile.ShowDialog() == DialogResult.OK)
                {
                    BMPpath.Text = openFile.FileName;
                    Image img = Image.FromFile(BMPpath.Text);
                    BMP =new Bitmap(img);
                    if (img.Height > BMPview.Height || img.Width > BMPview.Width)
                    {
                        BMPview.SizeMode = PictureBoxSizeMode.Zoom;
                    }
                    else
                    {
                        BMPview.SizeMode = PictureBoxSizeMode.CenterImage;
                    }
                    BMPnormalization.NormalizeColor(ref BMP);
                    BMPview.Image = BMP;
                    InitRuler(BMP);
                }
            }
            catch
            {
                MessageBox.Show("图像格式错误", "Excuse me?", MessageBoxButtons.OK);
            }
        }

        private void InitRuler(Bitmap BMP)
        {
            C = null;
            C = new Ruler(BMP);
        }

        private void ComputeBtn(object sender, EventArgs e)
        {
            PLand MaxdistP = C.ComputeDist();
            BMPnormalization.SetFocus(ref BMP, MaxdistP.x, MaxdistP.y);
            BMPview.Image = BMP;
            debugbox.AppendText("X: " + MaxdistP.x + ","+Environment.NewLine);
            debugbox.AppendText("Y: " + MaxdistP.y + ","+Environment.NewLine);
            debugbox.AppendText("Dist:" + Math.Sqrt(MaxdistP.dist)+Environment.NewLine);
        }
    }
}
