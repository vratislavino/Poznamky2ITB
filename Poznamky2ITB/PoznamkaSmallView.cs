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
    public partial class PoznamkaSmallView : UserControl
    {
        Poznamka data;
        public Poznamka Data { get { return data; } }

        public event Action<PoznamkaSmallView> PoznamkaSelected;

        public PoznamkaSmallView()
        {
            InitializeComponent();
        }

        public void SetupPoznamka(Poznamka poznamka)
        {
            data = poznamka;
            label1.Text = data.Headline;
            label2.Text = data.DueDate.ToString();
            var project = WebDataManager.Instance.ProjectList.FirstOrDefault(p => p.Id == data.ProjectId);
            if(project != null )
            {
                pictureBox1.BackColor = project.Color.ToColor();
            }
            
            if (data.IsDone=="0") SetDone();
        }

        private void PoznamkaSmallView_Click(object sender, EventArgs e)
        {
            PoznamkaSelected?.Invoke(this);
        }

        public void SetDone()
        {
            label1.Font = new Font("Segoe UI", 12F, FontStyle.Strikeout, GraphicsUnit.Point);

        }
    }
}
