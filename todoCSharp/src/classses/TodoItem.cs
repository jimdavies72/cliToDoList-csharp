using todoCSharp.src.interfaces;
using todoCSharp.src.classes.states;

namespace todoCSharp.src.classes
{
  public class TodoItem
  {
    private static int instances = 0;

    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public DateTime DueDate { get; set; }
    public ITodoState State { get; set; }

    public TodoItem(string name,  DateTime dueDate, string description = "")
    {
      instances++;
      Id = GetIdCount();
      Name = name;
      DueDate = dueDate;
      Description = description;
      State = new Todo(this);
    }

    // added this for future referece but would not work in this case
    // ~TodoItem()
    // {
    //   instances--;
    // }

    public void SetState()
    {
      State.SetState();
    }

    private int GetIdCount()
    {
      return instances;
    }
}
}