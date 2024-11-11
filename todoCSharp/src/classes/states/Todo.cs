using todoCSharp.src.interfaces;
using todoCSharp.src.classes;

namespace todoCSharp.src.classes.states
{
  public class Todo : ITodoState
  {
    private TodoItem todoItem;

    public Todo(TodoItem todoItem)
    {
      this.todoItem = todoItem;
    }

    public void SetState()
    {
      todoItem.State = new InProgress(todoItem);
    }

    public override string ToString()
    {
      return "To-do";
    }
  }
}