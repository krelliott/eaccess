using System;
using System.Linq;
using Xamarin.Forms;

namespace LoginNavigation
{
	public partial class SettingsPage : ContentPage
	{
		public SettingsPage ()
		{
			InitializeComponent ();
		}

		async void OnBackButtonClicked(object sender, EventArgs e)
		{
            App.IsUserLoggedIn = false;
			Navigation.InsertPageBefore(new LoginPage (), this);
			await Navigation.PopAsync();
		}

		async void OnSaveButtonClicked (object sender, EventArgs e)
		{
			var settings = new Setting () {
				PassportServerURL = passportServerURLEntry.Text,
				DomainName = domainNameEntry.Text				
			};

			// Sign up logic goes here

			var signUpSucceeded = AreDetailsValid (settings);
			if (signUpSucceeded) {
                App.IsUserLoggedIn = false;
				Navigation.InsertPageBefore (new LoginPage (), this);
				await Navigation.PopAsync ();				
			} else {
				messageLabel.Text = "Settings incorrect";
			}
		}

        bool AreDetailsValid (Setting settings)		{
			return (!string.IsNullOrWhiteSpace (settings.PassportServerURL) && !string.IsNullOrWhiteSpace (settings.DomainName) );
		}
	}
}
