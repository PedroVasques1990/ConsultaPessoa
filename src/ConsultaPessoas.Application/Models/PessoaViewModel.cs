using System;

namespace ConsultaPessoas.Application.Models
{
    public class PessoaViewModel
    {
        public Guid Id { get; private set; }
        public string Nome { get; private set; }
        public string DataNascimento { get; private set; }

        public string Cpf { get; private set; }
        public int Idade { 
            get 
            {
                return Calcularidade();
            } 
        }

        private int Calcularidade()
        {
            DateTime dataAtual = DateTime.Now;
            DateTime dataNascimento = DateTime.Parse(this.DataNascimento);
            
            int idade = dataAtual.Year - dataNascimento.Year;

            return dataAtual.DayOfYear < dataNascimento.DayOfYear ? idade - 1 : idade;
        }
    }
}