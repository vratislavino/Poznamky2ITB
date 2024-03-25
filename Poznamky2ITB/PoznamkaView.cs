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
        private Poznamka poznamka;

        public event Action PoznamkaDeleted;
        public event Action TaskDone;
        public PoznamkaView()
        {
            InitializeComponent();
        }

        public void SetPoznamka(Poznamka data)
        {
            this.poznamka = data;
            label1.Text = data.Headline;
            label2.Text = data.Description;
            label3.Text = $"Termín splnění: {data.DueDate}";
            checkedListBox1.Items.Clear();
            foreach (var task in data.Subtasks)
            {
                checkedListBox1.Items.Add(task);
            }
            var project = DataManager.Instance.ProjectList.First(p => p.Id == data.ProjectId);
            pictureBox1.BackColor = project.Color.ToColor();
            label5.Text = project.Name;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            DataManager.Instance.RemovePoznamka(poznamka);
            PoznamkaDeleted?.Invoke();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (checkedListBox1.CheckedItems.Count == checkedListBox1.Items.Count)
                MakeTaskDone();
            else
                MessageBox.Show("Nejsou splěné všechny podúkoly!");
        }

        private void MakeTaskDone()
        {
            poznamka.IsDone = "1";
            DataManager.Instance.SavePoznamkas();
            TaskDone?.Invoke();
        }
    }
}
