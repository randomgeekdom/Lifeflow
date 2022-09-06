using Lifeflow.Domain;
using Lifeflow.Services;

namespace Lifeflow;

public partial class EditPage : ContentPage
{
    private IFileSaver fileSaver;
    private Flow flow;

    public EditPage(IFileSaver fileSaver, Flow flow)
    {
        this.fileSaver = fileSaver;
        this.flow = flow;
    }
}

