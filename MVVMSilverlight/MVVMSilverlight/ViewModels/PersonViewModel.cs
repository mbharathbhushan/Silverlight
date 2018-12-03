using MVVMSilverlight.Commands;
using MVVMSilverlight.Models;
using System;
using System.Net;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Documents;
using System.Windows.Ink;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Animation;
using System.Windows.Shapes;

namespace MVVMSilverlight.ViewModels
{
    public class PersonViewModel
    {
        public PersonModel personModel { get; set; }
        public PersonViewModel()
        {
            this.personModel = new PersonModel("prabjot", 20);
        }

        public ICommand GetPerson
        {
            get { return new GetPersonCommand(this); }
        }

        public void Increaseage(PersonModel personModel)
        {
            personModel.Age++;
            string x = personModel.Age.ToString();
            MessageBox.Show(x);
        }
    }
}
