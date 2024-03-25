using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using Newtonsoft.Json;
using System.Net.Http.Json;

namespace Poznamky2ITB
{
    public class WebDataManager
    {
        private static Lazy<WebDataManager> instance = new Lazy<WebDataManager>(() => new WebDataManager());

        public static WebDataManager Instance => instance.Value;

        private HttpClient httpClient;

        public WebDataManager()
        {
            httpClient = new HttpClient();
            httpClient.BaseAddress = new Uri("http://oddtgames.cz/vyuka/pva/todo/");
        }

        public IReadOnlyList<Project> ProjectList
        {
            get { return Projects; }
        }

        public IReadOnlyList<Poznamka> PoznamkaList
        {
            get { return Poznamkas; }
        }

        protected List<Project> Projects = new List<Project>();

        protected List<Poznamka> Poznamkas = new List<Poznamka>();

        public async Task InitAllProjects()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(
                    new Uri(httpClient.BaseAddress, "get_all_projects.php"));

                response.EnsureSuccessStatusCode();

                string result = await response.Content.ReadAsStringAsync();
                List<Project> projects = JsonConvert.DeserializeObject<List<Project>>(result);
                if(projects != null)
                {
                    Projects = projects;
                } else
                {
                    // dát vědět uživateli, že se nepodařilo převést string na list projektů
                }
            }
            catch (HttpRequestException ex)
            {
                Projects = new List<Project>();
            }
        }

        public async Task<bool> AddProject(Project newProject)
        {
            try
            {
                HttpResponseMessage response = await httpClient.PostAsync(
                new Uri(httpClient.BaseAddress, "add_project.php"), // URI
                new FormUrlEncodedContent(new Dictionary<string, string>() {
                    { "name", newProject.Name },
                    { "color", newProject.Color }
                })
                );

                response.EnsureSuccessStatusCode();

                string newId = await response.Content.ReadAsStringAsync();
                if (int.TryParse(newId, out int id))
                {
                    newProject.Id = id;
                }
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.StatusCode + " : " + ex.Message);
                return false;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Nepodařilo se předat id " + ex.Message);
                return false;
            }

            Projects.Add(newProject);

            return true;
        }

        public async Task<bool> AddPoznamka(Poznamka newPoznamka)
        {
            try
            {
                HttpResponseMessage response = await httpClient.PostAsync(
                    new Uri(httpClient.BaseAddress, "add_note.php"),
                    JsonContent.Create(newPoznamka)
                );

                response.EnsureSuccessStatusCode();
            }
            catch (HttpRequestException ex)
            {
                MessageBox.Show(ex.StatusCode + " : " + ex.Message);
                return false;
            }

            Poznamkas.Add(newPoznamka);

            return true;
        }

        public async Task InitAllNotes()
        {
            try
            {
                HttpResponseMessage response = await httpClient.GetAsync(
                    new Uri(httpClient.BaseAddress, "get_notes.php"));

                response.EnsureSuccessStatusCode();

                string result = await response.Content.ReadAsStringAsync();
                List<Poznamka> poznamky = JsonConvert.DeserializeObject<List<Poznamka>>(result);
                if (poznamky != null)
                {
                    Poznamkas = poznamky;
                }
                else
                {
                    // dát vědět uživateli, že se nepodařilo převést string na list projektů
                }
            }
            catch (HttpRequestException ex)
            {
                Poznamkas = new List<Poznamka>();
            }
        }
    }
}
