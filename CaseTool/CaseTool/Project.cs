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
    public partial class Project : Form
    {
        public Project()
        {
            InitializeComponent();
        }

        // Start Drag and Drop
        private void newComponent_MouseDown(object sender, MouseEventArgs e)
        {
            newComponent.DoDragDrop("newComp", DragDropEffects.All);
        }
        private void existComponent_MouseDown(object sender, MouseEventArgs e)
        {
            existComponent.DoDragDrop("existComp", DragDropEffects.All);
        }

        // Show effect when Item is dragged over the project area.
        private void ProjectArea_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.All;
        }
        // What happens when Item is droped
        private void ProjectArea_DragDrop(object sender, DragEventArgs e)
        {

            string btn_Dropped = e.Data.GetData(DataFormats.Text).ToString();

            if (btn_Dropped == "newComp")
            {
                newComp(e.X - ProjectArea.Left, e.Y - 75);
            } else if (btn_Dropped == "existComp")
            {
                existComp(e.X - ProjectArea.Left, e.Y - 75);
            }
        }

        private void newComp(int x, int y)
        {
            NewComponentForm newForm = new NewComponentForm(x, y);
            newForm.Show();
            newForm.buttonClicked += new EventHandler(newForm_buttonClicked);
        }

        private void newForm_buttonClicked(object sender, EventArgs e)
        {
            GroupBox a = (GroupBox)sender;
            a.Parent = ProjectArea;
            a.Show();
        }

        private void existComp(int x, int y)
        {
            SearchAPI existComp = new SearchAPI(x, y);
            existComp.Show();
            existComp.buttonClicked += new EventHandler(existComp_buttonClicked);
        }

        private void existComp_buttonClicked(object sender, EventArgs e)
        {
            GroupBox a = (GroupBox)sender;
            a.Parent = ProjectArea;
            a.Show();
        }


    }
}
