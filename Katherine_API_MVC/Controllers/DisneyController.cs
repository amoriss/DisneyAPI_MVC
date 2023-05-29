using Katherine_API_MVC.Models;
using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;

namespace Katherine_API_MVC.Controllers;
public class DisneyController : Controller
{
    public IActionResult Index([FromQuery(Name = "resource_url")] string resourceUrl = "https://api.disneyapi.dev/character")
    {
        
            var client = new HttpClient();

            var url = resourceUrl;

            var response = client.GetStringAsync(url).Result;

            var root = JsonConvert.DeserializeObject<Root>(response);

            return View(root);
        
    }
    //public IActionResult Index(/*[FromQuery(Name = "resource_url")] string resourceUrl = "https://rickandmortyapi.com/api/character"*/)
    //{
    //    var root =  APICall.Name();
    //    return View(root);
    //}
    public IActionResult AnotherPage()
    {
        var root = APICall.AnotherPage();
        return View(root);
    }
}
