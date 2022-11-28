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
        return null;
    }

}
