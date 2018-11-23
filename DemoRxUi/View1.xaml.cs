using System.Windows;
using ReactiveUI;
using Splat;

namespace DemoRxUi
{
    /// <summary>
    /// Interaction logic for View1.xaml
    /// </summary>
    public partial class View1 : ReactiveUserControl<View1Model>
    {
        public View1()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<View1Model>();
            this.BindCommand(this.ViewModel, x => x.GoForwardCommand, x => x.View1Button);
        }
    }
}
