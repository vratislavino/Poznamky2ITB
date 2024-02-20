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

            DataManager.Instance.LoadPoznamkas();
            CreatePoznamkasViews();
        }

        private void CreatePoznamkasViews()
        {
            flowLayoutPanel1.Controls.Clear();

            foreach (var poznamka in DataManager.Instance.PoznamkaList)
            {
                CreatePoznamkaView(poznamka);
            }
        }

        private void CreatePoznamkaView(Poznamka poznamka)
        {
            PoznamkaSmallView smallPoznamka = new PoznamkaSmallView();
            smallPoznamka.SetupPoznamka(poznamka);
            flowLayoutPanel1.Controls.Add(smallPoznamka);
        }

        private void FillFilter()
        {
            comboBox1.Items.Clear();
            foreach (var project in DataManager.Instance.ProjectList)
            {
                comboBox1.Items.Add(project);
            }
        }

        private void projektManagerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ProjectManagerForm projektForm = new ProjectManagerForm();
            projektForm.ShowDialog();

            FillFilter();
        }

        private void přidatPoznámkuToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddPoznamkaForm addPoznamkaForm = new AddPoznamkaForm();
            addPoznamkaForm.ShowDialog();

            // tohle se vykoná po zavření AddPoznamkaForm
            CreatePoznamkasViews();

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            var item = comboBox1.SelectedItem;
            if(item != null)
            {
                var selectedProject = item as Project;
                var id = selectedProject.Id;
                foreach(var control in flowLayoutPanel1.Controls)
                {
                    var smallView = control as PoznamkaSmallView;
                    if(smallView.Data.ProjectId == id)
                    {
                        smallView.Visible = true;
                    } else
                    {
                        smallView.Visible = false;
                    }
                }
            }
        }
    }
}
