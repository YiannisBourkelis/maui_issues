namespace MauiPushModalAsyncIssue;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        MainPage = new NavigationPage(new MainPage());

        Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new LoginPage()));

        Console.WriteLine($"ModalStack count: {Application.Current.MainPage.Navigation.ModalStack.Count}");

    }
}

