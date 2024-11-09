namespace todoCSharp.src.classes
{
  public class TodoList
  {
    private List<TodoItem> todoList = new List<TodoItem>();

    public void AddItem(TodoItem todoItem)
    {
      todoList.Add(todoItem);
    }

    public void RemoveItem(int id)
    {
      var todoItem = todoList.Find(x => x.Id == id);
      if (todoItem == null) return;
      todoList.Remove(todoItem);
    }

    public List<TodoItem> GetList()
    {
      return todoList;
    }
  }
}