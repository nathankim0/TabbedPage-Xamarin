using System;
using Xamarin.Forms.PlatformConfiguration.AndroidSpecific;
using Xamarin.Forms.PlatformConfiguration.iOSSpecific;
using Xamarin.Forms.PlatformConfiguration;
using Xamarin.Forms;

namespace TabbedPageXamarin
{
    public class MainPage : Xamarin.Forms.TabbedPage
    {
        public MainPage()
        {
            On<Android>().SetToolbarPlacement(ToolbarPlacement.Bottom);
            On<Android>().SetIsSwipePagingEnabled(false);
            On<iOS>().SetUseSafeArea(true);

            Xamarin.Forms.NavigationPage.SetBackButtonTitle(this, "back");
            Xamarin.Forms.NavigationPage.SetHasNavigationBar(this, false);
            SelectedTabColor = Color.Accent;
            UnselectedTabColor = Color.Gray;

            Visual = VisualMarker.Material;

            var tabPage1 = new TabPage1
            {
                Title = "TabPage1",
                IconImageSource = new FontImageSource
                {
                    Glyph= "\uf30c",
                        FontFamily = Device.RuntimePlatform == Device.iOS ? "Ionicons" : "ionicons.ttf#",

                }
            };
            
            var tabPage2 = new TabPage2
            {
                Title = "TabPage2"
            };
            var tabPage3 = new TabPage3
            {
                Title = "TabPage3"
            };
            Children.Add(tabPage1);
            Children.Add(tabPage2);
            Children.Add(tabPage3);
        }
    }
}

