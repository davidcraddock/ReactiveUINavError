

using System;
using System.Reactive;
using ReactiveUI;
using Splat;

namespace DemoRxUi
{
    public class View2Model : ViewModelBase
    {
        public ReactiveCommand<Unit, Unit> GoBackCommand { get; set; }
        public View2Model()
        {
            HostScreen = Locator.Current.GetService<ViewRouting>();
            GoBackCommand = ReactiveCommand.CreateFromObservable(() => HostScreen.Router.NavigateBack.Execute());
            GoBackCommand.ThrownExceptions.Subscribe(Test);
        }

        private void Test(Exception exception)
        {
            // Error index out of range exception caught here
        }
    }
}
