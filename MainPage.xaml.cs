namespace MauiApp1;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
		count++;

		if (count == 1)
			CounterBtn.Text = $"Clicked {count} time";
		else
			CounterBtn.Text = $"Clicked {count} times";

		DateTime current = DateTime.Now;

		DateTimeLabel.Text = current.ToLongDateString() + "\r\n" + current.ToLongTimeString();

        SemanticScreenReader.Announce(CounterBtn.Text);
	}
}

