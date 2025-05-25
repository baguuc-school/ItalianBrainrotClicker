using Plugin.Maui.Audio;
using ItalianBrainrotClicker.ViewModel;

namespace ItalianBrainrotClicker.Views;

public partial class GameView : ContentPage
{
    IDispatcherTimer timer;

	public GameView()
	{
		InitializeComponent();

		this.CharacterNameLabel.Text = GameManagerViewModel.GetInstance().CharacterManager.SelectedCharacter.name;
		this.MainButton.ImageSource = GameManagerViewModel.GetInstance().CharacterManager.SelectedCharacter.assets.srcImage;

        this.timer = Application.Current.Dispatcher.CreateTimer();
        timer.Interval = TimeSpan.FromSeconds(1);
        timer.Tick += (s, e) => RefreshTimeLeft();
        timer.Start();
    }

    private void RefreshTimeLeft()
    {
        GameManagerViewModel.GetInstance().TimeLeft--;
        this.ClockLabel.Text = $"{GameManagerViewModel.GetInstance().TimeLeft}s";

        if (GameManagerViewModel.GetInstance().TimeLeft == 0)
            Navigation.PushAsync(new EndView());
    }

    private void MainButtonClicked(object sender, EventArgs e)
    {
        GameManagerViewModel.GetInstance().Count++;
        PointsLabel.Text = GameManagerViewModel.GetInstance().Count.ToString();

        AudioManager.Current.CreatePlayer(GameManagerViewModel.GetInstance().CharacterManager.SelectedCharacter.assets.sound).Play();

        this.MainButton.Scale = 0.75;
        var t = Application.Current.Dispatcher.CreateTimer();
        t.Interval = TimeSpan.FromMilliseconds(50);
        t.Tick += (s, e) => {
            this.MainButton.Scale = 1;
            t.Stop();
        };
        t.Start();
    }
}