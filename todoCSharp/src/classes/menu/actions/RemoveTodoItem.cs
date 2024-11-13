using todoCSharp.src.interfaces;

namespace todoCSharp.src.classes.menu.actions
{
  public class RemoveTodoItem : IAction
  {
    private TodoList todoList;
    private int id;

    public RemoveTodoItem(TodoList todoList, int id)
    {
      this.todoList = todoList;
      this.id = id;
    }
    public void Execute()
    {
      todoList.RemoveItem(id);
    }
  }
}