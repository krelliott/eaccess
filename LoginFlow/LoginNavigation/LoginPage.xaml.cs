using System;
using Xamarin.Forms;

namespace LoginNavigation
{
	public partial class LoginPage : ContentPage
	{
		public LoginPage ()
		{

			InitializeComponent ();
			FontAwesomeLabel test = new FontAwesomeLabel
			{
			    Text = '\uf002'.ToString()
			};
			MyStack.Children.Add(test);
        }

		async void OnSettingsButtonClicked (object sender, EventArgs e)
		{
			Navigation.InsertPageBefore (new SettingsPage (), this);
            await Navigation.PopAsync();
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
				Navigation.InsertPageBefore (new MainPage (), this);
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
