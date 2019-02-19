using System;
using MVVMTest.Ctrl;
using MVVMTest.DataModels;

namespace MVVMTest.ViewModels
{
    public class TabAViewModel : ViewModelBase
    {
        Manager _mgr = null;

        public myData CurrentData
        {
            get
            {
                return _mgr.CurrentData;
            }
            set
            {
                _mgr.CurrentData = value;
                OnPropertyChanged();
            }
        }


        public TabAViewModel()
        {
            _mgr = Manager.Instance;
        }
    }
}
