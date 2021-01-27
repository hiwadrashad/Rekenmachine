using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Text;

namespace Rekenmachine.Models
{
    public class Model
    {
        string storevalue = string.Empty;
        public string Value { 
            get => storevalue;
            set
            {
                if (storevalue == value)
                    return;
                storevalue = value;
                OnPropertyChanged(nameof(Value));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged(string value)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(value));
        }
    }
}
