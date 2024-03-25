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

        private void ProjectManagerForm_Load(object sender, EventArgs e)
        {
            for(int i = 0; i < WebDataManager.Instance.ProjectList.Count; i++)
            {
                CreateProjectView(WebDataManager.Instance.ProjectList[i]);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            var res = colorDialog1.ShowDialog();
            if (res == DialogResult.OK)
            {
                button1.BackColor = colorDialog1.Color;
            }
        }

        private async void button2_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
                return;

            Project newProject = new Project()
            {
                Color = button1.BackColor.ToHex(),
                Name = textBox1.Text
            };

            bool done = await WebDataManager.Instance.AddProject(newProject);
            if(done)
            {
                CreateProjectView(newProject);
            } else
            {
                MessageBox.Show("Nepodařilo se přidat projekt!");
            }
        }

        private void CreateProjectView(Project newProject)
        {
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
