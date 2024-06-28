using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace EmChAPITakeTwo.Models;

public class Item
{
 public int Id { get; set; }

    [StringLength (50)]

    public string Description { get; set; } = string.Empty;

    [Column(TypeName = "decimal(10,02)")]
    public decimal Price { get; set; }




}
