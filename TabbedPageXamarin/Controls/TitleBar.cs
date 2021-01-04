using System;

using Xamarin.Forms;

namespace TabbedPageXamarin
{
    public class TitleBar : ContentView
    {
        public Label label;

        public TitleBar()
        {
            label = new Label
            {
                Margin = 20,
                FontAttributes = FontAttributes.Bold,
                FontSize = 30,
                HorizontalTextAlignment = TextAlignment.Start,
                TextColor = Color.White,
                VerticalTextAlignment = TextAlignment.End
            };
            label.SetBinding(Label.TextProperty, "Title");

            var grid = new Grid
            {
                BackgroundColor = Color.Orange,
                Children =
                {
                    label
                }
            };
            Content = grid;
        }
    }
}

