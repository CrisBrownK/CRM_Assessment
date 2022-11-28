namespace Dominio;

public class Cliente
{
    public int IdCliente { get; set; }
    public int IdOportunidad { get; set; }
    public Oportunidad? Oportunidad { get; set; }
}
