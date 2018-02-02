using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using Stripe;

namespace stripeTestReal
{
	[XamlCompilation(XamlCompilationOptions.Compile)]
	public partial class Page1 : ContentPage
	{
		public Page1 ()
		{
			InitializeComponent ();
		}

        void MakeAPayment(object sender, System.EventArgs e)
        {
            // var amount = 100;
            //var payment = Stripe.StripeCharge.(amount);
            try
            {
                //use nu-get Stripe
                //set TLS 1.2 in androuid settings

                StripeConfiguration.SetApiKey("sk_test_BEPrGyKARA5fbK1rcLbAixdd");

                var chargeOptions = new StripeChargeCreateOptions()
                {
                    Amount = 2000,
                    Currency = "usd",
                    SourceTokenOrExistingSourceId = "tok_visa",
                    Metadata = new Dictionary<String, String>()
    {
        { "OrderId", "6735"}
    }
                };

                var chargeService = new StripeChargeService();
                StripeCharge charge = chargeService.Create(chargeOptions);
            }
            // Use Stripe's library to make request

            catch (StripeException ex)
            {
                switch (ex.StripeError.ErrorType)
                {
                    case "card_error":
                        System.Diagnostics.Debug.WriteLine("   Code: " + ex.StripeError.Code);
                        System.Diagnostics.Debug.WriteLine("Message: " + ex.StripeError.Message);
                        break;
                    case "api_connection_error":
                        System.Diagnostics.Debug.WriteLine(" apic  Code: " + ex.StripeError.Code);
                        System.Diagnostics.Debug.WriteLine("apic Message: " + ex.StripeError.Message);
                        break;
                    case "api_error":
                        System.Diagnostics.Debug.WriteLine("api   Code: " + ex.StripeError.Code);
                        System.Diagnostics.Debug.WriteLine("api Message: " + ex.StripeError.Message);
                        break;
                    case "authentication_error":
                        System.Diagnostics.Debug.WriteLine(" auth  Code: " + ex.StripeError.Code);
                        System.Diagnostics.Debug.WriteLine("auth Message: " + ex.StripeError.Message);
                        break;
                    case "invalid_request_error":
                        System.Diagnostics.Debug.WriteLine(" invreq  Code: " + ex.StripeError.Code);
                        System.Diagnostics.Debug.WriteLine("invreq Message: " + ex.StripeError.Message);
                        break;
                    case "rate_limit_error":
                        System.Diagnostics.Debug.WriteLine("  rl Code: " + ex.StripeError.Code);
                        System.Diagnostics.Debug.WriteLine("rl Message: " + ex.StripeError.Message);
                        break;
                    case "validation_error":
                        System.Diagnostics.Debug.WriteLine(" val  Code: " + ex.StripeError.Code);
                        System.Diagnostics.Debug.WriteLine("val Message: " + ex.StripeError.Message);
                        break;
                    default:
                        // Unknown Error Type
                        break;
                }
            }



        }
    }
}