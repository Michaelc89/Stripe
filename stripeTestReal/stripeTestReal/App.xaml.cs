using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Xamarin.Forms;

namespace stripeTestReal
{
	public partial class App : Application
	{
		public App ()
		{
			InitializeComponent();

            //MainPage = new stripeTestReal.MainPage();
            MainPage = new stripeTestReal.Page1();
		}

		protected override void OnStart ()
		{
			// Handle when your app starts
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
