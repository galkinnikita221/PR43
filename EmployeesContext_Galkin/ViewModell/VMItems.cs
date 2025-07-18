﻿using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace EmployeesContext_Galkin.ViewModell
{
    public class VMItems : INotifyPropertyChanged
    {
        public ObservableCollection<Context.ItemsContext> Items { get; set; }
        public classes.RelayCommand NewItem
        {
            get
            {
                return new classes.RelayCommand(obj =>
                {
                    Context.ItemsContext newModell = new Context.ItemsContext(true);
                    Items.Add(newModell);
                    MainWindow.init.frame.Navigate(new View.Add(newModell));
                });
            }
        }

        public VMItems() => Items = Context.ItemsContext.AllItems();
        public event PropertyChangedEventHandler PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string prop = "")
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(prop));
            }
        }
    }
}
