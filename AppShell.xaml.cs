namespace MauiApp1;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(DetailPage), typeof(DetailPage));	//instead of hard coding the string of the detail page, nameof() and typeof() will update it if page is updated. 
	}
}
