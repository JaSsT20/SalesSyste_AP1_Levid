public class Seller
{
    [Key]
    [Range(0, int.MaxValue, ErrorMessage = "El id debe ser mayor que cero.")]
    public int SellerId { get; set; }
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre debe tener {2} o más dígitos.")]
    public string Name { get; set; } = string.Empty;
    [Required(ErrorMessage = "El campo telefono es obligatorio.")]
    [RegularExpression("^[0-9]*$", ErrorMessage = "El telefono debe contener solo numeros.")]
    [StringLength(12, MinimumLength = 10, ErrorMessage = "El telefono debe contener al menos {2} dígitos y maximo {1} dígitos.")]
    public string Telephone { get; set; } = string.Empty;
    public DateTime EntryDate { get; set; } = DateTime.Today;
    public int TotalProductsSold { get; set; }
}