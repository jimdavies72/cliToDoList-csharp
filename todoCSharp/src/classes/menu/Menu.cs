using todoCSharp.src.classes.utils;
using todoCSharp.src.interfaces;

namespace todoCSharp.src.classes.menu
{
  // Command Invoker
  public class Menu
  {
    private int menuId;
    public string MenuName { get; set; }
    public List<MenuItem> menuItems = new List<MenuItem>();
    private IAction action;

    public Menu(int menuId, string menuName, IAction action)
    {
      this.menuId = menuId;
      MenuName = menuName;
      this.action = action;  
    }
    
    public void ExecuteAction(){
      action.Execute();
    }

    public bool LoadData(string filePath)
    {
      if (JSONData.DeseriaizeJson<MenuItem>(filePath, out List<MenuItem> list))
      {
        menuItems = list;
        return true;
      }

      return false;
    }

    public bool GetMenuItem(int id, out MenuItem menuItem)
    {
      menuItem = menuItems.FirstOrDefault(x => x.Id == id) ?? new MenuItem(-1, "");

      if (menuItem.Id == -1) return false;
      return true;
      
    }

    public void AddItem(MenuItem menuItem)
    {
      menuItems.Add(menuItem);
    }

    public void SetCommand(IAction action)
    {
      this.action = action;
    }


    public void RemoveItem(int id)
    {
      var menuItem = menuItems.Find(x => x.Id == id);
      if (menuItem == null) return;
      menuItems.Remove(menuItem);
    }

    public void DisplayMenu()
    {
      Colour.Foreground("blue", () => Console.WriteLine($"\n{this}\n"));
      foreach (var menuItem in menuItems)
      {
        Colour.Foreground("red", () => Console.WriteLine(menuItem));
      }

      Console.WriteLine("\n\n\n");
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