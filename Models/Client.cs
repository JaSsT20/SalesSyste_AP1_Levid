public class Client
{
    [Key]
    [Range(0, int.MaxValue, ErrorMessage = "El id debe ser mayor que cero.")]
    public int ClientId { get; set; }
    [Required(ErrorMessage = "El NOMBRE es obligatorio.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre es demasiado corto, Debe tener al menos {2} dígitos")]
    public string Name { get; set; } = string.Empty;
    [Required(ErrorMessage = "El APELLIDO es obligatorio.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "El APELLIDO es demasiado corto, Debe tener al menos {2} dígitos")]
    public string LastName { get; set; } = string.Empty;
    [Required(ErrorMessage = "El número de identificación es obligatorio.")]
    [RegularExpression("^[0-9]*$", ErrorMessage = "El número de identificación debe contener solo numeros.")]
    public string IdentificationNumber { get; set; } = string.Empty;
    [Required(ErrorMessage = "La DIRECCIÓN es obligatorio.")]
    [StringLength(500, MinimumLength = 5, ErrorMessage = "Debe introducir una direccion real.")]
    public string Address { get; set; } = string.Empty;
    [Required(ErrorMessage = "El TELÉFONO es obligatorio.")]
    [RegularExpression("^[0-9]*$", ErrorMessage = "El telefono debe contener solo numeros.")]
    [StringLength(12, MinimumLength = 10, ErrorMessage = "El TELÉFONO debe contener al menos {2} dígitos y maximo {1} dígitos.")]
    public string Telephone { get; set; } = string.Empty;
    public DateTime RegisterDate { get; set; } = DateTime.Today;
    [Required(ErrorMessage = "El campo EMAIL es obligatorio.")]
    [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "El campo EMAIL no es válido.")]
    public string Email { get; set; } = string.Empty;
}