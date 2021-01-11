using System;

using PDFSample.UWP.ViewModels;

using Windows.UI.Xaml.Controls;

namespace PDFSample.UWP.Views
{
    public sealed partial class ExpenseDetailPage : Page
    {
        private ExpenseDetailViewModel ViewModel => DataContext as ExpenseDetailViewModel;

        public ExpenseDetailPage()
        {
            InitializeComponent();
        }
    }
}
