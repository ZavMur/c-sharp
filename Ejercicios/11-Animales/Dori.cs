using System;

public class PezAzul: Acuaticos
{
    public string Memoria { get; set; }

    public void PerderMermoria()
    {
        Console.WriteLine("Hons toy?Que hacia?A donde iba?");
    }

    public void MemoryLost()
    {
        MemoriaPerdida();
    }

    private void MemoriaPerdida()
    {
        Console.WriteLine("Nadaremos Nadaharemos Nadaharemos...");
    }
}