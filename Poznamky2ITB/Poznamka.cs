using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Poznamky2ITB
{
    public class Poznamka
    {
        public string Headline { get; set; }

        public string Description { get; set; }

        public DateTime DueDate { get; set; }

        public int ProjectId { get; set; }

        public List<string> Subtasks { get; set; }

        public string IsDone { get; set; }
    }
}
