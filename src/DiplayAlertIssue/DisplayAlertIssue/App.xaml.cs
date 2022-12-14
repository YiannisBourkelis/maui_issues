namespace DisplayAlertIssue;

public partial class App : Application
{
	public App()
	{
		InitializeComponent();

		MainPage = new NavigationPage(new MainPage());
	}

    /**
    protected override void OnStart()
    {
        base.OnStart();

        string message = """
                    System.TypeInitializationException: The type initializer for 'Microsoft.AppCenter.Utils.ApplicationLifecycleHelperDesktop' threw an exception.
                     ---> System.IO.FileNotFoundException: Could not load file or assembly 'System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089' or one of its dependencies.
                    File name: 'System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
                       --- End of inner exception stack trace ---
                       at Microsoft.AppCenter.ApplicationLifecycleHelper.get_Instance()
                    """;

        Application.Current.MainPage.DisplayAlert("Alert Title", message, "OK");

        //Application.Current.MainPage.DisplayAlert("Alert Title", "The message!", "OK");

    }
    */

    protected override Window CreateWindow(IActivationState activationState)
    {
        var window = base.CreateWindow(activationState);

        window.Activated += Window_Activated;

        return window;
    }

    static bool first_run = true;
    private void Window_Activated(object sender, EventArgs e)
    {
        if (first_run)
        {
            first_run = false;
            //displayAlert();
        }
    }

    void displayAlert()
    {
        string message = """
                    System.TypeInitializationException: The type initializer for 'Microsoft.AppCenter.Utils.ApplicationLifecycleHelperDesktop' threw an exception.
                     ---> System.IO.FileNotFoundException: Could not load file or assembly 'System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089' or one of its dependencies.
                    File name: 'System.Windows.Forms, Version=4.0.0.0, Culture=neutral, PublicKeyToken=b77a5c561934e089'
                       --- End of inner exception stack trace ---
                       at Microsoft.AppCenter.ApplicationLifecycleHelper.get_Instance()
                    """;

        Application.Current.MainPage.DisplayAlert("Alert Title", message, "OK");
    }
}

