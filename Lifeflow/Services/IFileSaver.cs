using Lifeflow.Domain;

namespace Lifeflow.Services
{
    public interface IFileSaver
    {
        CurrentFlow ReadFlow();
        void WriteFlow(CurrentFlow flow);
    }
}