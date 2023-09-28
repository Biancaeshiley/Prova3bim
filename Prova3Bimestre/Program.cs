using Prova3Bimestre;
using System;
using System.Collections.Generic;

public class Prova
{
    static void Main(string[] args)
    {
        Console.WriteLine("Cadastrar Funcionário!! \n Escolha uma opção: ");
        Console.WriteLine("1 - Médico");
        Console.WriteLine("2 - Administrativo");
        Console.WriteLine("\n");

        int op = Convert.ToInt32(Console.ReadLine());

        while (true)
        {
            switch (op)
            {
                case 0:
                    Funcionario f = new Funcionario();
                    break;
                case 1:
                    Medico m = new Medico();
                    double AuPe = 22;
                    Console.WriteLine("\nMÉDICO");
                    Console.Write("\nInforme o nome: ");
                    m.Nome = Convert.ToString(Console.ReadLine());
                    Console.Write("Informe o CPF: ");
                    m.CPF = Convert.ToString(Console.ReadLine());
                    Console.Write("Informe a matrícula: ");
                    m.Matricula = Convert.ToString(Console.ReadLine());
                    Console.Write("Infome a data de nascimento: ");
                    m.Datanasc = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Informe o sexo: ");
                    m.Sexo = Convert.ToString(Console.ReadLine());
                    Console.Write("Informe o Salário: ");        
                    m.Salario = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Informe o valor da hora extra: ");
                    m.ValorHE = Convert.ToDouble(Console.ReadLine());
                    Console.Write("Informe a especialidade: ");


                    Console.WriteLine($"\nCADASTRADO COM SUCESSO!! \n\nNome: {m.Nome} \nCPF: {m.CPF} \nMatrícula: {m.Matricula}" +
                        $" \nData nascimento: {m.Datanasc} \nSexo: {m.Sexo} \nSalário: {m.Salario} \nValor Hora extra: {m.ValorHE} \nEspecialidade: {m.especialdade}");

                    Console.WriteLine("Com todas as ações , o salário do médico é de R$" + (m.Salario * AuPe));
                    break;

                case 2:
                    Administrativo a = new Administrativo();
                    double acre = 250;
                    double vale = 17;

                    Console.WriteLine("\nADMINISTRADOR");

                    Console.Write("\nInforme o nome: ");
                    a.Nome = Convert.ToString(Console.ReadLine());
                    Console.Write("Informe a função: ");
                    a.Funcao = Convert.ToString(Console.ReadLine());
                    Console.Write("Informe o CPF: ");
                    a.CPF = Convert.ToString(Console.ReadLine());
                    Console.Write("Informe a matricula: ");
                    a.Matricula = Convert.ToString(Console.ReadLine());
                    Console.Write("Infome a data de nascimento: ");
                    a.Datanasc = Convert.ToDateTime(Console.ReadLine());
                    Console.Write("Informe o sexo: ");
                    a.Sexo = Convert.ToString(Console.ReadLine());
                    Console.Write("Informe o Salário: ");
                    a.Salario = Convert.ToDouble(Console.ReadLine());

                    Console.WriteLine($"\nCADASTRADO COM SUCESSO!! \n\nNome: {a.Nome} \nFunção: {a.Funcao} \nCPF: {a.CPF} \nMatrícula: {a.Matricula}" +
                       $" \nData nascimento: {a.Datanasc} \nSexo: {a.Sexo} \nSalário: {a.Salario}");


                    Console.WriteLine("Com todos os acrésimos e vales, o salário do Administrador é de R$" + (a.Salario + acre * vale));

                    break;
                   

            }

            List<Medico> lisMed = new List<Medico>();
            lisMed.Add(new Medico());

            List<Administrativo> lisAdm = new List<Administrativo>();
            lisAdm .Add(new Administrativo());


        }

        Console.ReadKey();
    }
}