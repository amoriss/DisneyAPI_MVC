namespace Katherine_API_MVC.Models;

public class Info
{
    public int count { get; set; }
    public int totalPages { get; set; }
    public string? previousPage { get; set; }
    public string? nextPage { get; set; }
}
