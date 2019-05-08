using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FormExample
{
    public partial class MenuExample : Form
    {
        public MenuExample()
        {
            InitializeComponent();
        }

        private void updateDateToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DateTime dateTime = new DateTime();
            dateTime = DateTime.Now;
            this.label2.Text = dateTime.ToString();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void MenuExample_Load(object sender, EventArgs e)
        {

        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.label2.Text = "This is the practice example for Menus";
        }
    }
}
