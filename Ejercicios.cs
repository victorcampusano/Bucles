using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bucles
{
    public class Ejercicios
    {

        public void ej01()
        {
            double tarifa, horastrabajadas, horasextra, salario, tarifaextra;
            Console.WriteLine("ingrese horas trabajadas");
            horastrabajadas = double.Parse(Console.ReadLine());
            Console.WriteLine("ingrese tarifa");
            tarifa = double.Parse(Console.ReadLine());
            if (horastrabajadas <= 40 && horastrabajadas >= 0)
            {
                salario = horastrabajadas * tarifa;
                Console.WriteLine("el salario es: " + salario);
            }
            else if (horastrabajadas > 40)
            {
                horasextra = horastrabajadas - 40;
                tarifaextra = tarifa + 0.5 * tarifa;
                salario = horasextra * tarifaextra + 40 * tarifa;
                Console.WriteLine("el salario es: " + salario);
            }
            else
                Console.WriteLine("las horas trabajadas no pueden ser negativas");
            Console.ReadLine();
        }

    }
}
