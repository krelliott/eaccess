using System;
using UIKit;

using Xamarin.Forms;
using Xamarin.Forms.Platform.iOS;

[assembly: ExportRenderer(typeof(LoginNavigation.FontAwesomeLabel), typeof(LoginNavigation.iOS.FontAwesomeLabelRenderer))]
namespace LoginNavigation.iOS
{
	public class FontAwesomeLabelRenderer : LabelRenderer
	{
		public FontAwesomeLabelRenderer()
		{
		}

		// sets the font for the platform-specific ui component to be our custom font
		protected override void OnElementChanged(ElementChangedEventArgs<Label> e)
		{
			base.OnElementChanged(e);
            if (e.NewElement != null)
            {
                double? fs = e.NewElement?.FontSize;
                // Note we're using the font family name here, NOT the filename
                UIFont font = UIFont.FromName("FontAwesome", (int)fs);
                Control.Font = font;
            }
		}

		// Without this strange things happen if you update the text after the label is first displayed
		protected override void OnElementPropertyChanged(object sender, System.ComponentModel.PropertyChangedEventArgs e)
		{
			base.OnElementPropertyChanged(sender, e);
			if (e.PropertyName.Equals("Text"))
			{
				Label label = sender as Label;
				// Note we're using the font family name here, NOT the filename
				UIFont font = UIFont.FromName("FontAwesome", (int)label.FontSize);
				Control.Font = font;
			}
		}
	}
}
