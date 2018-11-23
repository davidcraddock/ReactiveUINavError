using System.Windows;
using ReactiveUI;
using Splat;

namespace DemoRxUi
{
    /// <summary>
    /// Interaction logic for IntroView.xaml
    /// </summary>
    public partial class IntroView : ReactiveUserControl<IntroViewModel>
    {
        public IntroView()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<IntroViewModel>();
            this.Bind(ViewModel, vm => vm.HostScreen.Router, v => v.NavViews.Router);

        }
    }
}
