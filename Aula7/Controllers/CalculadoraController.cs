using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Aula7.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Aula7.Controllers
{
    [Route("api/[controller]")]
    public class CalculadoraController : Controller
    {
        // POST api/values
        [HttpPost("Somar", Name = "Somar")]
        public double Somar([FromBody] Operacao operacao)
        {
            return operacao.Numero1 + operacao.Numero2;
        }

        [HttpPost("Subtrair", Name = "Subtrair")]
        public double Subtrair([FromBody] Operacao operacao)
        {
            return operacao.Numero1 - operacao.Numero2;
        }

        [HttpPost("Dividir", Name = "Dividir")]
        public double Dividir([FromBody] Operacao operacao)
        {
            return operacao.Numero1 / operacao.Numero2;
        }

        [HttpPost("Multiplicar", Name = "Multiplicar")]
        public double Multiplicar([FromBody] Operacao operacao)
        {
            return operacao.Numero1 * operacao.Numero2;
        }


    }
}
