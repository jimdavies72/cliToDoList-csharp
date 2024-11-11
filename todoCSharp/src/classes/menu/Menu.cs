namespace todoCSharp.src.classes.menu
{
  public class Menu
  {
    private int menuId;
    public string MenuName { get; set; }
    public List<MenuItem> menuItems = new List<MenuItem>();

    public Menu(int menuId, string menuName)
    {
      this.menuId = menuId;
      MenuName = menuName;
    }

    public void AddItem(MenuItem menuItem)
    {
      menuItems.Add(menuItem);
    }

    public void RemoveItem(int id)
    {
      var menuItem = menuItems.Find(x => x.Id == id);
      if (menuItem == null) return;
      menuItems.Remove(menuItem);
    }

    public List<MenuItem> GetList()
    {
      return menuItems;
    }

    public override string ToString()
    {
      return String.Format("{0,3}: {1}", menuId, MenuName);
    }
  }
}