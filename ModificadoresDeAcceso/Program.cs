using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModificadoresDeAcceso
{
    class Program
    {
        static void Main(string[] args)
        {
            Cliente cliente
            = new Cliente();

            cliente.Nombre = "Karen";
            cliente.Telefono = "123456";

            Console.WriteLine("Nombre: " + cliente.Nombre);
            Console.WriteLine("Telefono: " + cliente.Telefono);

            try
            {
                cliente.Curp = "123456789123456789";
                Console.WriteLine("Curp : " + cliente.Curp);
            }
            catch(Exception e)
            {
                Console.WriteLine("La CURP debe ser de 18 caracteres");
            }

            Cuenta cuenta
            = new Cuenta();
            try
            {
                cuenta.Identificador = "12345678912345";
                Console.WriteLine("Identificador : " + cuenta.Identificador);
            }
            catch (Exception e)
            {
                Console.WriteLine("El Identificador debe tener entre 10 y 14 caracteres");
            }

            
            Console.WriteLine("Saldo : " + cuenta.Saldo);

            Console.Read();
        }
    }    
}
