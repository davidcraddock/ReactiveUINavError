using Splat;

namespace DemoRxUi
{
    public class IntroViewModel : ViewModelBase
    {
        public IntroViewModel()
        {
            HostScreen = Locator.Current.GetService<ViewRouting>();
            HostScreen.Router.Navigate.Execute(Locator.Current.GetService<View1Model>());
        }
    }
}
