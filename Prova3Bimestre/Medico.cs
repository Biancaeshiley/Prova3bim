using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3Bimestre
{
    internal class Medico : Funcionario
    {
        public string CRM { get; set; }
        public double ValorHE { get; set; }
        public string especialdade { get; set; }

       public Medico() { }

        public Medico(string Nome, string CPF, string Matricula, DateTime Datanasc, string Sexo, double Salario, string cRM, double valorHE, string especialdade)
            : base (Nome, CPF, Matricula, Datanasc, Sexo, Salario)
        {
            CRM = cRM;
            ValorHE = valorHE;
            this.especialdade = especialdade;
        }
    }
}
