namespace CustomNavRendererDemo;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		//MainPage = new AppShell();

		var customNavPage = new NavigationPage(new MainPage());
		MainPage = customNavPage;
    }
}

