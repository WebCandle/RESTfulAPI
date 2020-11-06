using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net.Http;
using System.Threading.Tasks;

namespace RESTfulAPI
{
    public class Controller
    {
        public Controller()
        {

        }
        public async Task<string> RunGetAsync(string server , string parameter)
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(server);
            return response.Content.ToString();
        }
    }
}