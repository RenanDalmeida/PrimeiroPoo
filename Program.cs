using System;

namespace PrimeiroPoo
{
    class Program
    {
        static void Main(string[] args)
        {
            Personagem tony = new Personagem();

            Console.WriteLine(tony.nome);

            Console.WriteLine(tony.armadura);

            Console.WriteLine(tony.Atacar());

        }
    }
}
