using System;
public class Gato: Mamifero
{
    public string Pelaje { get; set; }

    public void Maullar()
    {
        Console.WriteLine("Miau miau miau");
    }
}