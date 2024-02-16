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
        }

        private void projektManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectManagerForm projektForm = new ProjectManagerForm();

            projektForm.ShowDialog();

            MessageBox.Show("ASASD");
        }

    }
}
