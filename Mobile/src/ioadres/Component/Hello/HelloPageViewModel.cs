using System;
using ioadres.Core.Component.Core.ViewModel;
using Prism.Navigation;

namespace ioadres.Core.Component.Hello
{
    public class HelloPageViewModel : ViewModelBase
    {
        public HelloPageViewModel(INavigationService navigationService) : base(navigationService)
        {
            Title = "Hello";
        }
    }
}
