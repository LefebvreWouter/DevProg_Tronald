using System;
using System.Collections.Generic;

using Xamarin.Forms;
using Tronald.Model;

namespace Tronald.View
{
    public partial class DetailPage : ContentPage
    {
        public DetailPage(string pTag)
        {
            InitializeComponent();
            GetQuotesByTag(pTag);
            lblTagName.Text = pTag;
        }

        public async void GetQuotesByTag(string pTag)
        {
            Quotes listquotes = await TronaldManager.GetQuotesByTag(pTag);
            if (listquotes.count > 0)
            {
                lvwQuotes.ItemsSource = listquotes._embedded.quotes;
            }
            else
            {
                await Navigation.PushAsync(new ErrorPage());
            }
        }
    }
}
