using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CaseTool
{
    public partial class NewComponentForm : Form
    {
        private int x;
        private int y;
        public event EventHandler buttonClicked;
        // Get X and Y for drop location.
        public NewComponentForm(int x, int y)
        {
            InitializeComponent();
            this.x = x;
            this.y = y;
        }

        // Submit Form and add to area
        private void button1_Click(object sender, EventArgs e)
        {
            groupBox1.Left = x;
            groupBox1.Top = y;
            button1.Hide();

            if (buttonClicked != null)
                buttonClicked(groupBox1, null);

            this.Dispose();
        }
    }
}
