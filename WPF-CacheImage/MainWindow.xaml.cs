// Author: Hum, Adrian
// Project: WPF-CacheImage/WPF-CacheImage/MainWindow.xaml.cs
//
// Created  Date: 2015-10-08  11:05 AM
// Modified Date: 2015-10-08  11:33 AM

#region Using Directives

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Windows;
using WPF_CacheImage.Annotations;

#endregion

namespace WPF_CacheImage
{
    /// <summary>
    ///     Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : INotifyPropertyChanged
    {
        private string _url;

        public MainWindow()
        {
            InitializeComponent();
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        private void GetUrlButton_OnClick(object sender, RoutedEventArgs e)
        {
            var dc = DataContext as MyWorkingViewModel;
            if (dc == null) return;
            dc.SetUrlIfValid();
        }

        /// <exception cref="Exception">A delegate callback throws an exception.</exception>
        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}