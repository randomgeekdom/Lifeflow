namespace Lifeflow.Domain
{
    public class Flow
    {
        public List<FlowAction> FlowActions = new();
        public string Description { get; set; }
        public FlowType FlowType { get; set; }
        public string Name { get; set; }
    }
}