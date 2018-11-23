using ReactiveUI;
using Splat;

namespace DemoRxUi
{
    public class AppBootsrapper : ReactiveObject, IScreen
    {
        public RoutingState Router { get; protected set; }

        public AppBootsrapper()
        {
            Router = new RoutingState();


            Locator.CurrentMutable.RegisterConstant(this, typeof(IScreen));
            Locator.CurrentMutable.RegisterConstant(new ViewRouting(), typeof(ViewRouting));

            Locator.CurrentMutable.RegisterLazySingleton(() => new View1(), typeof(IViewFor<View1Model>));
            Locator.CurrentMutable.RegisterLazySingleton(() => new View1Model(), typeof(View1Model));

            Locator.CurrentMutable.RegisterLazySingleton(() => new View2(), typeof(IViewFor<View2Model>));
            Locator.CurrentMutable.RegisterLazySingleton(() => new View2Model(), typeof(View2Model));

            Locator.CurrentMutable.RegisterLazySingleton(() => new IntroView(), typeof(IViewFor<IntroViewModel>));
            Locator.CurrentMutable.RegisterLazySingleton(() => new IntroViewModel(), typeof(IntroViewModel));

            Locator.CurrentMutable.RegisterLazySingleton(() => new ShellView(), typeof(IViewFor<ShellViewModel>));
        }
    }

    public class ViewRouting : IScreen
    {
        public RoutingState Router { get; }

        public ViewRouting()
        {
            Router = new RoutingState();
        }
    }
}
