using Microsoft.AspNetCore.Mvc;

namespace WebApp.Controllers
{
    [Route("Dev")]
    public class FirstController : Controller
    {
        //Action method
        [Route("emp")]
        [Route("emp2")]
        public string getname()
        {
            return "Ansari";
        }
        [Route("address/{city:int}/{country}")]
        public string getaddress(string city,string country)    //Model binder
        {
            return $"{city}-{country}";
        }
    }
}
