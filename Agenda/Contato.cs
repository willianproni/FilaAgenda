using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Agenda
{
    internal class Contato
    {
        public string Nome { get; set; }
        public float Telefone { get; set; }
        public int Idade { get; set; }
        public char Sexo { get; set; }

        public Contato(string nome, float telefone, int idade, char sexo)
        {
            Nome = nome;
            Telefone = telefone;
            Idade = idade;
            Sexo = sexo;
            Console.WriteLine("\n\t **Contato Adicionado com sucesso**");
        }

        public override string ToString()
        {
            return  $"\n\tNome: {Nome}" +
                    $"\n\tTelefone: {Telefone}" +
                    $"\n\tIdade: {Idade}" +
                    $"\n\tSexo: {Sexo}";
        }
    }
}
