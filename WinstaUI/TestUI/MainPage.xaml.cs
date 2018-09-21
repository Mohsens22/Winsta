using TestUI.Views;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace TestUI
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            InitializeComponent();
        }
        protected override void OnNavigatedTo(NavigationEventArgs e)
        {
            Fr.Navigate(typeof(HomeView));
            base.OnNavigatedTo(e);
        }
        private void HmenuBTN_Click(object sender, RoutedEventArgs e)
        {
            Split.IsPaneOpen = !Split.IsPaneOpen;
        }

        private void Grid_PointerPressed(object sender, Windows.UI.Xaml.Input.PointerRoutedEventArgs e)
        {
            Fr.Navigate(typeof(ProfileView));
        }
    }
}
