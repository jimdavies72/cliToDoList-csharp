using todoCSharp.src.classes.utils.Colour;
using todoCSharp.src.classes.menu;
using todoCSharp.src.classes;
using todoCSharp.src.classes.menu.actions;

namespace todoCSharp;

class Program
{
    static void Main(string[] args)
    {

        // Code in here at the moment is merely for testing purposes

        MenuItem menuItem1 = new MenuItem(1, "Add Entry", new AddTodoItem());
        MenuItem menuItem2 = new MenuItem(2, "Remove Entry", new RemoveTodoItem());
        MenuItem menuItem3 = new MenuItem(0, "Exit", new ExitApp());

        Menu menu = new Menu(1, "Main Menu");
        menu.AddItem(menuItem1);
        menu.AddItem(menuItem2);
        menu.AddItem(menuItem3);

        Colour.Foreground("blue", () => Console.WriteLine($"\n{menu}\n"));
        foreach (var menuItem in menu.GetList())
        {
            Colour.Foreground("red", () => Console.WriteLine(menuItem));
        }

        Console.WriteLine("\n\n\n");

        menuItem1.Action();
        menuItem2.Action();
        menuItem3.Action();

        TodoItem item = new TodoItem("Test", DateTime.Now, "Test Description");
        TodoItem item2 = new TodoItem("Test2", DateTime.Now, "Test Description2");
        TodoList todoList = new TodoList();
        todoList.AddItem(item);
        todoList.AddItem(item2);

        item.SetState();

        var iterator = todoList.CreateIterator();
        while (iterator.HasNext())
        {
            Colour.Foreground("yellow", () => Console.WriteLine(iterator.Current()));
            iterator.Next();
        }
        // or ....
        // foreach (var todoItem in todoList.GetList())
        // {
        //     Colour.Foreground("red", () => Console.WriteLine(todoItem));
        // }
    }
}
