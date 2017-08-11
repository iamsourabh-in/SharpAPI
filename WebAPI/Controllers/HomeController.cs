using System.Net;
using System.Net.Http;
using System.Web.Mvc;

namespace WebAPI.Controllers
{
    public class HomeController : Controller
    {
        public HttpResponseMessage Index()
        {
            var resp = new HttpResponseMessage(HttpStatusCode.OK);
            resp.Headers.Add("Access-Control-Allow-Origin", "*");
            resp.Headers.Add("Access-Control-Allow-Methods", "GET,DELETE,OPTIONS");

            return resp;
        }
    }
}
