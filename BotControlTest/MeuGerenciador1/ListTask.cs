using System;
using System.IO;


namespace ListAllTasks1{ 

    public class ListAlltasks{
        
        public static void ListTask(){
            string filePath = "tasks.txt";

            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);

                if (lines.Length == 0)
                {
                    Console.WriteLine("Nenhuma tarefa encontrada.");
                }
                else
                {
                    Console.WriteLine("Lista de Tarefas:");
                    foreach (string line in lines)
                    {
                        Console.WriteLine(line);
                    }
                }
            }
            else
            {
                Console.WriteLine("Arquivo de tarefas não encontrado.");
            }
        }
    }

}