using System;
using System.Data;
using System.Runtime.InteropServices;
using todoCSharp.src.classes.menu;

namespace todoCSharp.src.classes.interaction
{
  public class Interaction
  {

    private Menu menu;

    public Interaction(Menu menu){
      this.menu = menu;
    }

    public void Interact(){
      string command = "";

      do
      {
        Console.Write("> ");

        command = Console.ReadLine()!.ToLower();
        if(ParseCommand(command, out int menuItemId))
        {
          GetMenuItem(menuItemId);
        } else
        {
          Console.WriteLine($"Command: {command} is not recognised");
        }

      } while (command != "0");
    }

    private bool ParseCommand(string command, out int menuItemId)
    {
      menuItemId = -1;

      if (command.Length > 0)
      {
        if(int.TryParse(command, out int id))
        {
          menuItemId = id;
          return true;
        };
      }

      return false;
    }

    private void GetMenuItem(int menuItemId)
    {
      if(menu.GetMenuItem(menuItemId, out MenuItem menuItem))
      {
        Console.WriteLine(menuItem);
      }

    }
  }
}