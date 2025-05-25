using ItalianBrainrotClicker.ViewModel;

namespace ItalianBrainrotClicker.Views;

public partial class CharacterSelectionView : ContentPage
{
	public CharacterSelectionView()
	{
		InitializeComponent();
		BindingContext = GameManagerViewModel.GetInstance();
    }

    private void MoveToGameView(object sender, EventArgs e)
    {
        Navigation.PushAsync(new GameView());
    }
}