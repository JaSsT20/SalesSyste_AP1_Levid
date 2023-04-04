public class SaleDetail
{
    [Key]
    public int Id { get; set; }
    [Required(ErrorMessage = "La venta es obligatoria.")]
    [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar una opción.")]
    [ForeignKey("SaleId")]
    public int SaleId { get; set; }
    [Required(ErrorMessage = "El producto es obligatoria.")]
    [Range(1, int.MaxValue, ErrorMessage = "Debe seleccionar una opción.")]
    [ForeignKey("ProductId")]
    public int ProductId { get; set; }
    [Required(ErrorMessage = "La cantidad es obligatoria.")]
    [Range(1, int.MaxValue, ErrorMessage = "La cantidad debe ser mayor que cero.")]
    public int Quantity { get; set; }
    public float AmountPaid { get; set; }
}