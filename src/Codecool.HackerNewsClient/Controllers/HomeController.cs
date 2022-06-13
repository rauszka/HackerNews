using System;
using System.Collections.Generic;
using System.Data;
using HackerNewsClient.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;
using System.Net.Http;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;

namespace HackerNewsClient.Controllers
{
    /// <summary>
    /// HomeController is a generic controller responsible for communicating with
    /// external or internal data sources (API or other data services).
    /// It contains methods communicating with the external API and
    /// serializing the data into News object.
    /// The methods return ActionResult which generates respective HTML page (View)
    /// </summary>
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        public HomeController(ILogger<HomeController> logger)
        {
            _logger = logger;
        }

        /// <summary>
        /// returns index page with top news
        /// </summary>
        /// <param name="page"> parameter of current page index </param>
        /// <returns></returns>
        public ActionResult Index()
        {
            return View();
        }

        public async Task<DataTable> RetrieveData(string apiUrl)
        {

            using (HttpClient client = new HttpClient())
            {
                client.BaseAddress = new Uri(apiUrl);
                client.DefaultRequestHeaders.Accept.Clear();
                client.DefaultRequestHeaders.Accept.Add(
                    new System.Net.Http.Headers.MediaTypeWithQualityHeaderValue("application/json"));

                HttpResponseMessage response = await client.GetAsync(apiUrl);

                if (response.IsSuccessStatusCode)
                {
                    var data = await response.Content.ReadAsStringAsync();
                    var table = Newtonsoft.Json.JsonConvert.DeserializeObject<System.Data.DataTable>(data);

                    return table;
                }
            }

            return null;
        }

        public ActionResult TopNews(int ID = 1)
        {
            string apiUrl = $"https://api.hnpwa.com/v0/news/{ID}.json";

            var table = RetrieveData(apiUrl);

            List<APIModel> newsList = new();

            foreach (DataRow tr in table.Result.Rows)
            {
                string title = tr["title"].ToString();
                string author = tr["user"].ToString();
                string timeAgo = tr["time_ago"].ToString();
                string url = tr["url"].ToString();

                APIModel oneApi = new APIModel(ID, title, author, timeAgo, url);
                newsList.Add(oneApi);
            }

            ViewData["news"] = newsList;
            return View();
        }

        public ActionResult Newest(int ID = 1)
        {
            string apiUrl = $"https://api.hnpwa.com/v0/newest/{ID}.json";

            var table = RetrieveData(apiUrl);

            List<APIModel> newsList = new();

            foreach (DataRow tr in table.Result.Rows)
            {
                string title = tr["title"].ToString();
                string author = tr["user"].ToString();
                string timeAgo = tr["time_ago"].ToString();
                string url = tr["url"].ToString();

                APIModel oneApi = new APIModel(ID, title, author, timeAgo, url);
                newsList.Add(oneApi);
            }

            ViewData["news"] = newsList;

            return View();
        }

        public ActionResult Job(int ID = 1)
        {
            string apiUrl = $"https://api.hnpwa.com/v0/jobs/{ID}.json";

            var table = RetrieveData(apiUrl);

            List<APIModel> newsList = new();

            foreach (DataRow tr in table.Result.Rows)
            {
                string title = tr["title"].ToString();
                string author = tr["user"].ToString();
                string timeAgo = tr["time_ago"].ToString();
                string url = tr["url"].ToString();

                APIModel oneApi = new APIModel(ID, title, author, timeAgo, url);
                newsList.Add(oneApi);
            }

            ViewData["news"] = newsList;

            return View();
        }


        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
