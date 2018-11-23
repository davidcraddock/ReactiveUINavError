using System.Windows;
using ReactiveUI;
using Splat;

namespace DemoRxUi
{
    /// <summary>
    /// Interaction logic for View2.xaml
    /// </summary>
    public partial class View2 : ReactiveUserControl<View2Model>
    {
        public View2()
        {
            InitializeComponent();

            ViewModel = Locator.Current.GetService<View2Model>();
            this.BindCommand(this.ViewModel, x => x.GoBackCommand, x => x.View2Button);
        }
    }
}
