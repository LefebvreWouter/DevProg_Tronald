using System;

using Xamarin.Forms;

namespace Tronald.View
{
    public class NetworkViewPage : ContentPage
    {
        public NetworkViewPage()
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

