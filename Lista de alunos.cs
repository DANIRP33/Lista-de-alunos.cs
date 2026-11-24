using System;
					
public class Program
{

    public static void Main()
    {
        String[] alunos = new String[6];
        String aluno_busca;
		String resposta;
		
        
		
        for (int i = 0; i <= 5; i++)
        {
            Console.WriteLine("Digite o nome do aluno " + (i + 1) + ":");
            alunos[i] = Console.ReadLine();
        }
        
        for (int i = 0; i <= 5; i++) 
        {
            Console.WriteLine(alunos[i]);
        }
        
        Console.WriteLine("DIGITE O NOME DO ALUNO QUE DESEJA ENCONTRAR:");
        aluno_busca = Console.ReadLine();
        
        for (int i = 0; i <= 5; i++)
        {
            if (alunos[i] == aluno_busca)
            {
                Console.WriteLine("Aluno encontrado");
                Console.WriteLine("O aluno " + aluno_busca + " foi encontrado na posição " + i + " do vetor");
                
               
                Console.WriteLine("Deseja editar o nome deste aluno? (S/N)");
				 resposta = Console.ReadLine();

                if (resposta == "Sim" || resposta == "sim")
                {
                    Console.WriteLine("Digite o novo nome:");
                    alunos[i] = Console.ReadLine();
                    Console.WriteLine("Nome alterado com sucesso para: " + alunos[i]);
                }
                else
                {
                    Console.WriteLine("Ok, o nome não foi alterado.");
                }

            }
        }
    }
}
