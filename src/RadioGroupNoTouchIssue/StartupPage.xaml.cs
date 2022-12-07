namespace RadioGroupTouchIssue;

public partial class StartupPage : ContentPage
{
	public StartupPage()
	{
		InitializeComponent();
	}

    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
		Navigation.PushAsync(new MainPage());
    }

    void Button_Clicked_1(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}
