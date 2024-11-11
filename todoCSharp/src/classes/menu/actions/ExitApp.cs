using todoCSharp.src.interfaces;

namespace todoCSharp.src.classes.menu.actions
{
    public class ExitApp : IMenuAction
    {
        public void Action()
        {
            Console.WriteLine("Goodbye!");
        }
    }
}