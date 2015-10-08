// Author: Hum, Adrian
// Project: WPF-CacheImage/WPF-CacheImage/MainWindow.xaml.cs
//
// Created  Date: 2015-10-08  11:05 AM
// Modified Date: 2015-10-08  12:15 PM

#region Using Directives

using System.Windows;

#endregion

namespace WPF_CacheImage
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void GetUrlButton_OnClick(object sender, RoutedEventArgs e)
        {
            var dc = DataContext as MyWorkingViewModel;
            if (dc == null) return;
            dc.SetUrlIfValid();
        }
    }
}