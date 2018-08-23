using System;
using Plugin.Connectivity;
using Plugin.Connectivity.Abstractions;
using Tronald.View;
using Xamarin.Forms;
using Xamarin.Forms.Xaml;

[assembly: XamlCompilation (XamlCompilationOptions.Compile)]
namespace Tronald
{
	public partial class App : Application
	{
		public App ()
		{
            MainPage = CrossConnectivity.Current.IsConnected
        ? (Page)new NoNetworkPage()
        : new NoNetworkPage();
			InitializeComponent();

            MainPage = new NavigationPage(new MainPage());
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
            base.OnStart();
            CrossConnectivity.Current.ConnectivityChanged += HandleConnectivityChanged;
        }

        void HandleConnectivityChanged(object sender, ConnectivityChangedEventArgs e)
        {
            Type currentPage = this.MainPage.GetType();
            if (e.IsConnected && currentPage != typeof(MainPage))
                this.MainPage = new MainPage();
            else if (!e.IsConnected && currentPage != typeof(NoNetworkPage))
                this.MainPage = new NoNetworkPage();
		}

		protected override void OnSleep ()
		{
			// Handle when your app sleeps
		}

		protected override void OnResume ()
		{
			// Handle when your app resumes
		}
	}
}
