using System;
using System.Collections.Generic;

namespace Turmas_Cursos
{
    class Program
    {
        static void Main(string[] args)
        {
            HashSet<int> turma1 = new HashSet<int>();
            HashSet<int> turma2 = new HashSet<int>();
            HashSet<int> turma3 = new HashSet<int>();
            
           
            Console.Write("Quantos alunos estão cadastrados no curso A : ");
            int alunost1 = int.Parse(Console.ReadLine());
            for (int c = 0; c < alunost1; c++)
            {
                int aluno = int.Parse(Console.ReadLine());

                turma1.Add(aluno);
            }
            Console.Write("Quantos alunos estão cadastrados no curso B : ");
            int alunost2 = int.Parse(Console.ReadLine());
            for (int c = 0; c < alunost2; c++)
            {
                int aluno = int.Parse(Console.ReadLine());

                turma2.Add(aluno);

            }
            Console.Write("Quantos alunos estão cadastrados no curso C : ");
            int alunost3 = int.Parse(Console.ReadLine());
            for (int c = 0; c < alunost3; c++)
            {
                int aluno = int.Parse(Console.ReadLine());

                turma3.Add(aluno);
            }
            HashSet<int> todosAlunos = new HashSet<int>(turma1);
            todosAlunos.UnionWith(turma2);
            todosAlunos.UnionWith(turma3);
         

            Console.WriteLine("Alunos Cadastrados : " + todosAlunos.Count);
        }
    }
}
