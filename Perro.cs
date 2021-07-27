using System;
public class Perro: Mamifero 
{
    public bool EsDomestico { get; set; }
    public string Pelaje { get; set; }

    public Perro() 
    {
        EsDomestico = true;
    }

    public Perro(bool esDomestico) 
    {
        EsDomestico = esDomestico;
    }

    public void Ladrar() 
    {
        Console.WriteLine("Gua gua gua");
    }

    public void     Color()
    {
        DescribirColor();
        OtroMetodo();
    }

    private void DescribirColor() 
    {
        Console.WriteLine("Perro Blanco");
    }

    private void OtroMetodo() 
    {

    }
}