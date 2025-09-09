using System;

namespace recuperatorioprogramacion
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] nombresMeses = { "Enero", "Febrero", "Marzo", "Abril", "Mayo", "Junio" };
            double totalSemestre = 0;
            Random random = new Random();

            for (int i = 1; i <= 6; i++)
            {
                int mes = i;
                Console.WriteLine($"Mes {mes}: {nombresMeses[i - 1]}");
                double totalMes = 0;

                
                int numVentas = random.Next(1, 6);
                Console.WriteLine($"Generando {numVentas} ventas aleatorias para este mes.");

                for (int j = 0; j < numVentas; j++)
                {
                    
                    double monto = random.Next(5000, 150001);  
                    totalMes += monto;
                    Console.WriteLine($"Venta generada: ${monto}");
                }

                Console.WriteLine($"Total ventas mes {mes}: ${totalMes}");
                totalSemestre += totalMes;
                Console.WriteLine("");
            }

            Console.WriteLine($"Total ventas semestre (enero-junio): ${totalSemestre}");
            Console.ReadKey();  
        }
    }
}