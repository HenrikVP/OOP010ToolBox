using OOP010ToolBox;

ToolBox toolBox = new();

toolBox.Tools = new List<Tool>();

Tool t1 = new Tool();
t1.Name = "Hammer";
t1.Type = ToolType.HandTools;

Tool t2 = new Tool("Saw", ToolType.HandTools);

Tool t3 = new Tool() { Name = "Screwdriver", Type = ToolType.HandTools };

toolBox.Tools.Add(t1);
toolBox.Tools.Add(t2);
toolBox.Tools.Add(t3);

foreach (Tool t in toolBox.Tools)
{
    Console.WriteLine($"Tool: {t.Name} Type: {t.Type}");
}
