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
    public partial class FMain : Form
    {
        
        public FMain()
        {
            InitializeComponent();
        }

        private void FMain_Load(object sender, EventArgs e)
        {
            DataTable dt = DAL.LoadData();

            //FillList(dt);

            gridControl1.DataSource = dt;
            cardView1.RefreshData();

           
        }

        private void FMain_Resize(object sender, EventArgs e)
        {
            splitContainerControl1.SplitterPosition = this.Width / 3 * 2;
            gridView1.BestFitColumns();
            
        }

        private void tsMode_Toggled(object sender, EventArgs e)
        {
            if (tsMode.IsOn)
            {
                gridControl1.MainView = cardView1;
            }
            else
            {
                gridControl1.MainView = gridView1;
                gridView1.BestFitColumns();
            }

        }

        private void gridControl1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("change");
        }

        private void cardView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            pictureEdit1.Image = null;
            Comm.CurrentImage = "";
            System.Diagnostics.Debug.Print("CardViewClick");
            object o = cardView1.GetRowCellValue(e.FocusedRowHandle, "ScanImage");
            if (o == null)
                return;
            string img = o.ToString();
            img = Comm.ImgPath + img;
            System.Diagnostics.Debug.Print(img);
            
            if (System.IO.File.Exists(img))
            {
                pictureEdit1.Image = Image.FromFile(img);
                Comm.CurrentImage = img;
            }
        }

        private void gridView1_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            pictureEdit1.Image = null;
            Comm.CurrentImage = "";
            System.Diagnostics.Debug.Print("gridViewClick");
            object o = gridView1.GetRowCellValue(e.FocusedRowHandle, "ScanImage");
            if (o == null)
                return;
            string img = o.ToString();
            img = Comm.ImgPath + img;
            System.Diagnostics.Debug.Print(img);
            if (System.IO.File.Exists(img))
            {
                pictureEdit1.Image = Image.FromFile(img);
                Comm.CurrentImage = img;
            }
        }

        private void pictureEdit1_DoubleClick(object sender, EventArgs e)
        {
            if (System.IO.File.Exists(Comm.CurrentImage))
            {
                FImgView iv = new NCMRViewer.FImgView();
                iv.ShowDialog(this);
            }
        }

        private void simpleButton2_Click(object sender, EventArgs e)
        {
           
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {

        }

        private void labelControl3_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
