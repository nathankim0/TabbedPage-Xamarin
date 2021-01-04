using Xamarin.Forms;
namespace TabbedPageXamarin.ViewModel
{
    public class TabPage1ViewModel : BaseViewModel
    {
        public TabPage1ViewModel(INavigation navigation)
        {
            Title = "TabPage1";
            Navigation = navigation;
        }
    }
}
