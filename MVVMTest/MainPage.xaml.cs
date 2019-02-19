using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace MVVMTest
{
    public partial class MainPage : TabbedPage
    {
        public MainPage()
        {
            InitializeComponent();

            ContentPage child = new TabA();
            child.Title = "TabA";
            this.Children.Add(child);

            child = new TabB();
            child.Title = "TabB";
            this.Children.Add(child);
        }
    }
}
