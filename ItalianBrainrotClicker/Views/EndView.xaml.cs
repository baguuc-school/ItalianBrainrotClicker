using ItalianBrainrotClicker.ViewModel;

namespace ItalianBrainrotClicker.Views;

public partial class EndView : ContentPage
{
	public EndView()
	{
		InitializeComponent();
		this.ScoreLabel.Text = $"Tw�j wynik: {GameManagerViewModel.GetInstance().Count}";
    }
}