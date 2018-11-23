using ReactiveUI;
using Splat;

namespace DemoRxUi
{
    public class ShellViewModel : ViewModelBase
    {
        private string _title = "Navigation Test";
        public string Title
        {
            get => _title;
            set => this.RaiseAndSetIfChanged(ref _title, value);
        }

        public ShellViewModel()
        {
            HostScreen.Router.Navigate.Execute(Locator.Current.GetService<IntroViewModel>());
        }
    }
}
