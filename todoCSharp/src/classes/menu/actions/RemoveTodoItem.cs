using todoCSharp.src.interfaces;

namespace todoCSharp.src.classes.menu.actions
{
    public class RemoveTodoItem : IMenuAction
    {
        public void Action()
        {
            Console.WriteLine("Remove todo item");
        }
    }
}