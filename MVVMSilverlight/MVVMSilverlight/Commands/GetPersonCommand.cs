using MVVMSilverlight.ViewModels;
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

namespace MVVMSilverlight.Commands
{
    public class GetPersonCommand : ICommand
    {

        PersonViewModel personViewModel;
        public GetPersonCommand(PersonViewModel personViewModel)
        {
            this.personViewModel = personViewModel;
        }

        public bool CanExecute(object parameter)
        {
            if (this.personViewModel.personModel.Age > 25)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public event EventHandler CanExecuteChanged;

        public void Execute(object parameter)
        {
            this.personViewModel.Increaseage(this.personViewModel.personModel);
        }
    }
}
