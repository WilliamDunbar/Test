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
     public partial class QuanLyCuonSach : Form
     {
          public QuanLyCuonSach()
          {
               InitializeComponent();
          }

          private void BackButton_MouseEnter(object sender, EventArgs e)
          {
               BackButton.IconColor = Color.FromArgb(233, 49, 1);
               
          }

          private void BackButton_MouseLeave(object sender, EventArgs e)
          {
               BackButton.IconColor = Color.FromArgb(53, 234, 31);
          }

          private void BackButton_Click(object sender, EventArgs e)
          {
               Form quanlydausach = new QuanLyDauSach();
               quanlydausach.TopLevel = false;
               quanlydausach.Dock = DockStyle.Fill;
               Backround_Panel.Controls.Add(quanlydausach);
               Backround_Panel.Tag = quanlydausach;
               quanlydausach.BringToFront();
               quanlydausach.Show();
          }
     }
}
