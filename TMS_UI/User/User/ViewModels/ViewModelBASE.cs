//
// FILE          : ViewModelBASE.cs
// PROJECT       : OMNI TMS GROUP 13
// PROGRAMMER    : Justin, Quade, Evan, Anthony
// FIRST VERSION : December 7, 2021
// DESCRIPTION   : This file contains the ViewModelBASE class which is the parent of all view models
//
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel;

namespace User.ViewModels
{
    //PARENT CLASS OF ALL VIEW MODELS
    public class ViewModelBASE : INotifyPropertyChanged, IDisposable
    {
        public event PropertyChangedEventHandler PropertyChanged;
        
        protected void OnPropertyChanged(string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public virtual void Dispose()
        {

        }
    }
}
