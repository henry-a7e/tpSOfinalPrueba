using System;
using System.Threading;

namespace tpfinalv3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            liebre();
            tortuga();
        }
        static void tortuga()
        {
            Console.Write("TORTUGA: ");
            var ran = new Random();
            int posicion = 0;
            while (posicion<70)
            {
                var probabilidad = ran.Next(1, 101);
                if (probabilidad >=1 && probabilidad<=50)
                {
                    posicion = posicion + 3;
                    if (posicion < 0)
                    {
                        posicion = 1;
                    }
                    else
                    {
                        Console.WriteLine($"Avance rápido, POSICION {posicion}");
                        Console.ReadKey();
                    }
                }
                else if (probabilidad>=51 && probabilidad<=70)
                {
                    posicion = posicion - 6;
                    if (posicion < 0)
                    {
                        posicion = 1;
                    }
                    else
                    {
                        Console.WriteLine($"Resbalo, POSICION {posicion}");
                        Console.ReadKey();
                    }
                }
                else if(probabilidad>=71 && probabilidad<=100)
                {
                    posicion = posicion + 1;
                    if (posicion < 0)
                    {
                        posicion = 1;
                    }
                    else 
                    {
                        Console.WriteLine($"Avance Lento, POSICION {posicion}");
                        Console.ReadKey();
                    }
                }
                if(posicion>=70)
                {
                    Console.WriteLine("LIEBRE HA LLEGADO A LA META");
                }
            }
        }
        static void liebre()
        {
            Console.Write("LIEBRE:");
            var ran = new Random();
            int posicion = 0;
            while (posicion<70)
            {
                var probabilidad = ran.Next(1, 101);
                if (probabilidad >=1 && probabilidad<=20)
                {
                    posicion = posicion + 0;
                    if (posicion < 0)
                    {
                        posicion = 1;
                    }
                    else
                    {
                        Console.WriteLine($"Duerme, POSICION {posicion}");
                        Console.ReadKey();
                    }
                }
                else if (probabilidad>=21 && probabilidad<=40)
                {
                    posicion = posicion + 9;
                    if (posicion < 0)
                    {
                        posicion = 1;
                    }
                    else
                    {
                        Console.WriteLine($"Gran Salto, POSICION {posicion}");
                        Console.ReadKey();
                    }
                }
                else if(probabilidad>=41 && probabilidad<=50)
                {
                    posicion = posicion - 12;
                    if (posicion < 0)
                    {
                        posicion = 1;
                    }
                    else
                    {
                        Console.WriteLine($"Resbalón grande, POSICION {posicion}");
                        Console.ReadKey();
                    }
                }
                else if(probabilidad>=51 && probabilidad<=80)
                {
                    posicion = posicion + 1;
                    if (posicion < 0)
                    {
                        posicion = 1;
                    }
                    Console.WriteLine($"Pequeño salto, POSICION {posicion}");
                    Console.ReadKey();
                }
                else if(probabilidad>=81 && probabilidad<=100)
                {
                    posicion = posicion - 2;
                    if (posicion < 0)
                    {
                        posicion = 1;
                    }
                    else
                    {
                        Console.WriteLine($"Resbalón pequeño, POSICION {posicion}");
                        Console.ReadKey();
                    }
                }
                if(posicion>=70)
                {
                    Console.WriteLine("LIEBRE HA LLEGADO A LA META");
                }
            }
        }
    }
}
