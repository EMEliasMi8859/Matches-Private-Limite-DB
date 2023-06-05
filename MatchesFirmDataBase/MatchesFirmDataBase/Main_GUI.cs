using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MatchesFirmDataBase
{
    public partial class Main_GUI : Form
    {
        public Main_GUI()
        {
            InitializeComponent();

        }

        private void Main_GUI_Resize(object sender, EventArgs e)
        {/*
            Rectangle FormSize;
            Rectangle btnCntSize;
            FormSize = new Rectangle(this.Location.X, this.Location.Y, this.Size.Width, this.Size.Height);*/
            Main_TabController.Width = this.Size.Width;
            Main_TabController.Height = this.Size.Height;
        }

        private void Statistics_Click(object sender, EventArgs e)
        {

        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void StatisticsTabs_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void chart1_Click(object sender, EventArgs e)
        {

        }
    }
}
