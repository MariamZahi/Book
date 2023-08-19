using System.ComponentModel.DataAnnotations;

public class Category
{
    public int Id { get; set; }

    [Required]
    public string NameToken { get; set; }

    [Required]
    public string Type { get; set; }

    public string Description { get; set; }
}