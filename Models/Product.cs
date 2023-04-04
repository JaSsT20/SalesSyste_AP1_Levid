public class Product
{
    [Key]
    public int ProductId { get; set; }
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(500, MinimumLength = 2, ErrorMessage = "El nombre debe tener dos o más dígitos.")]
    public string Description { get; set; } = string.Empty;
    [Required(ErrorMessage = "El precio es obligatorio.")]
    [Range(1, float.MaxValue, ErrorMessage = "El precio debe ser mayor que cero.")]
    public float Price { get; set; }
    [Required(ErrorMessage = "La existencia es obligatoria.")]
    [Range(1, float.MaxValue, ErrorMessage = "La existencia debe ser mayor que cero.")]    
    public int Existence { get; set; }
    [DisplayFormat(ApplyFormatInEditMode = true, DataFormatString = "{0:dd/MM/yyyy}")]
    public DateTime EntryDate { get; set; } = DateTime.Today;
    public List<SaleDetail> SalesDetails { get; set; } = new List<SaleDetail>();
}