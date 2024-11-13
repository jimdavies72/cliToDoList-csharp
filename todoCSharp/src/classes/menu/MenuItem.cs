using System.Text.Json.Serialization;

namespace todoCSharp.src.classes.menu
{
  public class MenuItem
  {
    [JsonPropertyName("id")]
    public int Id { get; set; }
    [JsonPropertyName("name")]
    public string Name { get; set; }


    public MenuItem(int id, string name)
    {
      Id = id;
      Name = name;
    }

    public override string ToString()
    {
      return String.Format("{0,3}: {1}", Id, Name);
    }
  }
}