using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace stripeTestReal
{
	public partial class MainPage : ContentPage
	{
		public MainPage()
		{
			InitializeComponent();
		}

        async void Page1(object sender, System.EventArgs e)
        {
            try
            {
                await Navigation.PushAsync(new Page1());
            }
            catch (System.Exception er)
            {
                await DisplayAlert("Alert", "da error: " + er, "Ok");
            }
        }
    }
}
