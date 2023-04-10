public class Seller
{
    [Key]
    [Range(0, int.MaxValue, ErrorMessage = "El id debe ser mayor que cero.")]
    public int SellerId { get; set; }
    [Required(ErrorMessage = "El nombre es obligatorio.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre debe tener {2} o más dígitos.")]
    [RegularExpression(@"^[^\d]+$", ErrorMessage = "El nombre no puede contener números.")]
    public string Name { get; set; } = string.Empty;
    [Required(ErrorMessage = "El apellido es obligatorio.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "El apellido es demasiado corto, debe tener al menos {2} dígitos")]
    [RegularExpression(@"^[^\d]+$", ErrorMessage = "El apellido no puede contener números.")]
    public string LastName { get; set; } = string.Empty;
    [Required(ErrorMessage = "El número de identificación es obligatorio.")]
    [RegularExpression("^[0-9]*$", ErrorMessage = "El número de identificación debe contener solo numeros.")]
    public string IdentificationNumber { get; set; } = string.Empty;
    [Required(ErrorMessage = "La dirección es obligatoria.")]
    [StringLength(500, MinimumLength = 5, ErrorMessage = "Debe introducir una direccion real.")]
    public string Address { get; set; } = string.Empty;
    [Required(ErrorMessage = "El campo teléfono es obligatorio.")]
    [RegularExpression("^[0-9]*$", ErrorMessage = "El teléfono debe contener solo números.")]
    [StringLength(12, MinimumLength = 10, ErrorMessage = "El teléfono debe contener al menos {2} dígitos y maximo {1} dígitos.")]
    public string Telephone { get; set; } = string.Empty;
    public DateTime EntryDate { get; set; } = DateTime.Today;
    public float TotalSold { get; set; }
}