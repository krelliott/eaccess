using System;

using Xamarin.Forms;

namespace LoginNavigation
{
	public class NewMainPage : ContentPage
	{
		public NewMainPage()
		{
			Content = new StackLayout
			{
				HorizontalOptions = LayoutOptions.CenterAndExpand,
				VerticalOptions = LayoutOptions.CenterAndExpand,
				Children = {
					new Label { Text = "Custom Font on Toolbar is working!" }
				}
			};

			ToolbarItems.Add(new ToolbarItem("\uf002", null, () => {

			}));

			ToolbarItems.Add(new ToolbarItem("Right", null, () => {
				Device.BeginInvokeOnMainThread(() => {
					Title = "Right";
				});
			}));

			ToolbarItems.Add(new ToolbarItem("First", null, () => {
				Device.BeginInvokeOnMainThread(() => {
					Title = "First";
				});
			}, ToolbarItemOrder.Secondary, 0));

			ToolbarItems.Add(new ToolbarItem("Second", null, () => {
				Device.BeginInvokeOnMainThread(() => {
					Title = "Second";
				});
			}, ToolbarItemOrder.Secondary, 1));

			ToolbarItems.Add(new ToolbarItem("Third", null, () => {
				Device.BeginInvokeOnMainThread(() => {
					Title = "Third";
				});
			}, ToolbarItemOrder.Secondary, 2));


			Title = "\uf002";
		}
	}
}


