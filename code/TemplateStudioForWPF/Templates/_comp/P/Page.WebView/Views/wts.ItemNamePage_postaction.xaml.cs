﻿
//{[{
using Param_RootNamespace.ViewModels;
using Microsoft.Web.WebView2.Core;
using System.Windows;
//}]}

namespace Param_RootNamespace.Views
{
    public partial class wts.ItemNamePage : UserControl
    {
//{[{
        private wts.ItemNameViewModel ViewModel
            => DataContext as wts.ItemNameViewModel;

//}]}
        public wts.ItemNamePage()
        {

        }
//^^
//{[{

        private void OnNavigationCompleted(object sender, CoreWebView2NavigationCompletedEventArgs e)
            => ViewModel.OnNavigationCompleted(sender, e);

        private void wts.ItemNamePage_OnLoaded(object sender, RoutedEventArgs e)
        {
            ViewModel?.Initialize(webView);
        }
//}]}
    }
}
