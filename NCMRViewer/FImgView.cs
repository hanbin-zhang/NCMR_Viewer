using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NCMRViewer
{
    public partial class FImgView : Form
    {
        public FImgView()
        {
            InitializeComponent();
        }

        private void ImgView_KeyPress(object sender, KeyPressEventArgs e)
        {

            this.Close();

        }

        private void pictureEdit1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FImgView_Load(object sender, EventArgs e)
        {
            pictureEdit1.Image = Image.FromFile(Comm.CurrentImage);
        }
    }
}
