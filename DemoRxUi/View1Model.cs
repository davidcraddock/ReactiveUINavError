using System;
using System.Reactive;
using ReactiveUI;
using Splat;

namespace DemoRxUi
{
    public class View1Model : ViewModelBase
    {
        public ReactiveCommand<Unit, IRoutableViewModel> GoForwardCommand { get; }

        public View1Model()
        {
            HostScreen = Locator.Current.GetService<ViewRouting>();
            GoForwardCommand = ReactiveCommand.CreateFromObservable(() => HostScreen.Router.Navigate.Execute(Locator.Current.GetService<View2Model>()));
        }
    }
}
