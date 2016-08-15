// Author: Hum, Adrian
// Project: WPF-CacheImage/WPF-CacheImage/MyWorkingViewModel.cs
//
// Created  Date: 2015-10-08  11:34 AM
// Modified Date: 2015-10-08  11:44 AM

#region Using Directives

using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using WPF_CacheImage.Annotations;

#endregion

namespace WPF_CacheImage
{
    public class MyWorkingViewModel : INotifyPropertyChanged
    {
        private string _url;
        private string _urlValue;

        public string Url
        {
            get { return _url; }
            set
            {
                _url = value;
                OnPropertyChanged(nameof(Url));
            }
        }

        public string UrlValue
        {
            get { return _urlValue; }
            set
            {
                _urlValue = value;
                OnPropertyChanged(nameof(UrlValue));
            }
        }

        #region INotifyPropertyChanged Members

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        public void SetUrlIfValid()
        {
            Uri outUri;
            if (Uri.TryCreate(UrlValue, UriKind.RelativeOrAbsolute, out outUri) && (outUri.Scheme == Uri.UriSchemeHttp || outUri.Scheme == Uri.UriSchemeHttps)) Url = outUri.AbsoluteUri;
        }

        [NotifyPropertyChangedInvocator]
        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            var handler = PropertyChanged;
            handler?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}