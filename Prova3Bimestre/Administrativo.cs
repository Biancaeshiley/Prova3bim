using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prova3Bimestre
{
    internal class Administrativo : Funcionario
    {
        public string Funcao { get; set; }

        public Administrativo() { }

        public Administrativo(string Nome, string CPF, string Matricula, DateTime Datanasc, string Sexo, double Salario, string funcao)
            : base(Nome, CPF, Matricula, Datanasc, Sexo, Salario)
        {
            Funcao = funcao;
        }

    }
}
