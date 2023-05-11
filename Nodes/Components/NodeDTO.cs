namespace Nodes.Components
{
    public class NodeDTO
    {
        public string Name { get; set; }

        public List<NodeDTO> Nodes { get; set; } = new();
    }
}
