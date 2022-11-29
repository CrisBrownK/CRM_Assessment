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

        Result<Oportunidad> resultado = Oportunidad.Generar(nombre, primerApellido, dni, telefono, email, idMotivo, contratado);

        Assert.True(resultado.IsSuccess);
    }

    [Fact]
    public void TestGenerar_NombreVacio_Exito()
    {
        //Arrange-Given

        //Act-When

        Result<Oportunidad> resultado = Oportunidad.Generar("", primerApellido, dni, telefono, email, idMotivo, contratado);

        //Assert-Then

        Assert.False(resultado.IsSuccess);
        Assert.Equal("El nombre no puede ser nulo ni estar vacío", resultado.Error);

    }

    [Fact]
    public void TestGenerar_NombreNull_Exito()
    {
        //Arrange-Given

        //Act-When

        Result<Oportunidad> resultado = Oportunidad.Generar(null, primerApellido, dni, telefono, email, idMotivo, contratado);

        //Assert-Then

        Assert.False(resultado.IsSuccess);
        Assert.Equal("El nombre no puede ser nulo ni estar vacío", resultado.Error);

    }


    [Fact]
    public void TestGenerar_PrimerApellidoVacio_Exito()
    {
        //Arrange-Given


        //Act-When

        Result<Oportunidad> resultado = Oportunidad.Generar(nombre, "", dni, telefono, email, idMotivo, contratado);

        //Assert-Then

        Assert.False(resultado.IsSuccess);
        Assert.Equal("El primer apellido no puede ser nulo ni estar vacío", resultado.Error);

    }

    [Fact]
    public void TestGenerar_PrimerApellidoNull_Exito()
    {
        //Arrange-Given

        //Act-When

        Result<Oportunidad> resultado = Oportunidad.Generar(nombre, null, dni, telefono, email, idMotivo, contratado);

        //Assert-Then

        Assert.False(resultado.IsSuccess);
        Assert.Equal("El primer apellido no puede ser nulo ni estar vacío", resultado.Error);

    }

    [Fact]
    public void TestGenerar_DniVacio_Exito()
    {
        //Arrange-Given


        //Act-When

        Result<Oportunidad> resultado = Oportunidad.Generar(nombre, primerApellido, "", telefono, email, idMotivo, contratado);

        //Assert-Then

        Assert.False(resultado.IsSuccess);
        Assert.Equal("El dni no puede ser nulo ni estar vacío", resultado.Error);

    }

    [Fact]
    public void TestGenerar_DniNull_Exito()
    {
        //Arrange-Given

        //Act-When

        Result<Oportunidad> resultado = Oportunidad.Generar(nombre, primerApellido, null, telefono, email, idMotivo, contratado);

        //Assert-Then

        Assert.False(resultado.IsSuccess);
        Assert.Equal("El dni no puede ser nulo ni estar vacío", resultado.Error);

    }

    [Fact]
    public void TestGenerar_TelefonoVacio_Exito()
    {
        //Arrange-Given


        //Act-When

        Result<Oportunidad> resultado = Oportunidad.Generar(nombre, primerApellido, dni, "", email, idMotivo, contratado);

        //Assert-Then

        Assert.False(resultado.IsSuccess);
        Assert.Equal("El telefono no puede ser nulo ni estar vacío", resultado.Error);

    }

    [Fact]
    public void TestGenerar_TelefonoNull_Exito()
    {
        //Arrange-Given

        //Act-When

        Result<Oportunidad> resultado = Oportunidad.Generar(nombre, primerApellido, dni, null, email, idMotivo, contratado);

        //Assert-Then

        Assert.False(resultado.IsSuccess);
        Assert.Equal("El telefono no puede ser nulo ni estar vacío", resultado.Error);

    }

    [Fact]
    public void TestGenerar_EmailVacio_Exito()
    {
        //Arrange-Given


        //Act-When

        Result<Oportunidad> resultado = Oportunidad.Generar(nombre, primerApellido, dni, telefono, "", idMotivo, contratado);

        //Assert-Then

        Assert.False(resultado.IsSuccess);
        Assert.Equal("El email no puede ser nulo ni estar vacío", resultado.Error);

    }

    [Fact]
    public void TestGenerar_EmaiNull_Exito()
    {
        //Arrange-Given

        //Act-When

        Result<Oportunidad> resultado = Oportunidad.Generar(nombre, primerApellido, dni, telefono, null, idMotivo, contratado);

        //Assert-Then

        Assert.False(resultado.IsSuccess);
        Assert.Equal("El email no puede ser nulo ni estar vacío", resultado.Error);

    }

}
