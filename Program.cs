using System;
namespace Clase_Animales
{
    class Program
    {
        static void Main(string[] args)
        {
            Utilidades.EnviarCorreo();

            Perro p = new Perro();
            p.Nombre = "Nombre de perro: Copito";
            p.Patas = 4 ;
            p.EsDomestico = true;
            p.Pelaje = "Peludo";
            p.Comer();
            p.Caminar();
            p.Ladrar();
            p.Color();
            

            Console.WriteLine(p.Nombre);
            Console.WriteLine(p.Patas);

            Gato g = new Gato();
            g.Nombre = "Nombre de gato: Lucrecia";
            g.Patas = 4 ;
            g.Pelaje = "Peludo";
            g.Comer();
            g.Caminar();
            g.Maullar();
            


            Console.WriteLine(g.Nombre);
            Console.WriteLine(g.Patas);

            Mono m = new Mono();
            m.Nombre = "Nombre de mono:Panchito";
            m.Patas = 4;
            p.EsDomestico = true;
            m.Pelaje = "Medio peludo";
            m.Comer();
            m.Caminar();
            m.Maullar();
            

            Console.WriteLine(m.Nombre);
            Console.WriteLine(m.Patas);

         }
    }
 }
