namespace Lifeflow.Domain
{
    public class CurrentFlow
    {
        public FlowAction Action { get; set; }
        public Flow Flow { get; set; }
        public List<Flow> Flows { get; set; }
    }
}