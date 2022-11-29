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

    //contratado siempre será por defecto false, por lo que no se pone como opcional, no? 
    public static Result<Oportunidad> Generar(string nombre, string primerApellido, string dni, string telefono, string email, int idMotivo, bool contratado, int? idCliente = null, string? SegundoApellido = null, int? idOportunidad = null)
    {
        if (string.IsNullOrEmpty(nombre)) return Result.Fail<Oportunidad>("El nombre no puede ser nulo ni estar vacío");
        if (string.IsNullOrEmpty(primerApellido)) return Result.Fail<Oportunidad>("El primer apellido no puede ser nulo ni estar vacío");
        if (string.IsNullOrEmpty(dni)) return Result.Fail<Oportunidad>("El dni no puede ser nulo ni estar vacío");
        if (string.IsNullOrEmpty(telefono)) return Result.Fail<Oportunidad>("El telefono no puede ser nulo ni estar vacío");
        if (string.IsNullOrEmpty(email)) return Result.Fail<Oportunidad>("El email no puede ser nulo ni estar vacío");
        if (idMotivo == 0) return Result.Fail<Oportunidad>("Se debe seleccionar un motivo"); //duda
        //contrtado por defecto estará siempre relleno, aunque sea 'false', no?




        Oportunidad oportunidad = new Oportunidad(nombre, primerApellido, dni, telefono, email, idMotivo, contratado, idCliente, SegundoApellido, idOportunidad);
        return Result.Ok(oportunidad);
    }


    public Oportunidad(string nombre, string primerApellido, string dni, string telefono, string email, int idMotivo, bool contratado, int? idCliente = null, string? segundoApellido = null, int? idOportunidad = null)
    {
        if (idOportunidad != null) IdOportunidad = idOportunidad.Value;
        Nombre = nombre;
        PrimerApellido = primerApellido;
        Dni = dni;
        Telefono = telefono;
        Email = email;
        IdMotivo = idMotivo;
        Contratado = contratado;
        if(segundoApellido != null) SegundoApellido = segundoApellido;
        if (idCliente != null) IdCliente = idCliente.Value;


    }

}
