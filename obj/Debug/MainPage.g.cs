﻿#pragma checksum "E:\Eldho\ContactChooserTest\ContactChooserTest\ContactChooserTest\MainPage.xaml" "{406ea660-64cf-4c82-b6f0-42d48172a799}" "9494428512B57A98BF30B3A5BAF2AABE"
//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34003
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using RateMyApp.Controls;
using System;
using System.Windows;
using System.Windows.Automation;
using System.Windows.Automation.Peers;
using System.Windows.Automation.Provider;
using System.Windows.Controls;
using System.Windows.Controls.Primitives;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Interop;
using System.Windows.Markup;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Media.Imaging;
using System.Windows.Resources;
using System.Windows.Shapes;
using System.Windows.Threading;


namespace ContactChooserTest {
    
    
    public partial class MainPage : Microsoft.Phone.Controls.PhoneApplicationPage {
        
        internal Microsoft.Phone.Shell.ApplicationBarMenuItem menubtnaboutus;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnSms;
        
        internal Microsoft.Phone.Shell.ApplicationBarIconButton btnemail;
        
        internal System.Windows.Controls.Grid LayoutRoot;
        
        internal System.Windows.Controls.StackPanel TitlePanel;
        
        internal System.Windows.Controls.TextBlock PageTitle;
        
        internal System.Windows.Controls.Grid ContentPanel;
        
        internal System.Windows.Controls.StackPanel Defultstk;
        
        internal System.Windows.Controls.TextBlock txtprpare;
        
        internal System.Windows.Controls.ProgressBar prgrsbar;
        
        internal System.Windows.Controls.StackPanel shwselectedstk;
        
        internal System.Windows.Controls.TextBlock txtname;
        
        internal System.Windows.Controls.TextBlock txtph;
        
        internal RateMyApp.Controls.FeedbackOverlay myFeedbackOverlay;
        
        private bool _contentLoaded;
        
        /// <summary>
        /// InitializeComponent
        /// </summary>
        [System.Diagnostics.DebuggerNonUserCodeAttribute()]
        public void InitializeComponent() {
            if (_contentLoaded) {
                return;
            }
            _contentLoaded = true;
            System.Windows.Application.LoadComponent(this, new System.Uri("/ContactChooserTest;component/MainPage.xaml", System.UriKind.Relative));
            this.menubtnaboutus = ((Microsoft.Phone.Shell.ApplicationBarMenuItem)(this.FindName("menubtnaboutus")));
            this.btnSms = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnSms")));
            this.btnemail = ((Microsoft.Phone.Shell.ApplicationBarIconButton)(this.FindName("btnemail")));
            this.LayoutRoot = ((System.Windows.Controls.Grid)(this.FindName("LayoutRoot")));
            this.TitlePanel = ((System.Windows.Controls.StackPanel)(this.FindName("TitlePanel")));
            this.PageTitle = ((System.Windows.Controls.TextBlock)(this.FindName("PageTitle")));
            this.ContentPanel = ((System.Windows.Controls.Grid)(this.FindName("ContentPanel")));
            this.Defultstk = ((System.Windows.Controls.StackPanel)(this.FindName("Defultstk")));
            this.txtprpare = ((System.Windows.Controls.TextBlock)(this.FindName("txtprpare")));
            this.prgrsbar = ((System.Windows.Controls.ProgressBar)(this.FindName("prgrsbar")));
            this.shwselectedstk = ((System.Windows.Controls.StackPanel)(this.FindName("shwselectedstk")));
            this.txtname = ((System.Windows.Controls.TextBlock)(this.FindName("txtname")));
            this.txtph = ((System.Windows.Controls.TextBlock)(this.FindName("txtph")));
            this.myFeedbackOverlay = ((RateMyApp.Controls.FeedbackOverlay)(this.FindName("myFeedbackOverlay")));
        }
    }
}

