using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;
using Tronald.Model;
using Tronald.View;

namespace Tronald
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();

            btnGetTags.Clicked += BtnGetTags_Clicked;
            GetQuoteOfTheDay();

		}

        void BtnGetTags_Clicked(object sender, EventArgs e)
        {
            Navigation.PushAsync(new OverviewTagsPage());
        }

        public async void GetQuoteOfTheDay()
        {
            Quote RandomQuote = await TronaldManager.GetQuoteOfTheDay();

            lblDate.Text = RandomQuote.appeared_at.ToString("dd/MM/yyyy");
            lblQuote.Text = RandomQuote.value;
            lblTag.Text = RandomQuote.tags[0];
        }
	}
}
