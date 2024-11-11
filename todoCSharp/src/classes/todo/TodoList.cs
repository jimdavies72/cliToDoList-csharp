using todoCSharp.src.interfaces;

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

    public IIterator<TodoItem> CreateIterator()
    {
      return new TodoListIterator(this);
    }

    private class TodoListIterator : IIterator<TodoItem>
    {
      private readonly TodoList todoList;
      private int index;

      public TodoListIterator(TodoList todoList)
      {
        this.todoList = todoList;
        index = 0;
      }

      public TodoItem Current()
      {
        return todoList.todoList[index];
      }

      public bool HasNext()
      {
        return index < todoList.todoList.Count;
      }

      public void Next()
      {
        index++;
      }
    }

  }  
} //ns