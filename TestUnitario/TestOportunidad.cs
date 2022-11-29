using Dominio;

namespace TestUnitario;

public class TestOportunidad

{
    string nombre = "Maria";
    string primerApellido = "Gonzalez";
    string dni = "11233546f";
    string telefono = "6111111111";
    string email = "mariagonzalez@gmail.com";
    int idMotivo = 1;
    bool contratado = false; 


    [Fact]
    public void TestGenerar_TodosLosParametrosObligatorios_Exito()
    {


        //Result<Oportunidad> resultado = Oportunidad.Generar(nombre, primerApellido, dni, telefono, email, idMotivo, contratado);

        //Assert.True(resultado.IsSuccess);
    }

}
