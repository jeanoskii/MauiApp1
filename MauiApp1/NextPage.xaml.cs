namespace MauiApp1;

public partial class NextPage : ContentPage
{
	public NextPage()
	{
		InitializeComponent();
	}

    private void btnNextPage_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new NextPage());
    }

    private void btnLastPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PopAsync();
    }

    private void btnMainPage_Clicked(object sender, EventArgs e)
    {
        Navigation.PopToRootAsync();
    }
}