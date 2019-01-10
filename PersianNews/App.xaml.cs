﻿using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using PersianNews.Configurations;

namespace PersianNews
{
    /// <summary>
    /// Interaction logic for App.xaml
    /// </summary>
    public partial class App : Application
    {
        /// <summary>
        /// Returnes current app as an <see cref="App"/> instead of an <see cref="Application"/>
        /// </summary>
        public static App CurrentApp => (App)Current;

        /// <summary>
        /// Returens current <see cref="Configuration"/> of application
        /// </summary>
        public Configuration Configuration { get; set; }

        public static Frame MainFrame => ((MainWindow)Current.MainWindow).MainFrame;

        public App()
        {
            ToolTipService.ShowDurationProperty.OverrideMetadata(
                typeof(DependencyObject), new FrameworkPropertyMetadata(int.MaxValue));

            ToolTipService.InitialShowDelayProperty.OverrideMetadata(
                typeof(DependencyObject), new FrameworkPropertyMetadata(0));
        }
    }
}
