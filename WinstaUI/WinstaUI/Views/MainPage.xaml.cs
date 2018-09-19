using System;

using Windows.UI.Xaml.Controls;

using WinstaUI.ViewModels;

namespace WinstaUI.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel
        {
            get { return DataContext as MainViewModel; }
        }

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
