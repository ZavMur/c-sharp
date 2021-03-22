using System;
public class Leon: Mamifero
{
    public string Pelaje { get; set; }
    public string Raza { get; set; }
    public bool EsFurioso { get; set; }

    public Leon() // Polimorfismo
    {
        EsFurioso = true;
    }

    public Leon(bool esFurioso) // Polimorfismo
    {
        EsFurioso = esFurioso;
    }
    public void Rugir()
    {
        Console.WriteLine("Me parecio ver un lindo gatito, que diga GAAATOTE");

    }

}