public class Client
{
    [Key]
    [Range(0, int.MaxValue, ErrorMessage = "El id debe ser mayor que cero.")]
    public int ClientId { get; set; }
    [Required(ErrorMessage = "El nomrbe es obligatorio.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "El nombre es demasiado corto, Debe tener al menos {2} dígitos")]
    [RegularExpression(@"^[^\d]+$", ErrorMessage = "El nombre no puede contener números.")]
    public string Name { get; set; } = string.Empty;
    [Required(ErrorMessage = "El apellido es obligatorio.")]
    [StringLength(100, MinimumLength = 2, ErrorMessage = "El apellido es demasiado corto, Debe tener al menos {2} dígitos")]
    [RegularExpression(@"^[^\d]+$", ErrorMessage = "El apellido no puede contener números.")]
    public string LastName { get; set; } = string.Empty;
    [Required(ErrorMessage = "El número de identificación es obligatorio.")]
    [RegularExpression("^[0-9]*$", ErrorMessage = "El número de identificación debe contener solo numeros.")]
    [StringLength(11, MinimumLength = 11, ErrorMessage = "El número de identificación debe tener mínimo {2} dígitos y máximo {1} dígitos")]
    public string IdentificationNumber { get; set; } = string.Empty;
    [Required(ErrorMessage = "La dirección es obligatorio.")]
    [StringLength(500, MinimumLength = 5, ErrorMessage = "Debe introducir una direccion real.")]
    public string Address { get; set; } = string.Empty;
    [Required(ErrorMessage = "El teléfono es obligatorio.")]
    [RegularExpression("^[0-9]*$", ErrorMessage = "El telefono debe contener solo numeros.")]
    [StringLength(12, MinimumLength = 10, ErrorMessage = "El teléfono debe contener al menos {2} dígitos y maximo {1} dígitos.")]
    public string Telephone { get; set; } = string.Empty;
    public DateTime RegisterDate { get; set; } = DateTime.Today;
    [Required(ErrorMessage = "El email es obligatorio.")]
    [RegularExpression(@"^([\w\.\-]+)@([\w\-]+)((\.(\w){2,3})+)$", ErrorMessage = "Email no válido, EJ: usuario@dominio.com")]
    public string Email { get; set; } = string.Empty;
}