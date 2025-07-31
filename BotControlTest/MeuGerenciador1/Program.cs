using System;
using addTask1;
using ListAllTasks1;
using updateTasksystem1;
using RemoveTask1;
//using System.Collections.Generic;
//using System.IO;


namespace MeuGerenciador1
{
    class Program
    {
        static void Main(string[] args)
        {
            string taskTipo = "";
            int taskID = 0;
            Console.WriteLine("Escolha a acao: (1-AdicionarRobo, 2-ListarRobo, 3-LigarRobo, 4-DesligarRobo, 5-RemoverRobo)");
            int acao = Convert.ToInt32(Console.ReadLine());
            Acao(acao, taskTipo, taskID);
        }

        public static void Acao(int x, string task, int id)
        {
            switch(x){                
                case 1:
                    //Adicionar
                    Console.WriteLine("Escolha o Robo!"); // mudar para uma função de adicionar o caminho do robo
                    task = Console.ReadLine();                    
                    addTaskProgram.AddTask(task);
                    break;
                case 2:   
                    //Listar Tarefas
                    ListAlltasks.ListTask();
                    break;
                case 3:
                    //Ligar Robo
                    Console.WriteLine("Escolha o ID do Robo que queira Ligar"); // alterar com função usando widow
                    id = Convert.ToInt32(Console.ReadLine());             
                    updateTasks.UpdateTaskStatus(id, true);
                    break;
                case 4:
                    //Desligar Robo
                    Console.WriteLine("Escolha o ID do Robo que queira Desligar"); // alterar com função usando widow
                    id = Convert.ToInt32(Console.ReadLine());             
                    updateTasks.UpdateTaskStatus(id, false);
                    break;
                case 5:
                    //Remover Robo
                    Console.WriteLine("Escolha o ID que deseja Remover");
                    id = Convert.ToInt32(Console.ReadLine());    
                    RemovingTask.RemoveTask(id);
                    break;
                //default
                default:
                    Console.WriteLine(@$"Ação {x} não definida no escopro
                    + teste de string verbatim.");
                    break;
            }
        }
    }
}
