using Lifeflow.Services;

namespace Lifeflow;

public partial class MainPage : ContentPage
{
	int count = 0;
	private readonly IFlowEditor flowEditor;

	public MainPage(IFlowEditor flowEditor)
	{
		InitializeComponent();
		this.flowEditor = flowEditor;
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		SemanticScreenReader.Announce(CounterBtn.Text);
	}

	private void GoToEdit_Clicked(object sender, EventArgs e)
	{
        Navigation.PushAsync(this.flowEditor.GetEditor(new Domain.Flow()));
    }
}

