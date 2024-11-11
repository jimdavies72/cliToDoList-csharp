using todoCSharp.src.interfaces;

namespace todoCSharp.src.classes.menu.actions
{
    public class AddTodoItem : IMenuAction
    {
        public void Action()
        {
            Console.WriteLine("Add todo item");
        }
    }
}