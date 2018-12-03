using System;
using System.ComponentModel;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace MVVMSilverlight.Models
{
    public class PersonModel : INotifyPropertyChanged
    {

        public event PropertyChangedEventHandler PropertyChanged;

        string name;
        public string Name
        {
            get { return this.name; }
            set
            {
                this.name = value;
                fire("Name");
            }
        }

        int age;
        public int Age
        {
            get { return this.age; }
            set
            {
                this.age = value;
                fire("Age");
            }
        }

        public PersonModel() { }
        public PersonModel(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void fire(string x)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(x));
            }
        }
    }
}
