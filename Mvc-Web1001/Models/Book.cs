using System.ComponentModel.DataAnnotations;

public class Book
{
    public int Id { get; set; }

    [Required]
    public string ISBN { get; set; }

    [Required]
    public string Title { get; set; }

    [Required]
    public int CategoryId { get; set; }

    public virtual Category Category { get; set; }

    [Required]
    public string Author { get; set; }
}
