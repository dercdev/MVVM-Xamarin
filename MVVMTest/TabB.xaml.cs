using System;
using System.Collections.Generic;
using MVVMTest.ViewModels;
using Xamarin.Forms;

namespace MVVMTest
{
    public partial class TabB : ContentPage
    {
        TabBViewModel _viewModel = null;

        public TabB()
        {
            InitializeComponent();

            _viewModel = new TabBViewModel();

            BindingContext = _viewModel;
        }

        void Handle_Clicked(object sender, System.EventArgs e)
        {
            _viewModel.changeCurrentDataText(entryText.Text);
        }

        void Handle_Clicked_1(object sender, System.EventArgs e)
        {
            _viewModel.switchCurrent();
        }
    }
}
