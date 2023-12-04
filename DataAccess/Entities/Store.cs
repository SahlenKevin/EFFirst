using System.ComponentModel.DataAnnotations;

namespace DataAccess.Entities;

public class Store
{
    [Key]
    public int Id { get; set; }

    public String Name { get; set; }

    public List<Product> Products { get; set; } = new();


}