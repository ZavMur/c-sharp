using System;
public abstract class Mamifero: Metazoos 
{
    public int Patas { get; set; }

    public void Caminar()
    {
        Console.WriteLine("Caminando o corriendo, escapando por tu vida Corre, corre, coreee..."); 
    }

}