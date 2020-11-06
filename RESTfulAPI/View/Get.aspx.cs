using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using System.Threading.Tasks;
using System.Net.Http;

namespace RESTfulAPI.View
{
    public partial class Get : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void btnRun_Click(object sender, EventArgs e)
        {
            StartGet();
        }
        public async void StartGet()
        {
            HttpClient client = new HttpClient();
            var response = await client.GetAsync(txtServer.Text);
            txtResponse.Text = response.Content.ToString();
        }
    }
}