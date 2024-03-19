using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;

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

        public async Task<bool> AddProject(Project newProject)
        {
            HttpResponseMessage response = await httpClient.PostAsync(
                new Uri(httpClient.BaseAddress, "add_project.php"), // URI
                new FormUrlEncodedContent(new Dictionary<string, string>() { })
                );
            response.EnsureSuccessStatusCode();

            MessageBox.Show(await response.Content.ReadAsStringAsync());


            return true;
        }

        /*
        private static WebDataManager instance = new WebDataManager();
        public static WebDataManager Instance => instance;

        HttpClient webClient;
        string baseUrl = "http://oddtgames.cz/vyuka/pva/todo/";

        private WebDataManager()
        {
            webClient = new HttpClient();
            webClient.BaseAddress = new Uri(baseUrl);
        }

        public async Task<List<Project>> DownloadProjects()
        {
            string url = baseUrl + "add_project.php";
            List<Project> result = new List<Project>();
            Dictionary<string, string> data = new Dictionary<string, string>()
            {
                { "name", "test"},
                { "color", "123456" }
            };
            HttpContent content = new FormUrlEncodedContent(data);
            var str = await content.ReadAsStringAsync();
            var res = await webClient.PostAsync(url, content);
            return result;
        }*/
    }
}
