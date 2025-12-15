namespace AnimeWeb.Models;

public class User
{
    public int Id { get; set; }

    public string Username { get; set; } = null!;
    public string Email { get; set; } = null!;
    
    // Store hashed password only
    public string PasswordHash { get; set; } = null!;

    // Navigation property
    public ICollection<Review> Reviews { get; set; } = new List<Review>();
}