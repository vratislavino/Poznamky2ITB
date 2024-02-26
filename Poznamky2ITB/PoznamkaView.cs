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
    public partial class PoznamkaView : UserControl
    {
        public PoznamkaView()
        {
            InitializeComponent();
        }

        public void SetPoznamka(Poznamka data)
        {
            label1.Text = data.Headline;
            label2.Text = data.Description;
            label3.Text = $"Termín splnění: {data.DueDate}";
            foreach(var task in data.Subtasks)
            {
                checkedListBox1.Items.Add(task);
            }
            var project = DataManager.Instance.ProjectList.First(p => p.Id == data.ProjectId);
            pictureBox1.BackColor = project.Color;
            label5.Text = project.Name;

        }
    }
}
