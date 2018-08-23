using System;
using System.Collections.Generic;
using Tronald.Model;
using Xamarin.Forms;

namespace Tronald.View
{
    public partial class OverviewTagsPage : ContentPage
    {
        public OverviewTagsPage()
        {
            InitializeComponent();

            GetTags();

            lvwTags.ItemSelected += LvwTags_ItemSelected;
        }

        public async void GetTags()
        {
            OverviewTag TagObject = await TronaldManager.GetTagsAsync();
            List<string> Tags = new List<string>();

            foreach (string tag in TagObject._embedded)
            {
                Tags.Add(tag);
            }

            lvwTags.ItemsSource = Tags;
        }

        void LvwTags_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            string SelectedTag = lvwTags.SelectedItem as string;
            if (SelectedTag != null)
            {
                Navigation.PushAsync(new DetailPage(SelectedTag));
                lvwTags.SelectedItem = null;
            }
        }

    }
}
