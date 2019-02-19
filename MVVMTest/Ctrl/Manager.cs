using System;
using System.Collections.ObjectModel;
using System.ComponentModel;
using MVVMTest.DataModels;

namespace MVVMTest.Ctrl
{
    public class Manager : INotifyPropertyChanged
    {
        private ObservableCollection<myData> _list = null;
        private myData _currentData;
        private static Manager instance = null;
        private static readonly object padlock = new object();



        public ObservableCollection<myData> List
        {
            get
            {
                return _list;
            }
        }

        public myData CurrentData
        {
            get
            {
                return _currentData;
            }
            set
            {
                _currentData = value;
                OnPropertyChanged(new PropertyChangedEventArgs("CurrentData"));
            }
        }

        /// <summary>
        /// Gets the instance.
        /// </summary>
        /// <value>The instance.</value>
        public static Manager Instance
        {
            get
            {
                if (instance == null)
                {
                    lock (padlock)
                    {
                        if (instance == null)
                        {
                            instance = new Manager();
                        }
                    }
                }
                return instance;
            }
        }

        private Manager()
        {
            _list = new ObservableCollection<myData>();
            myData member1 = new myData();
            member1.Text = "Member 1";

            myData member2 = new myData();
            member2.Text = "Member 2";

            _list.Add(member1);
            _list.Add(member2);

            _currentData = _list[0];
        }

        public void switchCurrent()
        {
            foreach(var cur in _list)
            {
                if(cur != CurrentData)
                {
                    CurrentData = cur;
                    break;
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(PropertyChangedEventArgs e)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, e);
            }
        }
    }
}
