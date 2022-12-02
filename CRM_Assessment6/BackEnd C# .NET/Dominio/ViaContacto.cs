namespace Dominio;

public class ViaContacto
{
    public int IdViaContacto { get; set; }
    public string NombreViaContacto { get; set; }

    public ViaContacto(int idViaContacto, string nombreViaContacto)
    {
        IdViaContacto = idViaContacto;
        NombreViaContacto = nombreViaContacto;

    }

    //LISTA DE VIAS DE CONTACTO
    //List<ViaContacto> viaContactos = new List<ViaContacto>()
    //{
    //    new ViaContacto()
    //    {
    //        IdViaContacto = 1;
    //        NombreViaContacto = "Llamada";
    //    },
    //    new ViaContacto()
    //    {
    //        IdViaContacto = 2;
    //        NombreViaContacto = "Email";
    //    },
    //    new ViaContacto()
    //    {
    //        IdViaContacto = 3;
    //        NombreViaContacto = "Visita";
    //    },
    //    new ViaContacto()
    //    {
    //        IdViaContacto = 4;
    //        NombreViaContacto = "WhatsApp";
    //    }
    //}


}
