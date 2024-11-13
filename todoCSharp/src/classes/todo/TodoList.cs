using todoCSharp.src.interfaces;
using todoCSharp.src.classes.utils;

namespace todoCSharp.src.classes
{
  public class TodoList
  {
    private List<TodoItem> todoList = new List<TodoItem>();

    public bool LoadData(string filePath)
    {
      if (JSONData.DeseriaizeJson<TodoItem>(filePath, out List<TodoItem> list))
      {
        todoList = list;
        return true;
      }

      return false;
    }

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

    // TODO: There must be a better way of doing this...
    public void UpdateItem(int id, string name, DateTime dueDate, string description)
    {
      var todoItem = todoList.Find(x => x.Id == id);
      if (todoItem == null) return;

      todoItem.Name = name;
      todoItem.DueDate = dueDate;
      todoItem.Description = description;
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