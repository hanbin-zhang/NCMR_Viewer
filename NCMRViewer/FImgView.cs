using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DevExpress.Utils;

namespace NCMRViewer
{
    public partial class FImgView : Form
    {
        public FImgView()
        {
            InitializeComponent();
            pictureEdit1.Properties.AllowZoomOnMouseWheel = DevExpress.Utils.DefaultBoolean.True;
            pictureEdit1.Properties.ShowCameraMenuItem = DevExpress.XtraEditors.Controls.CameraMenuItemVisibility.Auto;
            pictureEdit1.Properties.ShowScrollBars = true;
            pictureEdit1.Properties.ZoomingOperationMode = DevExpress.XtraEditors.Repository.ZoomingOperationMode.MouseWheel;

        }

        private void ImgView_KeyPress(object sender, KeyPressEventArgs e)
        {

            this.Close();

        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            //this.Close();
        }

        private void FImgView_Load(object sender, EventArgs e)
        {
            pictureEdit1.Image = Image.FromFile(Comm.CurrentImage);
        }

        private void pictureEdit1_MouseDown(object sender, MouseEventArgs e)
        {
            //pictureEdit1.Properties.ZoomPercent += e.Delta * zoomSpeedFactor;
            //DXMouseEventArgs.GetMouseArgs(e).Handled = true;
        }

        private void pictureEdit1_MouseUp(object sender, MouseEventArgs e)
        {
            //pictureEdit1.Properties.ZoomPercent += e.Delta * zoomSpeedFactor;
            //DXMouseEventArgs.GetMouseArgs(e).Handled = true;
        }

        private void pictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void pictureEdit1_EditValueChanged(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Image image = pictureEdit1.Image.Clone() as Image;
            image.RotateFlip(RotateFlipType.Rotate270FlipNone);
            pictureEdit1.Image.Dispose();
            pictureEdit1.Image = image;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Image image = pictureEdit1.Image.Clone() as Image;
            image.RotateFlip(RotateFlipType.Rotate90FlipNone);
            pictureEdit1.Image.Dispose();
            pictureEdit1.Image = image;
        }
    }
}
