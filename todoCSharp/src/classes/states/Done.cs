using todoCSharp.src.interfaces;

namespace todoCSharp.src.classes.states
{
  public class Done : ITodoState
  {
    private TodoItem todoItem;

    public Done(TodoItem todoItem)
    {
      this.todoItem = todoItem;
    }

    public void SetState()
    {
      // Reopen todo
      todoItem.State = new InProgress(todoItem);
    }

    public override string ToString()
    {
      return "Done";
    }
  }
}