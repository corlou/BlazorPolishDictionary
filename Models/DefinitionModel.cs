public class Definition
{
    public required string English { get; set; }
    public required string Polish { get; set; }
}

public class DefinitionWithImage : Definition
{
  public required string Image { get; set; }
}

public class DefinitionWithImageLink : Definition
{
  public required string Image { get; set; }
  public required string Target { get; set; } 
}

public class DefinitionWithNumber
{
  public required string EnglishNumber { get; set; }
  public required string PolishNumber { get; set; }
  public required string PolishAge { get; set; }
  public required string PolishMoney { get; set; }
}

public class DefinitionPolish
{
    public required string Male { get; set; }
    public required string Female { get; set; }
    public required string Image { get; set; }
}