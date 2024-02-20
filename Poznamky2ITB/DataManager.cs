using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Poznamky2ITB
{
    public class DataManager
    {
        private static DataManager instance = new DataManager();

        public static DataManager Instance => instance;

        private DataManager() { }

        // ------------------- above are singleton stuff

        private string pathToProjects = "projects.json";
        private string pathToPoznamkas = "poznamkas.json";

        public IReadOnlyList<Project> ProjectList
        {
            get { return Projects; } 
        }

        public IReadOnlyList<Poznamka> PoznamkaList
        {
            get { return Poznamkas; }
        }

        private List<Project> Projects = new List<Project>();

        private List<Poznamka> Poznamkas = new List<Poznamka>();

        public int GetRandomProjectId()
        {
            Random r = new Random();
            int id;
            do
            {
                id = r.Next(0, 1000001);
            } while (Projects.Any(p => p.Id == id));

            return id;
        }

        public void AddProject(Project newProject) {
            Projects.Add(newProject);
            SaveProjects();
        }

        public void RemoveProject(Project projectToRemove) {
            Projects.Remove(projectToRemove);
            SaveProjects();
        }

        public void AddPoznamka(Poznamka poznamka)
        {
            Poznamkas.Add(poznamka);
            SavePoznamkas();
        }

        public void RemovePoznamka(Poznamka poznamka)
        {
            Poznamkas.Remove(poznamka);
            SavePoznamkas();
        }

        public void SavePoznamkas()
        {
            string dataToSave = JsonConvert.SerializeObject(Poznamkas);
            File.WriteAllText(pathToPoznamkas, dataToSave);
        }

        public void LoadPoznamkas()
        {
            if(!File.Exists(pathToPoznamkas))
            {
                Poznamkas = new List<Poznamka>();
                return;
            }

            string data = File.ReadAllText(pathToPoznamkas);
            Poznamkas = JsonConvert.DeserializeObject<List<Poznamka>>(data);
            if(Poznamkas == null)
            {
                MessageBox.Show("Nepodařilo se načíst poznámky!");
                Poznamkas = new List<Poznamka>();
            }
        }

        public void SaveProjects()
        {
            string dataToSave = JsonConvert.SerializeObject(Projects);
            File.WriteAllText(pathToProjects, dataToSave);
        }

        public void LoadProjects()
        {
            if(!File.Exists(pathToProjects))
            {
                Projects = new List<Project>();
                return;
            }

            string dataToLoad = File.ReadAllText(pathToProjects);
            Projects = JsonConvert.DeserializeObject<List<Project>>(dataToLoad);
            if (Projects == null)
            {
                MessageBox.Show("Nepodařilo se načíst projekty!");
                Projects = new List<Project>();
            }
        }
    }
}
