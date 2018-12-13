using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace ioadres.Core.Component.Hello
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class HelloPage : ContentPage
    {
        public HelloPage()
        {
            try
            {
                InitializeComponent();
            } catch(Exception e)
            {

            }
        }
    }
}
