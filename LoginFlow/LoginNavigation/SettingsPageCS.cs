using System;
using System.Linq;
using Xamarin.Forms;

namespace LoginNavigation
{
	public class SettingsPageCS : ContentPage
	{
		Entry passportServerURLEntry, domainNameEntry;
		Label messageLabel;

		public SettingsPageCS ()
		{
			var toolbarItem = new ToolbarItem("\uf015", null, () => { });

			toolbarItem.Clicked += OnBackButtonClicked;
			ToolbarItems.Add(toolbarItem);

			messageLabel = new Label ();
			passportServerURLEntry = new Entry {
				Placeholder = "passport server URL"	
			};
			domainNameEntry = new Entry {};

			var saveButton = new Button {
				Text = "Save",
                BackgroundColor = Color.FromHex("#0D6595"),
				TextColor = Color.White
			};
			saveButton.Clicked += OnSaveButtonClicked;

			var saveButtonStackLayout = new StackLayout
			{
				Padding = 70,
				Children = {
					saveButton
				}
			};

			Title = "Settings";
			Content = new StackLayout { 
				VerticalOptions = LayoutOptions.StartAndExpand,
                Padding = 20,
				Children = {
					new Label { Text = "Passport Server URL" },
					passportServerURLEntry,
					new Label { Text = "Domain Name" },
					domainNameEntry,					
					saveButtonStackLayout,
					messageLabel
				}
			};
		}

		async void OnBackButtonClicked(object sender, EventArgs e)
		{
			App.IsUserLoggedIn = false;
			Navigation.InsertPageBefore(new LoginPageCS(), this);
			await Navigation.PopAsync();
		}

		async void OnSaveButtonClicked(object sender, EventArgs e)
		{
			var settings = new Setting ()
			{
				PassportServerURL = passportServerURLEntry.Text,
				DomainName = domainNameEntry.Text
			};

			// Sign up logic goes here

			var signUpSucceeded = AreDetailsValid(settings);
			if (signUpSucceeded)
			{
				App.IsUserLoggedIn = false;
				Navigation.InsertPageBefore(new LoginPageCS(), this);
				await Navigation.PopAsync();
			}
			else
			{
				messageLabel.Text = "Settings incorrect";
			}
		}

		bool AreDetailsValid(Setting settings)
		{
			return (!string.IsNullOrWhiteSpace(settings.PassportServerURL) && !string.IsNullOrWhiteSpace(settings.DomainName));
		}
	}
}
