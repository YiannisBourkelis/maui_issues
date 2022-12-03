namespace SecureStorageMacCatalystIssue;

public partial class MainPage : ContentPage
{
	int count = 0;

	public MainPage()
	{
		InitializeComponent();
	}

	async private void OnCounterClicked(object sender, EventArgs e)
	{
		try
		{
			await SecureStorage.SetAsync("key", DateTime.Now.ToLongTimeString());

			var result = await SecureStorage.GetAsync("key");
            Console.WriteLine($"OK! Key value saved: {result}");
        }
		catch (Exception ex)
		{
			Console.WriteLine(ex);
			await DisplayAlert("Exception", ex.Message, "OK");
		}
    }
}


