using System;
using System.Collections.Generic;

namespace O_Poder_Dos_Sets
{
    class Program
    {
        static void Main(string[] args)
        {
            //SETS = CONJUNTOS

            //Duas propriedades do Set
            //1. não permite duplicidade
            //2. os elementos não são mantidos em ordem específica

            //declarando set de alunos
            ISet<string> alunos = new HashSet<string>();
            //adicionando Vanessa, Ana e Rafael
            alunos.Add("Vanessa Tonini");
            alunos.Add("Ana Losnak");
            alunos.Add("Rafael Nercessian");

            //imprimindo
            Console.WriteLine(alunos);
            Console.WriteLine(string.Join(", ", alunos));

            //Qual a diferença para uma lista?? vamos ver agora  :)
            alunos.Add("Priscila Stuani");
            alunos.Add("Rafael Roloo");
            alunos.Add("Fabio Gushiken");
            Console.WriteLine(string.Join(", ", alunos));
            //e a ordem???

            //removendo ana, adicionando marcelo
            alunos.Remove("Ana Losnak");
            alunos.Add("Marcelo Oliveira");
            //Imprimindo de novo
            Console.WriteLine(string.Join(", ", alunos));
            //adicionando gushiken de novo
            alunos.Add("Fabio Gushiken");
            Console.WriteLine(string.Join(", ", alunos));

            //qual a vantagem do set sobre a lista? look-up!
            //desempenho HashSet x List: escalabilidade x memória



            //Ordenando: sort
            //alunos.Sort()
            List<string> alunosEmLista = new List<string>(alunos);
            alunosEmLista.Sort();
            Console.WriteLine(string.Join(", ", alunosEmLista));
        }
    }
}
