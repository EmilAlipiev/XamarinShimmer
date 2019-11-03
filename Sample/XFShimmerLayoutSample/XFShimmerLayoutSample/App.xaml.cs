using FreshMvvm;
using Xamarin.Essentials;
using Xamarin.Forms.Xaml;
using XFShimmerLayout.Controls;

[assembly: XamlCompilation(XamlCompilationOptions.Compile)]
namespace XFShimmerLayoutSample
{
    public partial class App
    {
        public App()
        {
            InitializeComponent();

            ShimmerLayout.Init(DeviceDisplay.MainDisplayInfo.Density);

            var page = FreshPageModelResolver.ResolvePageModel<ShimmerListViewPageModel>();
            var MainpageNavigation = new FreshNavigationContainer(page, NavigationContainerNames.DefaultNavigationServiceName);
            MainPage = MainpageNavigation;
        }

        public class NavigationContainerNames
        {
            public const string AuthenticationContainer = "AuthenticationContainer";
            public const string DefaultNavigationServiceName = "DefaultNavigationServiceName";
        }

    }
}
