
using todoCSharp.src.classes.utils;
using todoCSharp.src.classes.menu;
using todoCSharp.src.classes;
using todoCSharp.src.classes.menu.actions;
using todoCSharp.src.classes.interaction;

namespace todoCSharp;

class Program
{
  static void Main(string[] args)
  {
    // Code in here at the moment is merely for testing purposes
    var config = Configuration.GetConfiguration();

    TodoList todoList = new TodoList();
    if (!todoList.LoadData(config["dataFilePath"] + config["todoDataFileName"]))
    {
      Console.WriteLine("Todo Data was not loaded");
    }

    Menu menu = new Menu(1, "Main Menu", new ListTodoItems(todoList));
    if (menu.LoadData(config["dataFilePath"] + config["menuDataFileName"]))
    {
      menu.DisplayMenu();
      menu.ExecuteAction();
      
      Interaction interaction = new Interaction(menu);
      interaction.Interact();
    } else
    {
      Console.WriteLine("Menu Data was not loaded");
    }
  }
}
