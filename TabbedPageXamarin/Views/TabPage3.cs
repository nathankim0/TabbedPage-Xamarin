using System;
using TabbedPageXamarin.ViewModel;
using Xamarin.Forms;

namespace TabbedPageXamarin
{
    public class TabPage3 : ContentPage
    {
        public TabPage3()
        {
            BindingContext = new TabPage3ViewModel(Navigation);
            var grid = new Grid
            {
                RowSpacing = 0,

                RowDefinitions =
                {
                    new RowDefinition
                    {
                        Height=100
                    },
                    new RowDefinition
                    {
                        Height=40
                    },
                    new RowDefinition
                    {
                        Height=new GridLength(1,GridUnitType.Star)
                    }
                }
            };
            var titleBar = new TitleBar();
            grid.Children.Add(titleBar, 0, 0);

            Content = grid;
        }
    }
}

