using System;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            string aulaIntro = "Introdução às Coleções";
            string aulaModelando = "Modelando a Classe Aula";
            string aulaSets = "Trabalhando com Conjuntos";

            ////Primeira forma de declarar um Array implicitamente
            //string[] aulas = new string[]
            //{
            //    aulaIntro,
            //    aulaModelando,
            //    aulaSets
            //};

            //Segunda forma de declarar explicitamente um Array
            string[] aulas = new string[3];
            aulas[0] = aulaIntro;
            aulas[1] = aulaModelando;
            aulas[2] = aulaSets;

            Console.WriteLine(aulas);

            Imprimir(aulas);

            //Imprimir primeiro elemento
            Console.WriteLine(aulas[0]);
            //Imprimir último elemento
            Console.WriteLine(aulas[aulas.Length - 1]);

            //Trocar informações de um Array
            aulaIntro = "Trabalhando com Arrays";
            Imprimir(aulas);
            //Trocar informações de um Array precisa-se primeiro do índice.
            aulas[0] = "Trabalhando com Arrays";
            Imprimir(aulas);


            Console.WriteLine("Aula modelando está no índice " + Array.IndexOf(aulas, aulaModelando));
            Console.WriteLine(Array.LastIndexOf(aulas, aulaModelando));

            //Revertendo arrays
            Array.Reverse(aulas);
            Imprimir(aulas);

            //Revertendo array para o estado original
            Array.Reverse(aulas);
            Imprimir(aulas);

            //Reduzir tamanho do array
            Array.Resize(ref aulas, 2);
            Imprimir(aulas);

            //Voltando Array para o tamanho normal
            Array.Resize(ref aulas, 2);
            Imprimir(aulas);
            aulas[aulas.Length - 1] = "Conclusão";
            Imprimir(aulas);

            //Ordenar Array em Ordem Alfabética
            Array.Sort(aulas);
            Imprimir(aulas);

            ////Copiar Array para um outro Array
            //string[] copia = new string[2];
            //Array.Copy(aulas, 1, copia, 0, 2);
            //Imprimir(copia);
            //string[] clone = aulas.Clone() as string[];
            //Imprimir(clone);

            ////Limpar array de clone
            //Array.Clear(clone, 1, 2);
            //Imprimir(clone);


        }

        private static void Imprimir(string[] aulas)
        {
            ////Primeira forma de imprimir os elementos
            //foreach (var aula in aulas)
            //{
            //    Console.WriteLine(aulas);
            //}

            for (int i = 0; i < aulas.Length; i++)
            {
                Console.WriteLine(aulas[i]);
            }
        }
    }
}
