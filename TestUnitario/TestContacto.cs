using Dominio;


namespace TestUnitario;

public class TestContacto
{
    int idOportunidad = 1;
    int idViaContacto = 1;
    DateTime fecha = new DateTime (2022, 12, 20, 17, 00, 00);
    bool contactado = false;

    [Fact]
    public void TestGenerar_TodosLosParametrosObligatorios_Exito()
    {
        Result<Contacto> resultado = Contacto.Generar(idOportunidad, idViaContacto, fecha, contactado);
        Assert.True(resultado.IsSuccess);
    }
}
