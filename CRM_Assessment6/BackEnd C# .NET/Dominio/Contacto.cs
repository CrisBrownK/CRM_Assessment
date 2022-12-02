using System.Net;

namespace Dominio;

public class Contacto
{
    public int IdContacto { get; set; }
    public int IdOportunidad { get; set; }
    public int IdViaContacto { get; set; }
    public DateTime Fecha { get; set; }
    public string? Observaciones { get; set; }
    public bool Contactado { get; set; }

    //contactado por defecto sera false?
    public static Result<Contacto> Generar(int idOportunidad, int idViaContacto, DateTime fecha, bool contactado, int? idContacto=null, string? observaciones=null)
    {
        
        if (idOportunidad == 0) return Result.Fail<Contacto>("____"); //idOportunidad se asocia solo cuando se crea un contacto dentro de la oportunidad, no?
        if (idViaContacto == 0) return Result.Fail<Contacto>("Se debe seleccionar una vía de contacto");
        //fecha? como se comprueba?

        Contacto contacto = new Contacto(idOportunidad, idViaContacto, fecha, contactado, idContacto, observaciones);
        return Result.Ok(contacto);
    }


    public Contacto(int idOportunidad, int idViaContacto, DateTime fecha, bool contactado, int? idContacto = null, string? observaciones = null)
    {
        if (idContacto != null) IdContacto = idContacto.Value;
        if (observaciones != null) Observaciones = observaciones; 
        IdOportunidad = idOportunidad;
        IdViaContacto= idViaContacto;
        Fecha = fecha;
        Contactado= contactado;


    }

    //List<Contacto> contactos = new List<Contactos>()
    //{
    //    new Contacto()
    //    {
    //        IdContacto = 1,
    //        IdOportunidad = 2,
    //        IdViaContacto= 4,
    //        Fecha = fecha,
    //        Contactado= true,
    //    },
    //    new Contacto()
    //    {
    //        IdContacto = 2,
    //        IdOportunidad = 2,
    //        IdViaContacto= 1,
    //        Fecha = fecha,
    //        Contactado= true,
    //    },
    //    new Contacto()
    //    {
    //        IdContacto = 3,
    //        IdOportunidad = 2,
    //        IdViaContacto= 3,
    //        Fecha = fecha,
    //        Contactado= true,
    //    },
    //    new Contacto()
    //    {
    //        IdContacto = 4,
    //        IdOportunidad = 1,
    //        IdViaContacto= 4,
    //        Fecha = fecha,
    //        Contactado= true,
    //    }
    //    new Contacto()
    //    {
    //        IdContacto = 4,
    //        IdOportunidad = 1,
    //        IdViaContacto= 1,
    //        Fecha = fecha,
    //        Contactado= false,
    //    }
    //}

}
