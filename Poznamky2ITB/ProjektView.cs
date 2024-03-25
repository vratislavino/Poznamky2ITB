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
    public partial class ProjektView : UserControl
    {
        private Project project;
        public Project Project
        {
            get { return project; }
            set
            {
                project = value;
                
                pictureBox1.BackColor = project.Color.ToColor();
                label1.Text = project.Name;
            }
        }

        public event Action<ProjektView> DeleteRequested;

        public ProjektView()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if(DataManager.Instance.PoznamkaList.Any(p => p.ProjectId == project.Id))
            {
                MessageBox.Show("Nelze smazat projekt, který má poznámky!");
                return;
            }

            DataManager.Instance.RemoveProject(project);    
            DeleteRequested?.Invoke(this);
        }
    }
}
