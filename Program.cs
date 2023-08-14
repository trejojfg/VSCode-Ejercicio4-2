using System;

namespace Ejercicio4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Un importante negocio de desinfectante líquido realiza descuentos dependiendo 
            //de la cantidad de litros vendidos según la siguiente escala:

            // -Si vende menos de 100 litros, no hay descuento.
            // -Si vende entre 101 y 300 litros, el descuento es del 10%.
            // -Si vende entre 301 y 500 litros, el descuento es del 15%.
            // -Finalmente, si la venta es de más de 500 litros, el descuento es del 25%.

            // Hacer un programa que solicite el ingreso del importe total de la venta 
            //y la cantidad de litros vendidos y calcule y emita el importe con el descuento  aplicado.
            
            float Venta, Litros;
            float TotalVenta = 0.00F;
            
            Console.WriteLine("Introduce los Litros");
            Litros = float.Parse(Console.ReadLine());
            Console.WriteLine("Introduce el importe de la venta");
            Venta = float.Parse(Console.ReadLine());

            if (Litros > 100 && Litros <= 300){
                TotalVenta = Venta * 0.9F;
            }else{ 
                if (Litros >300 && Litros <= 500){
                    TotalVenta = Venta * 0.85F;
                }else{
                    if (Litros > 500){
                        TotalVenta = Venta * 0.75F;
                    }else{
                        TotalVenta = Venta;
                    }
                }
            }
            Console.WriteLine("El importe total a pagar es: " + TotalVenta);
            
            Console.WriteLine("Fin del programa");
        }
    }
}
