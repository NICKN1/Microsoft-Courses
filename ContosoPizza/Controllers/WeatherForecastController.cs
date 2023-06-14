using Microsoft.AspNetCore.Mvc;

namespace ContosoPizza.Controllers;

//ApiController habilita comportamentos dogmáticos que facilita a criação de APIs Web
/*Alguns são: Inferência de parâmetro de origem de associação que define o local no qual o valor do parâmetro
de uma ação é encontrado Ex = [FromBody] [FromHeader], [FromRoute]
Roteamento de Atributo torna acessível rotas(definidas por UseEndpoints) que por meio convencionais não seria possível
Aprimoramentos de erros de validação de modelo o que faz disparar o erro HTTP 400*/
[ApiController]
/*Route define o padrão de roteamento, e o controller lida com solicitações para o link em questão*/
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    private static readonly string[] Summaries = new[]
    {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

    private readonly ILogger<WeatherForecastController> _logger;

    public WeatherForecastController(ILogger<WeatherForecastController> logger)
    {
        _logger = logger;
    }

    [HttpGet(Name = "GetWeatherForecast")]
    public IEnumerable<WeatherForecast> Get()
    {
        return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        {
            Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
            TemperatureC = Random.Shared.Next(-20, 55),
            Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        })
        .ToArray();
    }
}
