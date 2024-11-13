using System;
using System.Data;

namespace todoCSharp.src.classes.interaction
{
  public class Interaction
  {

    public void Interact(){
      string command = "";

      do
      {
        Console.Write("> ");
        command = Console.ReadLine()!.ToLower();
        if (command.Length > 0)
        {
          Console.WriteLine($"Your command was {command}");
        }

      } while (command != "exit");
    }
  }
}