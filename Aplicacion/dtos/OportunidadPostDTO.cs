using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Aplicacion.dtos;

public class OportunidadPostDTO
{
    public int? IdCliente { get;  set; }
    [Required]
    public string Nombre { get; set; }
    [Required]
    public string PrimerApellido { get;  set; }
    public string? SegundoApellido { get;  set; }
    [Required]
    public string Dni { get;  set; }
    [Required]
    public string Telefono { get;  set; }
    [Required]
    public string Email { get;  set; }
    [Required]
    public int IdMotivo { get;  set; }
    [Required]
    public bool Contratado { get;  set; }



}
