using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace QuanLyQuanAn.Components
{
    public partial class FOrder : Form
    {
        public FOrder()
        {
            InitializeComponent();
        }

        private void FOrder_Load(object sender, EventArgs e)
        {
            for (int i = 0; i < 12; i++)
            {
                Button btn = new Button();
                btn.Text = $"Button {i + 1}";
                btn.Size = new Size(160, 339);
                btn.Location = new Point(10 + (i % 3) * (160+30), 10 + (i / 3) * (339+15));
                btn.Click += Btn_Click;
                pnlFood.Controls.Add(btn);
            }
        }

        private void Btn_Click(object sender, EventArgs e)
        {
            Button clickedButton = sender as Button;
            MessageBox.Show($"You clicked {clickedButton.Text}");
        }
    }
}
