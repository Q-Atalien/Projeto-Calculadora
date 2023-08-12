using Microsoft.AspNetCore.Mvc;
using System.Web.Http;

namespace Calculadora.Controllers
{
    [Microsoft.AspNetCore.Mvc.Route("api/[controller]")]
    [ApiController]
    public class CalculadoraController : ControllerBase
    {
        [Microsoft.AspNetCore.Mvc.HttpPost]
        [System.Web.Http.Route("calcular")]
        public IActionResult Calcular([System.Web.Http.FromBody] CalculadoraRequest request)
        {
            try
            {
                double resultado = EvaluateExpression(request.Expression);
                return Ok(new { Result = resultado });
            }
            catch
            {
                return BadRequest("Erro ao calcular expressão.");
            }
        }

        private double EvaluateExpression(string expression)
        {
            // Implemente aqui a lógica para avaliar a expressão e retornar o resultado.
            // Você pode usar bibliotecas de parsing de expressões matemáticas ou implementar a lógica manualmente.
            // Por simplicidade, vou apenas usar a função eval para este exemplo, mas não é recomendado para uso em produção.

            return (double)Microsoft.JScript.Eval.JScriptEvaluate(expression, null);
        }
    }

    public class CalculadoraRequest
    {
        public string Expression { get; set; }
    }


}
