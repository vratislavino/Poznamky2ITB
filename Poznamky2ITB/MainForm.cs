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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            DataManager.Instance.LoadProjects();
            FillFilter();
        }

        private void FillFilter()
        {
            foreach (var project in DataManager.Instance.ProjectList)
            {
                comboBox1.Items.Add(project);
            }
        }

        private void projektManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectManagerForm projektForm = new ProjectManagerForm();
            projektForm.ShowDialog();
        }

        private void přidatPoznámkuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPoznamkaForm addPoznamkaForm = new AddPoznamkaForm();
            addPoznamkaForm.ShowDialog();
        }
    }
}
