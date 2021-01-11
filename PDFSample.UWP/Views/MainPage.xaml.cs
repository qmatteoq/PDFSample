using System;

using PDFSample.UWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace PDFSample.UWP.Views
{
    public sealed partial class MainPage : Page
    {
        private MainViewModel ViewModel => DataContext as MainViewModel;

        public MainPage()
        {
            InitializeComponent();
        }
    }
}
