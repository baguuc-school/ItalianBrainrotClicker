using ItalianBrainrotClicker.ViewModel;

namespace ItalianBrainrotClicker.Views;

public partial class EndView : ContentPage
{
	public EndView()
	{
		InitializeComponent();
		this.ScoreLabel.Text = $"Twój wynik: {GameManagerViewModel.GetInstance().Count}";
    }
}