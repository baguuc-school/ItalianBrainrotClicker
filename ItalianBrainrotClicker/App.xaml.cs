
using ItalianBrainrotClicker.Views;

namespace ItalianBrainrotClicker
{
    public partial class App : Application
    {
        public App()
        {
            InitializeComponent();
        }

        protected override Window CreateWindow(IActivationState? activationState)
        {
            NavigationPage navigationPage = new NavigationPage(new StartView());

            return new Window(navigationPage);
        }
    }
}
