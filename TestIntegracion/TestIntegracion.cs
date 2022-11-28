using CRM_Api.Controllers;
using Dominio;
using Microsoft.AspNetCore.Mvc;

namespace TestIntegracion;

public class OportunidadesControllerTest
{
    [Fact]
    public void TestGet_DevuelveValueValorLista_Exito()
    {
        //IN PROGRESS
        OportunidadesController oportunidadesController = new OportunidadesController();

        IActionResult resultado = oportunidadesController.Get();

        OkObjectResult resultadoOk = resultado as OkObjectResult;
        var listado = resultadoOk.Value;

        //var resultado = oportunidadesController.Get();

        //Assert.Contains(resultado.FirstOrDefault(), "value2");

        Assert.Equal(typeof(List<Oportunidad>), listado.GetType());

    }
}
