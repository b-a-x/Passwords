﻿using System;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Password.Desktop.Win.Pages
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        private string pageTypeName;

        public MainPage()
        {
            this.InitializeComponent();
            pageTypeName = nameof(Home);
            ContentFrame.Navigate(GetPageType(pageTypeName), null);
        }

        private void NavigationViewOnItemInvoked(NavigationView sender, NavigationViewItemInvokedEventArgs args)
        {
            NavigationViewItemBase item = args.InvokedItemContainer;
            if (pageTypeName.Equals(item.Name))
                return;

            FrameNavigationOptions navOptions = new FrameNavigationOptions
            {
                TransitionInfoOverride = args.RecommendedNavigationTransitionInfo
            };

            if (sender.PaneDisplayMode == NavigationViewPaneDisplayMode.Top)
            {
                navOptions.IsNavigationStackEnabled = false;
            }

            ContentFrame.NavigateToType(GetPageType(item.Name), null, navOptions);
            pageTypeName = item.Name;
        }

        private Type GetPageType(string pageName)
        {
            switch (pageName)
            {
                case nameof(Home):
                    return typeof(Home);
                case nameof(SettingsNavPaneItem):
                    return typeof(SettingsNavPaneItem);
                case nameof(PasswordInfoPage):
                    return typeof(PasswordInfoPage);
                default:
                    return null;
            }
        }

        private void NavigationViewOnBackRequested(NavigationView sender, NavigationViewBackRequestedEventArgs args)
        {
            if (ContentFrame.CanGoBack)
                ContentFrame.GoBack();
        }
    }
}