using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QLTVWF
{
     public partial class QuanLyDauSach : Form
     {
          public QuanLyDauSach()
          {
               InitializeComponent();

          }

          private void AdvanceButton_Click(object sender, EventArgs e)
          {
               //ForgroundPanel.Controls.Clear();
               Form quanlycuonsach = new QuanLyCuonSach();
               quanlycuonsach.TopLevel = false;
               quanlycuonsach.Dock = DockStyle.Fill;
               Backround_Panel.Controls.Add(quanlycuonsach);
               Backround_Panel.Tag = quanlycuonsach;
               quanlycuonsach.BringToFront();
               quanlycuonsach.Show();
          }

          private void guna2GradientPanel5_Paint(object sender, PaintEventArgs e)
          {

          }

        private void plusButton2_Click(object sender, EventArgs e)
        {
            ThemTheLoai themtheloai = new ThemTheLoai();
            themtheloai.Show();
        }

        private void guna2GradientButton1_Click(object sender, EventArgs e)
        {
            plusButton2.Visible = true;
            PlusButton1.Visible = true;
        }
    }
}
