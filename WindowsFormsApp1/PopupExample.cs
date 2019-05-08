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
    public partial class PopupExample : Form
    {
        public PopupExample()
        {
            MessageBox.Show("You have started the application", "Status");
            InitializeComponent();
            MessageBox.Show("Your form is ready", "Status");
        }

        private void PopupExample_Load(object sender, EventArgs e)
        {

        }
    }
}
