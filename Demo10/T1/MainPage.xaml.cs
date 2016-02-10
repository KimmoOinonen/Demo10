/*
 * Copyright (C) Kimmo Oinonen
 *
 * This file is part of homework project in Object-Oriented
 * and GUI Programming class in JAMK.
 *
 * Created: 10.2.2016
 * Author: Kimmo Oinonen
 */
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.ViewManagement;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace T1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();

            // change default window startup mode
            ApplicationView.PreferredLaunchWindowingMode
                = ApplicationViewWindowingMode.PreferredLaunchViewSize;
            // window size
            ApplicationView.PreferredLaunchViewSize = new Size(800, 600);
        }

        private void buyButton_Click(object sender, RoutedEventArgs e)
        {
            string product = "";
            if ((bool)milkCheckBox.IsChecked)
            {
                product += " milk "; 
            }

            if ((bool)butterCheckBox.IsChecked)
            {
                product += " butter ";
            }

            if ((bool)beerCheckBox.IsChecked)
            {
                product += " beer ";
            }

            if ((bool)chickenCheckBox.IsChecked)
            {
                product += " chicken ";
            }

            if ((bool)lemonadeCheckBox.IsChecked)
            {
                product += " lemonade ";
            }

            listTextBox.Text = product;
        }
    }
}
