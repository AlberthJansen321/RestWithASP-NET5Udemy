using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RestWithASPNET5Udemy.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CalcularController : ControllerBase
    {

        private readonly ILogger<CalcularController> _logger;

        public CalcularController(ILogger<CalcularController> logger)
        {
            _logger = logger;
        }

        [HttpGet("get/{firstnumber}/{secondnumber}")]
        public IActionResult Get(string firstnumber, string secondnumber)
        {

            var numeros = firstnumber + secondnumber;
            decimal numero = 0;


            if (decimal.TryParse(numeros, out numero))
            {

                if (int.Parse(firstnumber) == 0 || int.Parse(secondnumber) == 0)
                {

                    decimal soma = decimal.Parse(firstnumber.Replace(".", ",")) + decimal.Parse(secondnumber.Replace(".", ","));
                    decimal multiplicacao = decimal.Parse(firstnumber.Replace(".", ",")) * decimal.Parse(secondnumber.Replace(".", ","));
                    decimal subtracao = decimal.Parse(firstnumber.Replace(".", ",")) - decimal.Parse(secondnumber.Replace(".", ","));
                    

                    return Ok($"O resultado da soma é igual a: {soma} \n" +
                       $"O resultado da subtração é igual a: {subtracao} \n" +
                        $"O resultado da multiplição é igual a: {multiplicacao} \n" +
                         $"O resultado da divião é igual a: {0} \n");
                }
                else
                {

                    decimal soma = decimal.Parse(firstnumber.Replace(".", ",")) + decimal.Parse(secondnumber.Replace(".", ","));
                    decimal multiplicacao = decimal.Parse(firstnumber.Replace(".", ",")) * decimal.Parse(secondnumber.Replace(".", ","));
                    decimal divisao = decimal.Parse(firstnumber.Replace(".", ",")) / decimal.Parse(secondnumber.Replace(".", ","));
                    decimal subtracao = decimal.Parse(firstnumber.Replace(".", ",")) - decimal.Parse(secondnumber.Replace(".", ","));

                    return Ok($"O resultado da soma é igual a: {soma} \n" +
                        $"O resultado da subtração é igual a: {subtracao} \n" +
                         $"O resultado da multiplição é igual a: {multiplicacao} \n" +
                          $"O resultado da divião é igual a: {divisao} \n");
                }
            }

            return BadRequest("Valor Inválido");


        }

        [HttpGet("sum/{firstnumber}/{secondnumber}")]
        public IActionResult Sum(string firstnumber, string secondnumber)
        {
            var numeros = firstnumber + secondnumber;
            decimal numero = 0;


            if (decimal.TryParse(numeros, out numero))
            {

                decimal soma = decimal.Parse(firstnumber.Replace(".", ",")) + decimal.Parse(secondnumber.Replace(".", ","));

                return Ok($"O resultado da soma é igual a: {soma}");
            }

            return BadRequest("Valor Inválido");


        }
        [HttpGet("sub/{firstnumber}/{secondnumber}")]
        public IActionResult Sub(string firstnumber, string secondnumber)
        {
            var numeros = firstnumber + secondnumber;
            decimal numero = 0;


            if (decimal.TryParse(numeros, out numero))
            {

                decimal subtracao = decimal.Parse(firstnumber.Replace(".", ",")) - decimal.Parse(secondnumber.Replace(".", ","));

                return Ok($"O resultado da subtração é igual a: {subtracao}");
            }

            return BadRequest("Valor Inválido");
        }
        [HttpGet("div/{firstnumber}/{secondnumber}")]
        public IActionResult Div(string firstnumber, string secondnumber)
        {
            var numeros = firstnumber + secondnumber;
            decimal numero = 0;


            if (decimal.TryParse(numeros, out numero))
            {

                decimal divisao = decimal.Parse(firstnumber.Replace(".", ",")) / decimal.Parse(secondnumber.Replace(".", ","));


                return Ok($"O resultado da divisão é igual a: {divisao}");
            }

            return BadRequest("Valor Inválido");
        }
        [HttpGet("mult/{firstnumber}/{secondnumber}")]
        public IActionResult Mult(string firstnumber, string secondnumber)
        {
            var numeros = firstnumber + secondnumber;
            decimal numero = 0;


            if (decimal.TryParse(numeros, out numero))
            {

                decimal multiplicacao = decimal.Parse(firstnumber.Replace(".", ",")) * decimal.Parse(secondnumber.Replace(".", ","));


                return Ok($"O resultado da multiplicação é igual: {multiplicacao}");
            }

            return BadRequest("Valor Inválido");
        }
        [HttpGet("rq/{firstnumber}")]
        public IActionResult Rq(string firstnumber)
        {
            var numeros = firstnumber;
            decimal numero = 0;


            if (decimal.TryParse(numeros, out numero))
            {

                decimal raizQuadrada = (decimal)Math.Sqrt(float.Parse(firstnumber));


                return Ok($"O resultado da raiz quadrada do número {firstnumber} é igual: {raizQuadrada}");
            }

            return BadRequest("Valor Inválido");
        }
    }
}
