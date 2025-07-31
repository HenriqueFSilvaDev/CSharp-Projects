using System;
using System.IO;
using System.Linq;

namespace RemoveTask1{
    public class RemovingTask{
        public static void RemoveTask(int taskId)
        {
            string filePath = "tasks.txt";
            if (!File.Exists(filePath))
            {
                Console.WriteLine("Arquivo de tarefas não encontrado.");
                return;
            }
            string[] lines = File.ReadAllLines(filePath);
            bool updated = false;

            for (int i = 0; i < lines.Length; i++)
            {
                string[] parts = lines[i].Split(",");
                //Console.WriteLine($"Linha: {lines[i]}");
                if (int.Parse(parts[0]) == taskId){ 
                    lines[i] = "";
                    updated = true;
                    break;
                }
            }
            if (updated)
            {
                
                var cleanedLines = lines.Where(line => !string.IsNullOrWhiteSpace(line)).ToArray();
                File.WriteAllLines(filePath, cleanedLines);

                //File.WriteAllLines(filePath, lines);
                Console.WriteLine($"Tarefa com ID {taskId} removida");
            }
            else
            {
                Console.WriteLine($"Tarefa com ID {taskId} não encontrada.");
            }
        }
    }

}