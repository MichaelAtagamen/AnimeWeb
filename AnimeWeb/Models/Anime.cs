namespace AnimeWeb.Models;

public class Anime
{
    public int Id { get; set; }

    public string Title { get; set; } = null!;
    public string Genre { get; set; } = null!;
    public int ReleaseYear { get; set; }
    public string? Description { get; set; }

    // Navigation property
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
}
