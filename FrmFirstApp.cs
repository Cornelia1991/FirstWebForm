using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FirstApp
{
    public partial class FrmFirstApp : Form
    {
        public FrmFirstApp()
        {
            InitializeComponent();
        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void FrmFirstApp_Load(object sender, EventArgs e)
        {

        }

        private void BtnHello_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello " + TxtName.Text);
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RadioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void BtnHappy_CheckedChanged(object sender, EventArgs e)
        {
            PicHappy.Visible = true;
            PicSad.Visible = false;
        }

        private void BtnSad_CheckedChanged(object sender, EventArgs e)
        {
            PicHappy.Visible = false;
            PicSad.Visible = true;
        }
    }
}
