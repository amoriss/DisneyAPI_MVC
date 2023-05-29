namespace Katherine_API_MVC.Models;

public class CharacterProperties
{
    public int _id { get; set; }
    public List<string> films { get; set; }
    public List<string> shortFilms { get; set; }
    public List<string> tvShows { get; set; }
    public List<string> videoGames { get; set; }
    public List<string> parkAttractions { get; set; }
    public List<object> allies { get; set; }
    public List<object> enemies { get; set; }
    public string sourceUrl { get; set; }
    public string Name { get; set; }
    public string imageUrl { get; set; }
    public DateTime createdAt { get; set; }
    public DateTime updatedAt { get; set; }
    public string url { get; set; }
    public int __v { get; set; }
}
