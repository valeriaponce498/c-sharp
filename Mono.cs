using System;
public class Mono: Mamifero
{
    public string Pelaje { get; set; }


    public bool EsDomestico { get; set; }

    public Mono() 
    {
        EsDomestico = true;
    }

    public Mono(bool esDomestico) 
    {
        EsDomestico = esDomestico;
    }

    public void Maullar()
    {
        Console.WriteLine("Uaaa aaahhhh ahhh");
    }
}