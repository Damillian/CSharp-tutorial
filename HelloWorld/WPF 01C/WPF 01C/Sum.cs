using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPF_01C
{
    public class Sum : INotifyPropertyChanged
    {

        private string num1;
        private string num2;
        private string result;

        public string Num1 { 
            get
            {
                return num1;
            }

            set
            {
                int number;
                bool res = int.TryParse(value, out number);
                if (res) num1 = number.ToString();
                OnPropertyChanged("Num1");
                OnPropertyChanged("Result");
            }
        }

        public string Num2
        {
            get
            {
                return num2;
            }

            set
            {
                int number;
                bool res = int.TryParse(value, out number);
                if (res) num2 = number.ToString();
                OnPropertyChanged("Num2");
                OnPropertyChanged("Result");
            }
        }

        public string Result
        {
            get
            {
                return (int.Parse(Num1) + int.Parse(Num2)).ToString();
            }
            set
            {
                result = (int.Parse(Num1) + int.Parse(Num2)).ToString();
                OnPropertyChanged("Result");
            }
        }



        public event PropertyChangedEventHandler PropertyChanged;

        private void OnPropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
    }
}
