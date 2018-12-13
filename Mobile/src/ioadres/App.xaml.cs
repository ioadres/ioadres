using System;
using ioadres.Core.Component.Core;
using ioadres.Core.Component.Hello;
using Prism;
using Xamarin.Forms.Xaml;
using Prism;
using Prism.Ioc;
using Prism.Unity;
using Xamarin.Forms;

namespace ioadres.Core
{

    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class App : PrismApplication
    {
        public App(IPlatformInitializer initializer = null) : base(initializer) {

        }

        protected override async void OnInitialized()
        {
            try
            { 
                InitializeComponent();

                await NavigationService.NavigateAsync(PageRoutes.GetKey<HelloPage>());
            } catch(Exception e)
            {

            }
        }

        protected override void RegisterTypes(IContainerRegistry containerRegistry)
        {
            //# Container Services
            //ServicesLoader.Load(containerRegistry);

            //# Container Components
            containerRegistry.RegisterForNavigation<HelloPage>();
            PageRoutes.AddKey<HelloPage>($"/{nameof(HelloPage)}");

        }

        protected override void OnStart()
        {
            base.OnStart();
        }

        protected override void OnSleep()
        {
            base.OnSleep();
        }

        protected override void OnResume()
        {
            base.OnResume();
        }
    }
}
