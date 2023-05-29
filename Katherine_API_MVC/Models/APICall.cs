using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace Katherine_API_MVC.Models;

public class APICall
{
    public static Root Name()
    {
        var client = new HttpClient();


        var mickeyUrl = "https://api.disneyapi.dev/character";

        var mickeyResponse = client.GetStringAsync(mickeyUrl).Result;

        //var mickeyObject = JObject.Parse(mickeyResponse);

        var root = JsonConvert.DeserializeObject<Root>(mickeyResponse);

        return root;

        // int index;
        //var instance = new CharacterProperties();
        //instance.Name = mickeyObject["data"][1]["name"];
        //Person person = JsonSerializer.Deserialize<Person>(jsonString)
        //for (int i = 0; i < 20; i++)
        //{
        //    Console.WriteLine(mickeyObject["data"][i]["name"]);
        //}


        //var roots = JsonConvert.DeserializeObject<Root>(mickeyResponse);
        //return roots;

        //Console.WriteLine(mickeyObject["data"][1]["name"]);



    }
    public static Root AnotherPage()
    {
        var client = new HttpClient();

        var r = new Root();
        var i = new Info();
        var mickeyUrl = r.info.nextPage;

        var mickeyResponse = client.GetStringAsync(mickeyUrl).Result;

        //var mickeyObject = JObject.Parse(mickeyResponse);

        var root = JsonConvert.DeserializeObject<Root>(mickeyResponse);

        return root;

        // int index;
        //var instance = new CharacterProperties();
        //instance.Name = mickeyObject["data"][1]["name"];
        //Person person = JsonSerializer.Deserialize<Person>(jsonString)
        //for (int i = 0; i < 20; i++)
        //{
        //    Console.WriteLine(mickeyObject["data"][i]["name"]);
        //}


        //var roots = JsonConvert.DeserializeObject<Root>(mickeyResponse);
        //return roots;

        //Console.WriteLine(mickeyObject["data"][1]["name"]);



    }
}
