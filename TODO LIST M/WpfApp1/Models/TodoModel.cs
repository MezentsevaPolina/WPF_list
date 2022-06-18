using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfApp1.Models
{
    class TodoModel: INotifyPropertyChanged
    {
        public DateTime MyDate { get; set; } = DateTime.Today;


        private bool _isDone;

        public bool ГОТОВНОСТЬ
        {
            get { return _isDone; }
            set 
            {
                if (_isDone == value)
                    return;
                _isDone = value;
                OnPropertyChanged("ГОТОВНОСТЬ");
            }
        }
        private string _text;

        public string ЗАДАЧА
        {
            get { return _text; }
            set 
            {
                if (_text == value)
                    return;
                _text = value;
                OnPropertyChanged("ЗАДАЧА");
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged(string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}
