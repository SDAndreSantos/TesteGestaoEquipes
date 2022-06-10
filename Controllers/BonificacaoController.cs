using Microsoft.AspNetCore.Mvc;
using Teste_RH.Services;
using Teste_RH.Models;
using System;

namespace Teste_RH.Controllers;

[ApiController]
[Route("api/[controller]")]
public class BonificacaoController : ControllerBase
{
    [HttpPost(Name = "bonus")]
    public ActionResult<double> Post(Funcionario funcionario)
    {
        BonificacaoService service = new BonificacaoService();
        double bonus = service.GetBonus(funcionario);
        bonus = Math.Round(bonus, 2);
        return (bonus);
    }
}
