namespace Dominio;

public class Oportunidad
{
    public int IdOportunidad { get; set; }

    public int IdCliente { get; set; }

    public string Nombre { get; set; }

    public string PrimerApellido { get; set; }

    public string SegundoApellido { get; set; }

    public string Dni { get; set; }

    public string Telefono { get; set; }

    public string Email { get; set; }

    public int IdMotivo { get; set; }

    public bool Contratado { get; set; }

}
