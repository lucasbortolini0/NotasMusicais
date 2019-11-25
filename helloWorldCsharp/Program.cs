using System;
using System.Collections.Generic;
using System.Linq;

namespace helloWorldCsharp
{
    class Program
    {
        static void Main(string[] args)
        {
            //Escala maior: Tom - Tom - Semitom - Tom - Tom - Tom - Semitom
            //Escala menor: Tom - Semitom - Tom - Tom - Tom - Tom - Semitom
            var notas = new List<string> {"C", "C#", "D", "D#", "E", "F", "F#", "G", "G#", "A", "A#", "B"};

            Console.WriteLine("Informe uma nota musical: ");
            var notaEscolhida = Console.ReadLine();

            var notasPrimeiraParte = notas.Take(notas.IndexOf(notaEscolhida));
            var notasSegundaParte = notas.Skip(notas.IndexOf(notaEscolhida)).Take(notas.Count);

            var notasArrumadas = notasSegundaParte.Concat(notasPrimeiraParte);

            Console.WriteLine("Escala maior");
            Console.WriteLine(notasArrumadas.ElementAt(0));
            Console.WriteLine(notasArrumadas.ElementAt(2));
            Console.WriteLine(notasArrumadas.ElementAt(4));
            Console.WriteLine(notasArrumadas.ElementAt(5));
            Console.WriteLine(notasArrumadas.ElementAt(7));
            Console.WriteLine(notasArrumadas.ElementAt(9));
            Console.WriteLine(notasArrumadas.ElementAt(11));

        }
    }
}