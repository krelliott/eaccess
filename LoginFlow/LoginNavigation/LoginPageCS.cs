using System;
using ZXing.Net.Mobile.Forms;
using Xamarin.Forms;
using ZXing.Mobile;
using System.Collections.Generic;

namespace LoginNavigation
{
	public class LoginPageCS : ContentPage
	{
		Entry usernameEntry, passwordEntry;
		Label messageLabel;

		public LoginPageCS ()
		{
			var toolbarItem = new ToolbarItem("\uf013", null, () => {});

			toolbarItem.Clicked += OnSettingsButtonClicked;
			ToolbarItems.Add (toolbarItem);

			messageLabel = new Label ();
			usernameEntry = new Entry {
				Placeholder = "username"	
			};
			passwordEntry = new Entry {
                Placeholder = "password",
				IsPassword = true
			};
			var loginButton = new Button {
				Text = "Login",
                BackgroundColor = Color.FromHex("#0D6595"),
				TextColor = Color.White
			};
			loginButton.Clicked += OnLoginButtonClicked;

			var scanningButton = new Button
			{
				Text = "Scan Badge",
				BackgroundColor = Color.FromHex("#0D6595"),
				TextColor = Color.White
			};
			scanningButton.Clicked += OnScanningButtonClicked;

			Title = "Access E-Signature";

            var loginButtonStackLayout = new StackLayout
            {
                Padding = 35,
                VerticalOptions = LayoutOptions.CenterAndExpand,
                Children = {
                    loginButton,
                    scanningButton
                }
            };

            Content = new StackLayout { 
				VerticalOptions = LayoutOptions.StartAndExpand,
                Padding = 20,
				Children = {
					new Label { Text = "Username" },
					usernameEntry,
					new Label { Text = "Password" },
					passwordEntry,
					loginButtonStackLayout,
					messageLabel
				}
			};
		}

		async void OnSettingsButtonClicked (object sender, EventArgs e)
		{
			Navigation.InsertPageBefore(new SettingsPageCS (), this);
			await Navigation.PopAsync();
		}

		async void OnScanningButtonClicked(object sender, EventArgs e)
		{
            //setup options
            var options = new MobileBarcodeScanningOptions
            {
                AutoRotate = false,
                UseFrontCameraIfAvailable = true,
                TryHarder = true,
                TryInverted = true,
				PossibleFormats = new List<ZXing.BarcodeFormat>
		        {
		            ZXing.BarcodeFormat.EAN_13 , ZXing.BarcodeFormat.EAN_13
		        }
			};

            var scanPage = new ZXingScannerPage(options){
		        DefaultOverlayTopText = "Align the barcode within the frame",
		        DefaultOverlayBottomText = string.Empty,
		        DefaultOverlayShowFlashButton = true
	        };

			scanPage.OnScanResult += (result) =>
			{
				scanPage.IsScanning = false;

				Device.BeginInvokeOnMainThread(async () =>
				{
					await Navigation.PopAsync();
					await DisplayAlert("Scanned Barcode", result.Text, "OK");
				});
			};
			// Navigate to our scanner page
			await Navigation.PushAsync(scanPage);
		}

		async void OnLoginButtonClicked (object sender, EventArgs e)
		{
			var user = new User {
				Username = usernameEntry.Text,
				Password = passwordEntry.Text
			};

			var isValid = AreCredentialsCorrect (user);
			if (isValid) {
				App.IsUserLoggedIn = true;
				Navigation.InsertPageBefore (new MainPageCS (), this);
				await Navigation.PopAsync ();
			} else {
				messageLabel.Text = "Login failed";
				passwordEntry.Text = string.Empty;
			}
		}

		bool AreCredentialsCorrect (User user)
		{
			return user.Username == Constants.Username && user.Password == Constants.Password;
		}
	}
}


