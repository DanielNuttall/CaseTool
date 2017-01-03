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

        private List<newClass> classArray = new List<newClass>();
        private newClass newClass = new newClass();

        // Get X and Y for drop location.
        public NewComponentForm(int x, int y)
        {
            InitializeComponent();
            this.x = x;
            this.y = y;
            varTypeValue.Text = "int";
            methodTypeValue.Text = "int";
            varStatus.Text = "private";
            methodStatus.Text = "private";
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

        private void addVar_Click(object sender, EventArgs e)
        {
            vars.AppendText(varStatus.Text + " " + varTypeValue.Text + " " + varNameValue.Text + ";\n");
            newClass.addVar(varStatus.Text + " " + varTypeValue.Text + " " + varNameValue.Text + ";");
        }

        private void addMethod_Click_1(object sender, EventArgs e)
        {
            methods.AppendText(methodStatus.Text + " " + methodTypeValue.Text + " " + methodValue.Text + "() {}\n");
            newClass.addMethod(methodStatus.Text + " " + methodTypeValue.Text + " " + methodValue.Text + "() {}");
        }

        private void addClass_Click(object sender, EventArgs e)
        {

            classes.Text = "";
            classSelect.Items.Clear();

            newClass.setName(classNameValue.Text);
            classArray.Add(newClass);
            newClass = new newClass();

            foreach (newClass a in classArray)
            {
                classes.AppendText(a.getName() + "\n");
                classSelect.Items.Add(a.getName());
            }

            classNameValue.Text = "";
            varNameValue.Text = "";
            methodValue.Text = "";
            vars.Text = "";
            methods.Text = "";
        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (newClass a in classArray)
            {
                MessageBox.Show(a.generateCode());
            }
        }

        private void classSelect_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (newClass a in classArray)
            {
                if (classSelect.SelectedItem.ToString() == a.getName())
                {
                    classes.Text = a.getAll();
                }
            }
        }
    }
}
