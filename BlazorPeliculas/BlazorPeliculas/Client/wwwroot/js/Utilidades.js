function pruebaPuntoNetStatic()
{
    DotNet.invokeMethodAsync("BlazorPeliculas.Client", "ObtenerCurrentCount").then(resultado => {
        console.log("conteo desde javaScript" + resultado);
    });
}

function pruebaPuntoNetInstancia(dotnetHelper)
{
    dotnetHelper.invokeMethodAsync("HazmeClick");
}