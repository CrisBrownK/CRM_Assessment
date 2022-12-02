namespace Dominio;

public class Motivo
{
    public int IdMotivo { get; set; }
    public string NombreMotivo { get; set; }


    public Motivo(int idMotivo, string nombreMotivo)
    {
        IdMotivo = idMotivo;
        NombreMotivo = nombreMotivo;
    }

    //LISTA DE MOTIVOS DE OPORTUNIDAD (VENTAS)
    //List<Motivo> motivos = new List<Motivo>()
    //{
    //    new Motivo()
    //    {
    //        IdMotivo = 1;
    //        NombreMotivo = "Software NumberOne";
    //    },
    //    new Motivo()
    //    {
    //        IdMotivo = 2;
    //        NombreMotivo = "Sofware NumberTwo";
    //    }
    //}

}
