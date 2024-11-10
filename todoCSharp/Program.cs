using System.Globalization;
using todoCSharp.src.classes;

namespace todoCSharp;

class Program
{
    static void Main(string[] args)
    {
        TodoItem item = new TodoItem("Test", DateTime.Now, "Test Description");
        TodoItem item2 = new TodoItem("Test2", DateTime.Now, "Test Description2");
        TodoList todoList = new TodoList();
        todoList.AddItem(item);
        todoList.AddItem(item2);

        item.SetState();
        item.SetState();
        item.SetState();

        var iterator = todoList.CreateIterator();
        while (iterator.HasNext())
        {
            Console.WriteLine(iterator.Current());
            iterator.Next();
        }
        // or ....
        foreach (var todoItem in todoList.GetList())
        {
            Console.WriteLine(todoItem);
        }
    }
}
