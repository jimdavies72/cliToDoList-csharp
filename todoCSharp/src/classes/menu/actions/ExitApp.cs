using todoCSharp.src.interfaces;

namespace todoCSharp.src.classes.menu.actions
{
  public class ExitApp : IAction
  {
    public void Execute()
    {
      Console.WriteLine("Goodbye!");
    }
  }
}