using MvvmCross.ViewModels;

namespace AzureDemo.Core
{
    public class App : MvxApplication
    {
        public override void Initialize()
        {
            RegisterAppStart<ListViewModel>();
        }
    }
}
