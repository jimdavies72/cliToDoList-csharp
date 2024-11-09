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

        foreach (var i in todoList.GetList())
        {
            var display = String.Format("{0,3}: {1,20} {2,11} {3,20} {4,12} ", i.Id, i.Name, i.DueDate.ToString("dd/M/yyyy", CultureInfo.InvariantCulture), i.Description, i.State);
            Console.WriteLine(display);
        }
    }
}
