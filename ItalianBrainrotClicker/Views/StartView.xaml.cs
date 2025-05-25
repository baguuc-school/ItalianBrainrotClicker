namespace ItalianBrainrotClicker.Views;

public partial class StartView : ContentPage
{
	public StartView()
	{
		InitializeComponent();
	}

    private void Button_Clicked(object sender, EventArgs e)
    {
		Navigation.PushAsync(new CharacterSelectionView());
    }
}