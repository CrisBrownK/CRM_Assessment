namespace Dominio;

public class Cliente
{
    public int IdCliente { get; set; }
    public int IdOportunidad { get; set; }


    public Cliente(int idCliente, int idOportunidad)
    {
        IdCliente = idCliente;
        IdOportunidad= idOportunidad;
    }


    //List<Cliente> clientes = new List<Cliente>()
    //{
    //    new CLiente()
    //    {
    //        IdCliente = 1,
    //        IdOportunidad = 2, ((phoebe))
    //    }
    //}

}
