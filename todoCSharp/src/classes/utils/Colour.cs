namespace todoCSharp.src.classes.utils.Colour
{
  public static class Colour
  {
    //colours codes
    public static Dictionary<string, ConsoleColor> Colours = new Dictionary<string, ConsoleColor>()
    {
      { "red", ConsoleColor.Red },
      { "green", ConsoleColor.Green },
      { "yellow", ConsoleColor.Yellow },
      { "blue", ConsoleColor.Blue },
      { "magenta", ConsoleColor.Magenta },
      { "cyan", ConsoleColor.Cyan },
      { "white", ConsoleColor.White }
    };

    public static void Foreground(string colour, Action action)
    {
      try {
        if (Colours.TryGetValue(colour.ToLower(), out var value))
        {
          Console.ForegroundColor = value;
        } else
        {
          Console.ForegroundColor = ConsoleColor.White;
        }

        action.Invoke();
        Console.ResetColor();
      } catch (IOException) {
      }
    }
  }

}