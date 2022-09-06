using Lifeflow.Domain;

namespace Lifeflow.Services
{
    public class FlowEditor : IFlowEditor
    {
        private readonly IFileSaver fileSaver;

        public FlowEditor(IFileSaver fileSaver)
        {
            this.fileSaver = fileSaver;
        }

        public EditPage GetEditor(Flow flow)
        {
            return new EditPage(fileSaver, flow);
        }
    }
}