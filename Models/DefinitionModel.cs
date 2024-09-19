public class Definition
{
    public required string English { get; set; }
    public required string Polish { get; set; }
}

public class DefinitionWithImage : Definition
{
  public required string Image { get; set; }
}

public class HomeDefinitionWithImage : Definition
{
  public required string Image { get; set; }
  public required string Target { get; set; } 
}