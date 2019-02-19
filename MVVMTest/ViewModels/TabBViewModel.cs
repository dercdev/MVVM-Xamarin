using System;
using MVVMTest.Ctrl;

namespace MVVMTest.ViewModels
{
    public class TabBViewModel : ViewModelBase
    {
        Manager _mgr = null;
       
        public TabBViewModel()
        {
            _mgr = Manager.Instance;
        }

        public void changeCurrentDataText(string text)
        {
            _mgr.CurrentData.Text = text;
        }

        internal void switchCurrent()
        {
            _mgr.switchCurrent();
        }
    }
}
