using System;
using System.Collections.Generic;
using MVVMTest.ViewModels;
using Xamarin.Forms;

namespace MVVMTest
{
    public partial class TabA : ContentPage
    {
        TabAViewModel _viewModel = null;

        public TabA()
        {
            InitializeComponent();

            _viewModel = new TabAViewModel();
            BindingContext = _viewModel;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            Console.WriteLine("Debug");
        }
    }
}
