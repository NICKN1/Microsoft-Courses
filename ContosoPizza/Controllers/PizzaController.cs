using ContosoPizza.Models;
using ContosoPizza.Services;
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
public class PizzaController : ControllerBase
{
    public PizzaController()
    {

    }

[HttpGet]
//Retorna uma instância de ActionResult do tipo List<Pizza>
//O tipo ActionResult é a classe base para todos os resultados da ação no ASP.NET Core
//Retorna o valor do tipo Content-Type igual ao application/json
public ActionResult<List<Pizza>> GetAll() => PizzaService.GetAll();

[HttpGet("{id}")]
//Requer que o valor do parâmetro id seja incluído no segmento da URL após pizza/. O atributo [Route] do nível do controlador definiu o padrão /pizza
//Consulta o banco de dados para uma pizza que corresponde ao parâmetro id fornecido
public ActionResult<Pizza> Get(int id)
{
    var pizza = PizzaService.GetById(id);

    if(pizza == null) return NotFound();

    return pizza;
}

    // POST action

    // PUT action

    // DELETE action
}