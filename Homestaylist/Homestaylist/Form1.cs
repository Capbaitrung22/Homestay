using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Homestaylist
{
    public partial class HomestayList : Form
    {
        public HomestayList()
        {
            InitializeComponent();
        }

        private void grdHomelist(object sender, EventArgs e)
        {
            HomestayList();
            ShowList();
        }
        private void ShowList()
        {

            int number = grdHomelist.RowCount;
            txtdem.Text = number.ToString();
        }
    }
}
