using Plugin.Maui.Audio;

namespace ItalianBrainrotClicker
{
    public partial class MainPage : ContentPage
    {
        private readonly IAudioPlayer _player;

        public MainPage()
        {
            InitializeComponent();

            var audioManager = AudioManager.Current;
            var stream = FileSystem.OpenAppPackageFileAsync("gusini.mp3").Result;
            _player = audioManager.CreatePlayer(stream);
        }

        private void OnPlaySoundClicked(object sender, EventArgs e)
        {
            _player.Play();
        }
    }

}
