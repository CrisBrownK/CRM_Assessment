using CRM_Api.Controllers;
using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace TestIntegracion;

public class OportunidadesControllerTest
{
    [Fact]
    public void TestGet_DevuelveValueLista_Exito()
    {
        
        //Given

        List<Oportunidad> oportunidad = new List<Oportunidad>();


        //When

        new Oportunidad()
        {
            Nombre = "Cristina"

        };

        //Then

        Assert.Equal("Cristina", oportunidad[0].Nombre);
        

    }
}
