namespace AnimeWeb.Models;

public class Review
{
    public int Id { get; set; }

    
    public int Rating { get; set; }   // e.g. 1–10
    public string Comment { get; set; } = null!;

    // Foreign Keys
    public int UserId { get; set; }
    public User User { get; set; } = null!;

    public int AnimeId { get; set; }
    public Anime Anime { get; set; } = null!;
}