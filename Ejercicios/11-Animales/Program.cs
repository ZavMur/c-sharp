using System;

namespace animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Leon l = new Leon();
            Console.WriteLine("-ZavMur-");
            Console.WriteLine("- Leon -");
            Console.WriteLine("-ZavMur-");
            l.Nombre = "Leonardo";
            l.Patas = 4;
            l.Pelaje = "Melena larga, Amarilla, Negra y Albinos";
            l.Raza = "Africana";
            l.Comer();
            l.Caminar();
            l.Rugir();
            l.EsFurioso = true;

            Console.WriteLine(l.Nombre);
            Console.WriteLine(l.Patas);
            Console.WriteLine(l.Pelaje);
            Console.WriteLine(l.Raza);         

            Console.WriteLine();

            Vaca v = new Vaca();
            Console.WriteLine("-ZavMur-");
            Console.WriteLine("- Vaca -");
            Console.WriteLine("-ZavMur-");
            v.Nombre = "Vaquita";
            v.Patas = 4;
            v.Comer();
            v.HaceMooo = true;
            v.Caminar();

            Console.WriteLine(v.Nombre);
            Console.WriteLine(v.Patas);

            Console.WriteLine();

            Condor c = new Condor();
            Console.WriteLine("--ZavMur--");
            Console.WriteLine("- Condor -");
            Console.WriteLine("--ZavMur--");
            c.Nombre = "Condorito";
            c.Patas = 2;
            c.Incubacion = 30;
            c.ColorPlumaje = "Normalmente Pelon en la cabeza blanco y negro";
            c.Volar();
            c.Comer();
            c.Hacerreir();

            Console.WriteLine(c.Nombre);
            Console.WriteLine(c.Incubacion);
            Console.WriteLine(c.Patas);
            Console.WriteLine(c.ColorPlumaje);

            Console.WriteLine();

            PapaGallo P = new PapaGallo();
            Console.WriteLine("----ZavMur----");
            Console.WriteLine("- PapaGallo  -");
            Console.WriteLine("----ZavMur----");
            

            Console.WriteLine();

            PezAzul d = new PezAzul();
            Console.WriteLine("---ZavMur---");
            Console.WriteLine("- Pez Azul -");
            Console.WriteLine("---ZavMur---");
            d.Nombre = "Dory";
            d.NumeroAletas = 2;
            d.Comer();
            d.Nadar();
            d.Color = "Azul con rayas negras";
            d.PerderMermoria();
            d.MemoryLost();

            Console.WriteLine(d.Nombre);
            Console.WriteLine(d.NumeroAletas);
            Console.WriteLine(d.Color);

            Tiburon t = new Tiburon();
            Console.WriteLine("---ZavMur----");
            Console.WriteLine("- Tiburonsin -");
            Console.WriteLine("---ZavMur----");
            t.Nombre = "Tiburonsin";
            t.NumeroAletas = 2;
            t.Comer();
            t.Nadar();
            t.Color = "Gris con Blanco";
 
            Console.WriteLine(t.Nombre);
            Console.WriteLine(t.NumeroAletas);
            Console.WriteLine(t.Color);

            }
        }
}