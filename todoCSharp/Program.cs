
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

    string filePath = @"C:\Users\jimda\dev\c-sharp\todo-csharp\todocsharp\data\"; 

    string todoDataFileName = "todoData.json";

    TodoList todoList = new TodoList();
    if (!todoList.LoadData(filePath + todoDataFileName))
    {
      Console.WriteLine("Todo Data was not loaded");
    }

    string menuDataFileName = "menuData.json";
    Menu menu = new Menu(1, "Main Menu", new ListTodoItems(todoList));
    if (menu.LoadData(filePath + menuDataFileName))
    {
      menu.DisplayMenu();
      menu.ExecuteAction();
    } else
    {
      Console.WriteLine("Menu Data was not loaded");
    }

    Interaction interaction = new Interaction();

    interaction.Interact();

  }
}
