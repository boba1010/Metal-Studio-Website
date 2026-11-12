namespace Metal_Studio.Blazor.Models;

public class Project
{
    public string Title { get; set; } = "";
    public string Description { get; set; } = "";
    public List<Image> Images { get; set; } = [];
    public List<Badge> Technologies { get; set; } = [];
    public string GithubUrl { get; set; } = "";
}
