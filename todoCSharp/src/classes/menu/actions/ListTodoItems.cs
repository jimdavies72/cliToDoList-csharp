using todoCSharp.src.interfaces;
using todoCSharp.src.classes.utils;

namespace todoCSharp.src.classes.menu.actions
{
  public class ListTodoItems : IAction
  {
    private TodoList todoList;

    public ListTodoItems(TodoList todoList)
    {
      this.todoList = todoList;
    }

    public void Execute()
    {
      var iterator = todoList.CreateIterator();
      while (iterator.HasNext())
      {
        Colour.Foreground("yellow", () => Console.WriteLine(iterator.Current()));
        iterator.Next();
      }
      Console.WriteLine();
    }
  }
}