using Dominio;

namespace TestUnitario;

public class TestUsuario
{

    string nombre = "Cris";
    string apellido = "Guzman";
    string email = "cristina.guzman@prueba.es";
    string contraseña = "12345";

    [Fact]
    public void TestGenerar_TodosLosParametrosObligatorios_Exito()
    {
        //Arrange-Given


        //Act-When

        Result<Usuario> resultado =  Usuario.Generar(nombre, apellido, email, contraseña);

        //Assert-Then

        Assert.True(resultado.IsSuccess);

    }

    [Fact]
    public void TestGenerar_NombreVacio_Exito()
    {
        //Arrange-Given

        string nombre = "";

        //Act-When

        Result<Usuario> resultado = Usuario.Generar(nombre, apellido, email, contraseña);

        //Assert-Then

        Assert.False(resultado.IsSuccess);
        Assert.Equal("El nombre no puede ser nulo ni estar vacío", resultado.Error);

    }

    [Fact]
    public void TestGenerar_NombreNull_Exito()
    {
        //Arrange-Given

        //Act-When

        Result<Usuario> resultado = Usuario.Generar(null, apellido, email, contraseña);

        //Assert-Then

        Assert.False(resultado.IsSuccess);
        Assert.Equal("El nombre no puede ser nulo ni estar vacío", resultado.Error);

    }

    [Fact]
    public void TestGenerar_ApellidosVacio_Exito()
    {
        //Arrange-Given


        //Act-When

        Result<Usuario> resultado = Usuario.Generar(nombre, "", email, contraseña);

        //Assert-Then

        Assert.False(resultado.IsSuccess);
        Assert.Equal("Los apellidos no puede ser nulo ni estar vacío", resultado.Error);

    }

    [Fact]
    public void TestGenerar_ApellidosNull_Exito()
    {
        //Arrange-Given

        //Act-When

        Result<Usuario> resultado = Usuario.Generar(nombre, null, email, contraseña);

        //Assert-Then

        Assert.False(resultado.IsSuccess);
        Assert.Equal("Los apellidos no puede ser nulo ni estar vacío", resultado.Error);

    }

    [Fact]
    public void TestGenerar_EmailVacio_Exito()
    {
        //Arrange-Given


        //Act-When

        Result<Usuario> resultado = Usuario.Generar(nombre, apellido, "", contraseña);

        //Assert-Then

        Assert.False(resultado.IsSuccess);
        Assert.Equal("El email no puede ser nulo ni estar vacío", resultado.Error);

    }

    [Fact]
    public void TestGenerar_EmailNull_Exito()
    {
        //Arrange-Given

        //Act-When

        Result<Usuario> resultado = Usuario.Generar(nombre, apellido, null, contraseña);

        //Assert-Then

        Assert.False(resultado.IsSuccess);
        Assert.Equal("El email no puede ser nulo ni estar vacío", resultado.Error);

    }

    [Fact]
    public void TestGenerar_ContraseñaVacio_Exito()
    {
        //Arrange-Given


        //Act-When

        Result<Usuario> resultado = Usuario.Generar(nombre, apellido, email, "");

        //Assert-Then

        Assert.False(resultado.IsSuccess);
        Assert.Equal("La contraseña no puede ser nulo ni estar vacío", resultado.Error);

    }

    [Fact]
    public void TestGenerar_ContraseñaNull_Exito()
    {
        //Arrange-Given

        //Act-When

        Result<Usuario> resultado = Usuario.Generar(nombre, apellido, email, null);

        //Assert-Then

        Assert.False(resultado.IsSuccess);
        Assert.Equal("La contraseña no puede ser nulo ni estar vacío", resultado.Error);

    }


}
