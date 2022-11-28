using Dominio;

namespace TestUnitario;

public class TestUsuario
{
    [Fact]
    public void TestGenerar_TodosLosParametrosObligatorios_Exito()
    {
        //Arrange-Given

        string nombre = "Cristina";
        string apellido = "Guzman";
        string email = "cristina.guzman@prueba.es";
        string contraseña = "12345";

        //Act-When

        Result<Usuario> resultado =  Usuario.Generar(nombre, apellido, email, contraseña);

        //Assert-Then

        Assert.True(resultado.IsSuccess);

        
    }
}
