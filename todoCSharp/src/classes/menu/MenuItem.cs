using todoCSharp.src.interfaces;
using todoCSharp.src.classes.menu.actions;


namespace todoCSharp.src.classes.menu
{
  public class MenuItem
  {
    public int Id { get; set; }
    public string Name { get; set; }
    private IMenuAction action;

    public MenuItem(int id, string name, IMenuAction action)
    {
      Id = id;
      Name = name;
      this.action = action;
    }

    public void SetAction(IMenuAction action)
    {
      this.action = action;
    }

    public void Action()
    {
      action.Action();
    }

    public override string ToString()
    {
      return String.Format("{0,3}: {1}", Id, Name);
    }
  }
}