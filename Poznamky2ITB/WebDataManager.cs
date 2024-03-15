using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Net;
using static System.Windows.Forms.DataFormats;

namespace Poznamky2ITB
{
    public class WebDataManager : DataManager
    {

        public WebDataManager() {
            
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
