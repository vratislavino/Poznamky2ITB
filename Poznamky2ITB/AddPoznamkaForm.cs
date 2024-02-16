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
    public partial class AddPoznamkaForm : Form
    {
        public AddPoznamkaForm()
        {
            InitializeComponent();
        }

        private void AddPoznamkaForm_Load(object sender, EventArgs e)
        {
            foreach (var project in DataManager.Instance.ProjectList)
            {
                comboBox1.Items.Add(project);
            }
        }

        private void button1_Click(object sender, EventArgs e) // přidat podúkol
        {
            if (string.IsNullOrEmpty(textBox2.Text)) { return; }

            listBox1.Items.Add(textBox2.Text);
        }

        private void button2_Click(object sender, EventArgs e) // zrušit
        {
            Close();
        }

        private void button3_Click(object sender, EventArgs e) // uložit
        {
            Poznamka newPoznamka = new Poznamka();
            newPoznamka.Headline = textBox1.Text;
            newPoznamka.Description = richTextBox1.Text;
            newPoznamka.DueDate = dateTimePicker1.Value;

            var project = comboBox1.SelectedItem as Project;
            if(project == null)
            {
                MessageBox.Show("Nezvolili jste projekt!");
                return;
            }
            newPoznamka.ProjectId = project.Id;

            List<string> subtasks = new List<string>();
            foreach (var item in listBox1.Items)
            {
                subtasks.Add(item.ToString());
            }

            newPoznamka.Subtasks = subtasks;
        }

        private void listBox1_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            var selected = listBox1.SelectedItem;
            if (selected != null)
            {
                listBox1.Items.Remove(selected);
            }
        }
    }
}
