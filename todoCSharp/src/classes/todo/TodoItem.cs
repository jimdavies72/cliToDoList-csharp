using System.Globalization;
using todoCSharp.src.interfaces;
using todoCSharp.src.classes.states;
using System.Text.Json.Serialization;

namespace todoCSharp.src.classes
{
  public class TodoItem
  {
    private static int instances = 0;

    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }
    [JsonPropertyName("description")]
    public string Description { get; set; }
    [JsonPropertyName("dueDate")]
    public DateTime DueDate { get; set; }
    [JsonPropertyName("state")]
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

    public override string ToString()
    {
      return String.Format("{0,3}: {1,20} {2,11} {3,20} {4,12} ", Id, Name, DueDate.ToString("dd/M/yyyy", CultureInfo.InvariantCulture), Description, State);
    }
}
}