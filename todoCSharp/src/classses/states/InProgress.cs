using todoCSharp.src.interfaces;

namespace todoCSharp.src.classes.states
{
  public class InProgress : ITodoState
  {
    private TodoItem todoItem;

    public InProgress(TodoItem todoItem)
    {
      this.todoItem = todoItem;
    }

    public void SetState()
    {
      todoItem.State = new Done(todoItem);
    }

    public override string ToString()
    {
      return "In-Progress";
    }
  }
}