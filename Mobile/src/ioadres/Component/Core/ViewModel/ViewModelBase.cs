using System;
using Prism.Commands;
using Prism.Mvvm;
using Prism.Navigation;

namespace ioadres.Core.Component.Core.ViewModel
{
    public class ViewModelBase : BindableBase, INavigationAware
    {
        public DelegateCommand<string> NavigateCommand { get; private set; }
        public INavigationService NavigationService { get; private set; }

        private string _title;
        public string Title
        {
            get { return _title; }
            set { SetProperty(ref _title, value); }
        }

        public ViewModelBase(INavigationService navigationService)
        {
            NavigateCommand = new DelegateCommand<string>(Navigate);
            Title = string.Empty;
        }

        private async void Navigate(string name)
        {
            await NavigationService.NavigateAsync(name);

        }

        public void OnNavigatedFrom(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatedTo(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }

        public void OnNavigatingTo(INavigationParameters parameters)
        {
            throw new NotImplementedException();
        }
    }
}
