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

        //OportunidadesController oportunidadesController = new OportunidadesController();

        //IActionResult resultado = oportunidadesController.Get();

        //OkObjectResult resultadoOk = resultado as OkObjectResult;
        //var listado = resultadoOk.Value;

        ////var resultado = oportunidadesController.Get();

        ////Assert.Contains(resultado.FirstOrDefault(), "value2");

        //Assert.Equal(typeof(List<Oportunidad>), listado.GetType());
        //-----------------------------------

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
