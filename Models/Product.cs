using System.ComponentModel.DataAnnotations;

namespace FormsApp.Models
{
public class Product
{
      [Display (Name = "Urun Id")]
    public int ProductId {get; set;}
  
        [Display (Name = "Fiyat")]
     public string? Name {get; set;}
       [Required] 
        [Display (Name = "Ürün adı")]
    public decimal Price { get; set; }
        [Display(Name="Resim")] 
  public string Image { get; set; } = string.Empty;
    public bool IsActive {get; set;}
     [Display (Name = "Category")]
    public int CategoryId { get; set; }
}
}