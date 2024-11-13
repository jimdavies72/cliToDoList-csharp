using todoCSharp.src.interfaces;

namespace todoCSharp.src.classes.menu.actions
{

  public class UpdateTodoItem : IAction
  {
    private TodoList todoList;
    private int id;
    private string name;
    private DateTime dueDate;
    private string description;

    public UpdateTodoItem(TodoList todoList, int id, string name, DateTime dueDate, string description)
    {
      this.todoList = todoList;
      this.id = id;
      this.name = name;
      this.dueDate = dueDate;
      this.description = description;
    }

    public void Execute()
    {
      todoList.UpdateItem(id, name, dueDate, description);
    }
  }
}