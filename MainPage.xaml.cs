using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Navigation;
using Microsoft.Phone.Controls;
using Microsoft.Phone.Shell;
using TestToastinetProject.Resources;

namespace TestToastinetProject
{
    public partial class MainPage : PhoneApplicationPage
    {
        // Constructor
        public MainPage()
        {
            InitializeComponent();
        }

        private void MessageBoxBtn_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("This is a simple message box");
        }

        private void ToastBtn_Click(object sender, RoutedEventArgs e)
        {
            MyToast.Message = "This is a toast message";
            
        }
    }
}