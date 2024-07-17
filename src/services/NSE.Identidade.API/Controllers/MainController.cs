using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace NSE.Identidade.API.Controllers;

[ApiController]
public class MainController : Controller
{
    protected ICollection<string> Errors = new List<string>();

    protected ActionResult CustomResponse(object result = null)
    {
        if (OperacaoValida()) return Ok(result);

        return BadRequest(new ValidationProblemDetails(new Dictionary<string, string[]>
        {
            {"Mensagens", Errors.ToArray() }
        }));
    }

    protected ActionResult CustomResponse(ModelStateDictionary modelState)
    {
        var erros = modelState.Values.SelectMany(e => e.Errors).ToList();
        erros.ForEach(erro => AdicionarErroProcessamento(erro.ErrorMessage));

        return CustomResponse();
    }

    protected bool OperacaoValida() => !Errors.Any();

    protected void AdicionarErroProcessamento(string erro) => Errors.Add(erro);

    protected void LimparErrosProcessamento() => Errors.Clear();
}
