using Lifeflow.Domain;

namespace Lifeflow.Services
{
    public interface IFlowEditor
    {
        EditPage GetEditor(Flow flow);
    }
}