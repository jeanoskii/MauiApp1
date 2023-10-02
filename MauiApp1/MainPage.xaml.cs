using Android.Media;

namespace MauiApp1;

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
	}

    private void SubmitBtn_Clicked(object sender, EventArgs e)
    {
		lblName.Text = txtFName.Text + " " + txtLName.Text;
    }

    private async void btnImageUpload_Clicked(object sender, EventArgs e)
    {
		var result = await FilePicker.PickAsync(new PickOptions
		{
			PickerTitle = "Please select an image",
			FileTypes = FilePickerFileType.Images
		});
		if (result is null)
			return;
        lblImageName.Text = result.FileName;
		var stream = await result.OpenReadAsync();
		imgProfile.Source = ImageSource.FromStream(() => stream);
    }

    private async void btnFileUpload_Clicked(object sender, EventArgs e)
    {
		/*var result = await FilePicker.PickAsync(new PickOptions
		{
			PickerTitle = "Please select a text file",
			FileTypes = FilePicker
		});*/
    }

    private void btnNextPage_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new NextPage());
    }
}

