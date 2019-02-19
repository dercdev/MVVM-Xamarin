using System;
using System.ComponentModel;

namespace MVVMTest.DataModels
{
    public class myData : INotifyPropertyChanged
    {

        private string _text;

        public string Text
        {
            get
            {
                return _text;
            }
            set
            {
                _text = value;
                OnPropertyChanged(new PropertyChangedEventArgs("Text"));

            }
        }

        public myData()
        {
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
