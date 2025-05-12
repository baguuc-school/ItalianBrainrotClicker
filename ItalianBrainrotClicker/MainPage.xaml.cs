using System.IO;
using Plugin.Maui.Audio;

namespace ItalianBrainrotClicker
{
    public partial class MainPage : ContentPage
    {
        private readonly Random random = new Random();
        private Character[] characters =
        {
            new Character("tung_tung_tung_sahur.mp3", "tung_tung_tung_sahur.jpg"),
            new Character("brr_brr_patapim.mp3", "brr_brr_patapim.jpg"),
            new Character("ballerina_cappucina.mp3", "ballerina_cappucina.jpg")
        };

        Character character;

        public MainPage()
        {
            InitializeComponent();

            character = characters[random.Next(0, characters.Length - 1)];
            MainButton.Source = character.srcImage;
        }

        private void OnPlaySoundClicked(object sender, EventArgs e)
        {
            AudioManager.Current.CreatePlayer(character.sound).Play();
        }
    }

}
