namespace Dominio;

public class Contacto
{
    public int IdContacto { get; set; }
    public int IdOportunidad { get; set; }
    public int IdViaContacto { get; set; }
    public DateTime Fecha { get; set; }
    public string Observaciones { get; set; }
    public bool Contactado { get; set; }

    //contactado por defecto sera false?
    public static Result<Contacto> Generar(int idOportunidad, int idViaContacto, DateTime fecha, bool contactado, int? idContacto=null, string? observaciones=null)
    {

        
        Contacto contacto = new Contacto();
        return null;
    }


    public Contacto()
    {

    }
}
