using System.IO;
using System.Text.Json;

namespace todoCSharp.src.classes.utils
{
  public static class JSONData
  {
    public static bool ReadFile(string filePath, out string text)
    {
      text = "";
      try
      {
        text = File.ReadAllText(filePath);
        return true;
      } catch (Exception e)
      {
        Console.WriteLine($"Error: {e.Message}");
        return false;
      }
    }

    public static bool DeseriaizeJson<T>(string filePath, out List<T> list)
    {
      list = new List<T>();
      try
      {
        if (ReadFile(filePath, out string json))
        {
          list = JsonSerializer.Deserialize<List<T>>(json)!;
          return true;
        }

        return false;
        
      } catch (Exception e)
      {
        Console.WriteLine($"Error: {e.Message}"); 
        return false;
      }
    }
  }
}