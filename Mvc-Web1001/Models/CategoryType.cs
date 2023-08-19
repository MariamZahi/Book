using System.ComponentModel.DataAnnotations;

public class CategoryType
{
    public int Id { get; set; }

    [Required]
    public string Type { get; set; }

    [Required]
    public string Name { get; set; }
}