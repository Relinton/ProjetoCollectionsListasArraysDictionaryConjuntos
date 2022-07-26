﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;

namespace ListaSomenteLeitura
{
    class Curso
    {
        //campo privado contendo a lista de aulas
        private IList<Aula> aulas;

        /// <summary>
        /// Retornamos uma coleção somente leitura, isto é,
        /// ReadOnlyCollection, para proteger o campo privado aulas
        /// </summary>
        public IList<Aula> Aulas
        {
            get { return new ReadOnlyCollection<Aula>(aulas); }
        }

        /// <summary>
        /// Encapsula a adição de uma aula à coleção de aulas do curso
        /// </summary>
        /// <param name="aula">Aula a ser adicionada</param>
        internal void Adiciona(Aula aula)
        {
            this.aulas.Add(aula);
        }

        private string nome;
        private string instrutor;

        public Curso(string nome, string instrutor)
        {
            this.nome = nome;
            this.instrutor = instrutor;
            this.aulas = new List<Aula>();
        }

        public string Nome
        {
            get { return nome; }
            set { nome = value; }
        }

        public string Instrutor
        {
            get { return instrutor; }
            set { instrutor = value; }
        }

        public int TempoTotal
        {
            get
            {
                //int total = 0;
                //foreach (var aula in aulas)
                //{
                //    total += aula.Tempo;
                //}
                //return total;

                //Linq = Language Integrated Query
                //Consulta Integrada à Linguagem

                return aulas.Sum(aula => aula.Tempo);
            }
        }

        //Para impressão de detalhes do curso.
        public override string ToString()
        {
            return $"Curso: {nome}, Tempo: {TempoTotal},  Aulas: {string.Join(", ", aulas)}";
        }
    }
}
