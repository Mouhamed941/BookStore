namespace BookStore.Models;
using System.ComponentModel.DataAnnotations;
public class Book
{
    public int Id { get; set; }

    [Required]
    public string? Title { get; set; }
    public int PageCount { get; set; }
    public DateTime PublishDate { get; set; }
}