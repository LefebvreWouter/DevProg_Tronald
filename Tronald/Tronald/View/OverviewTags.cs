using System;

using Xamarin.Forms;

namespace Tronald.View
{
    public class OverviewTags : ContentPage
    {
        public OverviewTags()
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

