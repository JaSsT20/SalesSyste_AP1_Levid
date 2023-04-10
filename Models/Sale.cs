public class Sale
{
    [Key]
    [Range(0, int.MaxValue, ErrorMessage = "El id debe ser mayor que cero.")]
    public int SaleId { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "El ID debe ser válido.")]
    [ForeignKey("ClientId")]
    public int ClientId { get; set; }
    [Range(1, int.MaxValue, ErrorMessage = "El ID debe ser válido.")]
    [ForeignKey("SellerId")]
    public int SellerId { get; set; }
    public DateTime SaleDate { get; set; } = DateTime.Today;
    [Required(ErrorMessage = "Debe introducir una cantidad.")]
    [Range(1, 10000, ErrorMessage = "La cantidad debe estar entre {1} y {2}")]
    public int Quantity { get; set; }
    public string Concept { get; set; } = string.Empty;
    public float Total { get; set; }
    public List<SaleDetail> SalesDetails { get; set; } = new List<SaleDetail>();
}