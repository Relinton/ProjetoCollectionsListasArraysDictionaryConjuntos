using System;
using System.Collections.Generic;
using System.Linq;

namespace Lista
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            ////Primeira forma de declarar aulas
            //List<string> aulas = new List<string>
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            //Segunda forma de declarar aulas
            List<string> aulas = new List<string>();
            aulas.Add(aulaIntro);
            aulas.Add(aulaModelando);
            aulas.Add(aulaSets);

            Imprimir(aulas);

            Console.WriteLine("A primeira aula é " + aulas[0]);
            Console.WriteLine("A primeira Aula é " + aulas.First());
            Console.WriteLine("A última Aula é " + aulas[aulas.Count - 1]);
            Console.WriteLine("A última Aula é " + aulas.Last());

            aulas[0] = "Trabalhando com Listas";
            Imprimir(aulas);

            Console.WriteLine("A primeira aula 'Trabalhando' é: "
                + aulas.First(aula => aula.Contains("Trabalhando")));

            Console.WriteLine("A última aula 'Trabalhando' é: "
                + aulas.Last(aula => aula.Contains("Trabalhando")));

            //Tenha cuidado ao utilizar First ou FirstOrDefault, pois First caso não encontre nada, retorna um erro que deve ser tratado.
            //Já o FirstOrDefault, ele retorna nullo, não dá erro.
            Console.WriteLine("A primeira aula 'Trabalhando' é: "
                + aulas.FirstOrDefault(aula => aula.Contains("Conclusão")));

            aulas.Reverse();
            Imprimir(aulas);

            aulas.Reverse();
            Imprimir(aulas);

            //Remover um elemento, nesse caso o último elemento.
            //RemoveAt, remove o elemento de uma posição específica.
            aulas.RemoveAt(aulas.Count - 1);

            //Adicionar nova aula
            aulas.Add("Conclusão");
            Imprimir(aulas);

            //Ordenar lista em ordem alfabética
            aulas.Sort();
            Imprimir(aulas);

            //GetRange -> obter faixas.
            //Obtendo as duas últimas aulas.
            List<string> copia = aulas.GetRange(aulas.Count - 2, 2);
            Imprimir(copia);

            List<string> clone = new List<string>(aulas);
            Imprimir(clone);

            //Remover elementos
            clone.RemoveRange(clone.Count - 2, 2);
            Imprimir(clone);
        }

        private static void Imprimir(List<string> aulas)
        {
            //Primeira forma 
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aula);
            //}

            //Segunda forma
            //for (int i = 0; i < aulas.Count; i++)
            //{
            //    Console.WriteLine(aulas[i]);
            //}

            //Terceira forma
            aulas.ForEach(aula =>
            {
                Console.WriteLine(aula);
            });
        }
    }
}
