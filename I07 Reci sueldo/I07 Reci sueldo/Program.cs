/*Se debe pedir el ingreso por teclado del valor hora, el nombre, la antigüedad (en años) y la cantidad de horas trabajadas 
 en el mes de N cantidad de empleados de una fábrica.
Se pide calcular el importe a cobrar teniendo en cuenta que el total (que resulta de multiplicar el valor hora por la cantidad 
de horas trabajadas), hay que sumarle la cantidad de años trabajados multiplicados por $150, y al total de todas esas operaciones 
restarle el 13% en concepto de descuentos.
Mostrar el recibo correspondiente con el nombre, la antigüedad, el valor hora, el total a cobrar en bruto y el total a cobrar 
neto de todos los empleados ingresados.*/

using System;

namespace I07_Reci_sueldo
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string nombre;
            int valorHora;            
            int antiguedad;
            int cantHorasTrabajadas;
            int seguir = 1;
            float bruto;
            float neto;

            do
            {
                Console.WriteLine("Ingrese el valor de la hora");

                while(!int.TryParse(Console.ReadLine(), out valorHora))
                {
                    Console.WriteLine("Error, reingrese valor hora");
                }

                Console.WriteLine("Ingrese el nombre");
                nombre = Console.ReadLine();

                Console.WriteLine("Ingrese la antiguedad");

                while (!int.TryParse(Console.ReadLine(), out antiguedad))
                {
                    Console.WriteLine("Error, reingrese la antiguedad");
                }

                Console.WriteLine("Ingrese cantidad de horas trabajadas");

                while (!int.TryParse(Console.ReadLine(), out cantHorasTrabajadas))
                {
                    Console.WriteLine("Error, reingrese cantidad de horas trabajadas");
                }

                bruto = (valorHora * cantHorasTrabajadas) + (antiguedad * 150);

                neto = bruto - ((13 * bruto) / 100);

                Console.WriteLine("Nombre: {0}", nombre);
                Console.WriteLine("Antiguedad: {0}", antiguedad);
                Console.WriteLine("Valor hora: {0}", valorHora);
                Console.WriteLine("Bruto: {0}", bruto);
                Console.WriteLine("Neto: {0}", neto);

                Console.WriteLine("Para seguir 1, para salir 2");
                seguir = int.Parse(Console.ReadLine());

            } while (seguir == 1);
        }
    }
}
