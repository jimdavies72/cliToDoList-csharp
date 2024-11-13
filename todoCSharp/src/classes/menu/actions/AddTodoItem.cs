using todoCSharp.src.interfaces;

namespace todoCSharp.src.classes.menu.actions
{
  public class AddTodoItem : IAction
  {
    private TodoList todoList;
    private TodoItem todoItem;

    public AddTodoItem(TodoList todoList, TodoItem todoItem)
    {
      this.todoList = todoList;
      this.todoItem = todoItem;
    }

    public void Execute()
    {
      todoList.AddItem(todoItem);
    }
  }
}