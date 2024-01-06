using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;

namespace Ejercicios
{
    /// <summary>
    /// Descripción breve de Saludo
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // Para permitir que se llame a este servicio web desde un script, usando ASP.NET AJAX, quite la marca de comentario de la línea siguiente. 
    // [System.Web.Script.Services.ScriptService]
    public class Saludo : System.Web.Services.WebService
    {
        [WebMethod]
        public string Saludar(string nombre)
        {
            return $"Hola, {nombre}";
        }

        [WebMethod]
        public int Sumar(int num1, int num2)
        {
            return num1 + num2;
        }

        [WebMethod]
        public int CalcularFactorial(int numero)
        {
            if (numero < 0)
            {
                // Manejar caso de número negativo (puede lanzar una excepción, retornar un valor especial, etc.)
                throw new ArgumentException("El factorial no está definido para números negativos.");
            }

            if (numero == 0 || numero == 1)
            {
                return 1; // El factorial de 0 y 1 es 1
            }

            int resultado = 1;
            for (int i = 2; i <= numero; i++)
            {
                resultado *= i;
            }

            return resultado;
        }
        [WebMethod]
        public string DecimalToBinary(decimal numeroDecimal)
        {
            int numeroEntero = (int)numeroDecimal;
            string binario = Convert.ToString(numeroEntero, 2);
            return binario;
        }

        [WebMethod]
        public decimal BinaryToDecimal(string binario)
        {
            int numeroDecimal = Convert.ToInt32(binario, 2);
            return Convert.ToDecimal(numeroDecimal);
        }
        [WebMethod]
        public string ConvertirBase(string numero, int baseOrigen, int baseDestino)
        {
            try
            {
                // Convierte el número de la base de origen a la base 10
                int base10Numero = Convert.ToInt32(numero, baseOrigen);

                // Convierte el número de la base 10 a la base de destino
                string resultado = Convert.ToString(base10Numero, baseDestino);

                return resultado;
            }
            catch (Exception ex)
            {
                return "Error: " + ex.Message;
            }
        }
    }

}




    


