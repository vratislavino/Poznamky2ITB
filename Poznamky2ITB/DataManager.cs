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

        private List<Project> Projects = new List<Project>();

        private List<Poznamka> Poznamkas = new List<Poznamka>();

        public void AddProject(Project newProject) {
            Projects.Add(newProject);
            SaveProjects();
        }

        public void RemoveProject(Project projectToRemove) {
            Projects.Remove(projectToRemove);
            SaveProjects();
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
        }
    }
}
