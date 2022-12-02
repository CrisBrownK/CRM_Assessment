using System.Text.RegularExpressions;

namespace Dominio;

public class Usuario
{
    public int IdUsuario { get; protected set; }
    public string Nombre { get; protected set; }
    public string Apellidos { get; protected set; }
    public string Email { get; protected set; }
    public string Contraseña { get; protected set; }

    public static Result<Usuario> Generar(string nombre, string apellidos, string email, string contraseña, int? idUsuario=null)
    {
        if (string.IsNullOrEmpty(nombre)) return Result.Fail<Usuario>("El nombre no puede ser nulo ni estar vacío");
        if (string.IsNullOrEmpty(apellidos)) return Result.Fail<Usuario>("Los apellidos no puede ser nulo ni estar vacío");
        if (string.IsNullOrEmpty(email)) return Result.Fail<Usuario>("El email no puede ser nulo ni estar vacío");
        if (string.IsNullOrEmpty(contraseña)) return Result.Fail<Usuario>("La contraseña no puede ser nulo ni estar vacío");

        if (validarEmail(email) == false) return Result.Fail<Usuario>("El formato del email introducido no es válido");
        if (validarContraseña(contraseña) == false) return Result.Fail<Usuario>("La contraseña debe contener letras, números y carácteres especiales");


        Usuario usuario = new Usuario(nombre, apellidos, email, contraseña, idUsuario);
        return Result.Ok(usuario);

    }

    protected Usuario(string nombre, string apellidos, string email, string contraseña, int? idUsuario = null)
    {
        if(idUsuario != null) IdUsuario = idUsuario.Value;

        Nombre = nombre;
        Apellidos = apellidos;
        Email = email;
        Contraseña = contraseña; 

    }


    #region METODOS

    //Pendiente

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

    static bool validarContraseña(string contraseña)
    {
        
        if(contraseña.Length < 10 || contraseña.Length > 20) return false;

        return true;


    }

    #endregion


    //USUARIO
    //List<Usuario> usuarios = new List<Usuario>()
    //{
    //    new Usuario()
    //    {
    //        IdUsuario = 1;
    //        Nombre = "Rachel",
    //        Apellidos = "Green",
    //        Email = "Rachel.Green@gmail.com",
    //        Contraseña = "CentralPerk1"
    //    },
    //    
    //}


}
