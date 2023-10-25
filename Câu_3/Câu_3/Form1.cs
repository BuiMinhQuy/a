using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Câu_3
{
    public partial class Pham_Tu_Thanh : Form
    {
        public Pham_Tu_Thanh()
        {
            InitializeComponent();
        }
        
        private void bttThoat_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void Pham_Tu_Thanh_FormClosing(object sender, FormClosingEventArgs e)
        {
            if(MessageBox.Show("Ban co muon thoat ung dung", "Xac nhan thoat", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.Cancel){
                e.Cancel = true;
            }
        }
    }
}
