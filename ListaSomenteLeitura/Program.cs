using System;
using System.Collections.Generic;

namespace ListaSomenteLeitura
{
    class Program
    {
        static void Main(string[] args)
        {
            //desta vez criamos um curso para conter a coleção de aulas
            Curso csharpColecoes = new Curso("C# Collections", "Relinton Pinheiro");
            //O método Adiciona encapsula a adição de novas aulas
            csharpColecoes.Adiciona(new Aula("Trabalhando com Listas", 21));
            Imprimir(csharpColecoes.Aulas);

            //Adiciona 2 aulas
            csharpColecoes.Adiciona(new Aula("Criando uma Aula", 20));
            csharpColecoes.Adiciona(new Aula("Modelando com Coleções", 18));
            Imprimir(csharpColecoes.Aulas);

            //Copiar a lista para outra lista
            List<Aula> aulasCopiadas = new List<Aula>(csharpColecoes.Aulas);

            //Ordenar a cópia
            aulasCopiadas.Sort();

            Imprimir(aulasCopiadas);

            //Totalizando o tempo do curso
            Console.WriteLine("O tempo do curso é " + csharpColecoes.TempoTotal);

            //Imprimir detalhes do curso???
            Console.WriteLine(csharpColecoes);

        }

        private static void Imprimir(IList<Aula> aulas)
        {
            Console.WriteLine();
            foreach (var aula in aulas)
            {
                Console.WriteLine(aula);
            }
        }
    }
}
