using System;

using Xamarin.Forms;

namespace LoginNavigation
{
    public class ScanPage : ContentPage
    {
        public ScanPage()
        {
            Content = new StackLayout
            {
                Children = {
                    new Label { Text = "Hello ContentPage" }
                }
            };
        }


    }
}

