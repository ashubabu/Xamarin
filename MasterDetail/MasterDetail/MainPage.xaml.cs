using System;
using Xamarin.Forms;

namespace MasterDetail
{
    public partial class MainPage : ContentPage
	{
        MainPageViewModel vm;
		public MainPage()
		{
			InitializeComponent();
            vm = new MainPageViewModel(this.Navigation);
            BindingContext = vm;

		}

        public async void NavigationHandler(object sender, EventArgs args )
        {
            await Navigation.PushAsync(new View2());
        }
	}
}
