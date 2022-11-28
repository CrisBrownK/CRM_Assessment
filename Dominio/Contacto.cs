namespace Dominio;

public class Contacto
{
    public int IdContacto { get; set; }
    public int IdOportunidad { get; set; }
    public int IdViaContacto { get; set; }
    public DateTime Fecha { get; set; }
    public string Observaciones { get; set; }
    public bool Contactado { get; set; }
}
