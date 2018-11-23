using System.Reactive.Disposables;
using System.Windows;
using ReactiveUI;

namespace DemoRxUi
{
    /// <summary>
    /// Interaction logic for ShellView.xaml
    /// </summary>
    public partial class ShellView : ReactiveWindow<ShellViewModel>
    {
        public ShellView()
        {
            InitializeComponent();

            this.ViewModel = new ShellViewModel();
            this.Bind(ViewModel, vm => vm.HostScreen.Router, v => v.ContentView.Router);
            this.WhenActivated(
                disposables =>
                {
                    this
                        .Bind(ViewModel, x => x.Title, x => x.Title)
                        .DisposeWith(disposables);
                });
        }
    }
}
