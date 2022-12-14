namespace XamlHotReloadIssue;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

        Application.Current.MainPage = new NavigationPage(new MainPage());
	}

    protected async override void OnStart()
    {
        base.OnStart();

        await Application.Current.MainPage.Navigation.PushModalAsync(new NavigationPage(new LoginPage()));

        string error_issue = """
                                        System.TypeInitializationException: The type initializer for 'Microsoft.AppCenter.Utils.ApplicationLifecycleHelperDesktop' threw an exception.
                     ---> System.IO.FileNotFoundException: Could not load file or assembly 'System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089' or one of its dependencies.
                    File name: 'System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
                       --- End of inner exception stack trace ---
                       at Microsoft.AppCenter.ApplicationLifecycleHelper.get_Instance()
                       at Microsoft.AppCenter.AppCenter..ctor()
                       at Microsoft.AppCenter.AppCenter.get_Instance()
                       at Microsoft.AppCenter.AppCenter.PlatformStart(String appSecret, Type[] services)
                       at Microsoft.AppCenter.AppCenter.Start(String appSecret, Type[] services)
                       at Invoices.Startup.AppStateMachine.ProccessState() in /Users/yiannis/Projects/Invoices-App-MAUI/src/Startup/AppStateMachine.cs:line 52
                       at Invoices.App.OnStart() in /Users/yiannis/Projects/Invoices-App-MAUI/src/Startup/App.xaml.cs:line 29
                    """;

        await Application.Current.MainPage.DisplayAlert("title", error_issue, "OK");

        var a = await Task.FromResult<bool>(true);
    }
}

