namespace Notes;

public partial class NewPage1 : ContentPage
{
	public NewPage1()
	{
		InitializeComponent();
	}

	private  async void LearnMore_Clicked(object sender, EventArgs e)
	{
		await Launcher.OpenAsync("https://www.google.com.br/");
	}
}