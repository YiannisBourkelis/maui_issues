﻿namespace LayoutCycleFlexLayoutIssue;

public partial class MainPage : ContentPage
{
	public MainPage()
	{
		InitializeComponent();
	}

	private void OnCounterClicked(object sender, EventArgs e)
	{
        Application.Current.MainPage.Navigation.PushAsync(new LayoutCyclePage());
    }
}

