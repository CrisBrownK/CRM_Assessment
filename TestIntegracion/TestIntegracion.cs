using CRM_Api.Controllers;
using Dominio;
using Microsoft.AspNetCore.Mvc;
using System.Runtime.CompilerServices;

namespace TestIntegracion;

public class OportunidadesControllerTest
{
    [Fact]
    public void TestGet_DevuelveValueLista_Exito()
    {
        //Given

        OportunidadesController oportunidadesController = new OportunidadesController();

        List<Oportunidad> GetTestOportunidad()
        {
            List<Oportunidad> testOportunidad = new List<Oportunidad>();
            testOportunidad.Add(new Oportunidad
            {
                Dni = "123456F",
                Nombre = "Cristina",
                PrimerApellido = "Guzman",
                Email = "prueba@prueba"

            });

            return testOportunidad;

        }

        //When
        var testOportunidades = GetTestOportunidad();
        var resultado = oportunidadesController.Get();

        //Then

        Assert.Equal(testOportunidades.Count, resultado.Count);
        

    }


    
}
