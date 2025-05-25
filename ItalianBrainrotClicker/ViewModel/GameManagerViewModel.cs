using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using ItalianBrainrotClicker.Models;

namespace ItalianBrainrotClicker.ViewModel
{
    internal class GameManagerViewModel
    {
        public CharacterManager CharacterManager;
        public int Count;
        public int TimeLeft;

        public ICommand SelectBalerina { get; }
        public ICommand SelectPatapim { get; }
        public ICommand SelectSahur { get; }

        private GameManagerViewModel()
        {
            this.CharacterManager = new();
            this.SelectBalerina = new Command(() => {
                CharacterManager.SelectCharacter(CharacterType.BalerinaCappucina);
            });
            this.SelectPatapim = new Command(() => {
                CharacterManager.SelectCharacter(CharacterType.BrrBrrPatapim);
            });
            this.SelectSahur = new Command(() => {
                CharacterManager.SelectCharacter(CharacterType.TungTungSahur);
            });
            this.Count = 0;
            this.TimeLeft = 60;
        }

        private static GameManagerViewModel instance;

        public static GameManagerViewModel GetInstance()
        {
            if (instance == null)
                instance = new GameManagerViewModel();

            return instance;
        }
    }
}
