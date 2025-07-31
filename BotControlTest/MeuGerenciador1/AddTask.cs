
using System;
using System.IO;
//using System.Collections.Generic;
//using System.IO;
namespace addTask1
{
    public class addTaskProgram {

 
        public static void AddTask(string taskName)
        {
            string filePath = "tasks.txt";
            int nextId = 1;
            bool taskStatus = false;

            // Verifica se o arquivo existe e lê a última linha para obter o último ID
            if (File.Exists(filePath))
            {
                string[] lines = File.ReadAllLines(filePath);
                if (lines.Length > 0)
                {
                    string lastLine = lines[^1]; // Última linha
                    string[] parts = lastLine.Split(",");
                    //Console.WriteLine($"Parte em split: {parts[0]}");
                    if (parts.Length > 1 && int.TryParse(parts[0], out int lastId))
                    {
                        nextId = lastId + 1;
                    }
                }
            }

            // Escreve a nova tarefa com ID
            using (StreamWriter writer = new StreamWriter(filePath, append: true))
            {
                writer.WriteLine($"{nextId},{taskName},{taskStatus}");
            }
            Console.WriteLine($"Task {taskName} Adicionada!");
        }
    }
}