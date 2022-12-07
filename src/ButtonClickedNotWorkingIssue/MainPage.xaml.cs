namespace ButtonClickedNotWorkingIssue;

public partial class MainPage : ContentPage
{

	public MainPage()
	{
		InitializeComponent();
	}


    void Button_Clicked(System.Object sender, System.EventArgs e)
    {
        Navigation.PushAsync(new MainPage());
    }
}


