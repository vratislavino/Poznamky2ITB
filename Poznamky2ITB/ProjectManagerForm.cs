using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Poznamky2ITB
{
    public partial class ProjectManagerForm : Form
    {
        public ProjectManagerForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res = colorDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                return;

            Project newProject = new Project()
            {
                Color = button1.BackColor,
                Name = textBox1.Text,
                Id = 0 // TODO: change to real id
            };

            ProjektView projectView = new ProjektView();
            projectView.Project = newProject;
            flowLayoutPanel1.Controls.Add(projectView);

            projectView.DeleteRequested += (view) =>
            {
                flowLayoutPanel1.Controls.Remove(view);
            };
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
