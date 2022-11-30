using System.Data.SqlClient;
using System.Text.RegularExpressions;

namespace Dominio;

public class Oportunidad
{
    public int IdOportunidad { get; private set; }
    public int? IdCliente { get; private set; }
    public string Nombre { get; private set; }
    public string PrimerApellido { get; private set; }
    public string? SegundoApellido { get; private set; }
    public string Dni { get; private set; }
    public string Telefono { get; private set; }
    public string Email { get; private set; }
    public int IdMotivo { get; private set; }
    public bool Contratado { get; private set; }


    public static Result<Oportunidad> Generar(string nombre, string primerApellido, string dni, string telefono, string email, int idMotivo, bool contratado = false, int? idCliente = null, string? SegundoApellido = null, int? idOportunidad = null)
    {
        if (string.IsNullOrEmpty(nombre)) return Result.Fail<Oportunidad>("El nombre no puede ser nulo ni estar vacío");
        if (string.IsNullOrEmpty(primerApellido)) return Result.Fail<Oportunidad>("El primer apellido no puede ser nulo ni estar vacío");
        if (string.IsNullOrEmpty(dni)) return Result.Fail<Oportunidad>("El dni no puede ser nulo ni estar vacío");
        if (string.IsNullOrEmpty(telefono)) return Result.Fail<Oportunidad>("El telefono no puede ser nulo ni estar vacío");
        if (string.IsNullOrEmpty(email)) return Result.Fail<Oportunidad>("El email no puede ser nulo ni estar vacío");
        if (idMotivo <= 0) return Result.Fail<Oportunidad>("Se debe seleccionar un motivo");

        if (validarEmail(email) == false) return Result.Fail<Oportunidad>("El formato del email introducido no es válido");

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
        SegundoApellido = segundoApellido;
        if (idCliente != null) IdCliente = idCliente.Value;


    }



    #region METODOS

    static bool validarEmail(string email)
    {
        String expresion;
        expresion = "\\w+([-+.']\\w+)*@\\w+([-.]\\w+)*\\.\\w+([-.]\\w+)*";
        if (Regex.IsMatch(email, expresion))
        {
            if (Regex.Replace(email, expresion, String.Empty).Length == 0) return true;

        }
        return false;
    }

    

    #endregion






    //LISTA OPORTUNIDADES
    //List<Oportunidad> viaContactos = new List<Oportunidad>()
    //{
    //    new Oportunidad()
    //    {
    //        IdOportunidad = 1;
    //        Nombre = Ross;
    //        PrimerApellido = Gheller;
    //        Dni = 45896541L;
    //        Telefono = 655555555;
    //        Email = Ross.Gheller@hotmail.es;
    //        IdMotivo = 2;
    //        Contratado = false;

    //    },
    //    new Oportunidad()
    //    {
    //        IdOportunidad = 2;
    //        PrimerApellido = Buffay;
    //        Dni = 889666521F;
    //        Telefono = 6111111111;
    //        Email = Phoebe.Buffay@hotmail.com;
    //        IdMotivo = 2;
    //        Contratado = true;

    //    },
    //}

}
