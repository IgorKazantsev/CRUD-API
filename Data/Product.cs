using System.ComponentModel.DataAnnotations.Schema;

public class Product
{
    public int ProductId { get; set; }
    public string Name { get; set; } = string.Empty;

    [Column(TypeName = "decimal(18,2)")]
    public decimal Price { get; set; }
}
