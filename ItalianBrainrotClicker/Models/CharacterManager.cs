using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace ItalianBrainrotClicker.Models
{
    internal class CharacterManager : INotifyPropertyChanged
    {
        private Character selectedCharacter;
        public Character SelectedCharacter {
            get => selectedCharacter;
            set
            {
                selectedCharacter = value;
                OnPropertyChanged();
            }
        }

        public void SelectCharacter(CharacterType type)
        {
            SelectedCharacter = type switch
            {
                CharacterType.BalerinaCappucina => new Character(
                    "Balerina Cappucina",
                    new CharacterAssets("ballerina_cappucina.mp3", "ballerina_cappucina.jpg")
                ),
                CharacterType.BrrBrrPatapim => new Character(
                    "Brr Brr Patapim",
                     new CharacterAssets("brr_brr_patapim.mp3", "brr_brr_patapim.jpg")
                ),
                CharacterType.TungTungSahur => new Character(
                    "Tung Tung Tung Sahur",
                    new CharacterAssets("tung_tung_tung_sahur.mp3", "tung_tung_tung_sahur.jpg")
                )
            };
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected void OnPropertyChanged([CallerMemberName] string propName = null)
            => PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propName));
    }
}
