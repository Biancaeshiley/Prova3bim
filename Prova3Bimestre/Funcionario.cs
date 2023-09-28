using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3Bimestre
{
    internal class Funcionario
    {
        public string Nome { get; set; }
        public string CPF { get; set; }
        public string Matricula { get; set; }
        public DateTime Datanasc { get; set; }
        public string Sexo { get; set; }
        public double Salario { get; set; }


        public Funcionario() { }

        public Funcionario(string Nome, string CPF, string Matricula, DateTime Datanasc, string Sexo, double Salario)
        {
            this.Nome = Nome;
            this.CPF = CPF;
            this.Matricula = Matricula;
            this.Datanasc = Datanasc;
            this.Sexo = Sexo;
            this.Salario = Salario;
            
        }


    }
}
