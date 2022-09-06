namespace OOP010ToolBox
{
    internal class ToolBox
    {
        public List<Tool> Tools { get; set; }
    }

    public enum ToolType { HandTools, PowerTools , Fasteners}

    public class Tool
    {
        private string name;
        private ToolType toolType;

        public Tool(){}
        public Tool(string name, ToolType type)
        {
            this.name = name;
            toolType = type;
        }
        public string Name {
            get { return name; }
            set { name = value; } 
        }
        public ToolType Type {
            get { return toolType; }
            set { toolType = value; }
        }
    }
}
