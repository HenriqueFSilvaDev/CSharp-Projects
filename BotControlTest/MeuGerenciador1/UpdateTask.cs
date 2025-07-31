using System;
using System.IO;


namespace updateTasksystem1{
    public class updateTasks{
        public static void UpdateTaskStatus(int taskId, bool statusMod)
        {
            string filePath = "tasks.txt";
            bool newStatus = statusMod;
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
                    lines[i] = $"{parts[0]},{parts[1]},{newStatus}";
                    Console.WriteLine($"Linha: {lines[i]}");
                    updated = true;
                    break;
                }
            }
            if (updated)
            {
                File.WriteAllLines(filePath, lines);
                Console.WriteLine($"Robo com ID {taskId} atualizado para status: {newStatus}");
            }
            else
            {
                Console.WriteLine($"Robo com ID {taskId} não encontrado.");
            }
        }

    }
}