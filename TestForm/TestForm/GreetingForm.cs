// Needs comments - Bill
// Hello World!

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TestForm
{
    public partial class GreetingForm : Form
    {
        public GreetingForm()
        {
            InitializeComponent();
        }

        private void btnGreet_Click(object sender, EventArgs e)
        {
            txtDisplay.Text = "Hello, how are you today?";
        }
    }
}
