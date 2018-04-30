﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TutorialSamplesMVVM.ChangeNotificationSample.ViewModels;

namespace TutorialSamplesMVVM.ChangeNotificationSample.Data
{
    class User
    {
        UserViewModel userViewModel = new UserViewModel();
        private string name;
        public string Name
        {
            get { return this.name; }
            set
            {
                if (this.name != value)
                {
                    this.name = value;
                    userViewModel.NotifyPropertyChanged("Name");
                }
            }
        }        
    }
}
