using Classe_R6.src;
using System;

namespace Classe_R6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Agentes Kapkan = new Agentes("Kapkan", "Rússia", "Dispositivo Bloqueador", 2, "Defesa");
            Agentes Sledge = new Agentes("Sledge", "Escócia", "Marreta de Demolição", 2, "Ataque");
            Agentes Thermite = new Agentes("Thermite", "Estados Unidos","Carga Explosiva", 3, "Ataque");
            Agentes Frost = new Agentes("Frost", "Canadá", "Capacho Armadilha", 3, "Defesa");


            Console.WriteLine(Kapkan.ToString());
            Console.WriteLine(Sledge.ToString());
            Console.WriteLine(Frost.ToString());
            Console.WriteLine(Thermite.ToString());  
            
        }
    }
}
