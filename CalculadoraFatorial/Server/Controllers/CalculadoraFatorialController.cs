using CalculadoraFatorial.Server.Services;
using CalculadoraFatorial.Shared;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CalculadoraFatorial.Server.Controllers
{
    [ApiController]

    public class CalculadoraFatorialController : ControllerBase
    {
        [HttpPost]
        [Route("api/CalculadoraFatorial/CalcularFatorial")]
        public double CalcularFatorial([FromBody] double num1)
        {
            FatorialService fatServe = new FatorialService();

            return fatServe.funcaoFatorial(num1);

        }
    }
}