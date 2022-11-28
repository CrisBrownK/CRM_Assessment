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

}
