namespace DisplayAlertIssue;

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

		SemanticScreenReader.Announce(CounterBtn.Text);

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


