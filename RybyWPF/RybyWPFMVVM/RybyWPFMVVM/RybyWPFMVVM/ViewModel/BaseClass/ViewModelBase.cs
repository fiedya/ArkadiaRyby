﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RybyWPFMVVM.ViewModel.BaseClass
{
        class ViewModelBase : INotifyPropertyChanged
    {

        //zdarzenie informujące o zmiane własności w obiekcie ViewModelu
        public event PropertyChangedEventHandler PropertyChanged;

        //metoda zgłaszająca zmiany w własościach podanych jako argumenty
        protected void onPropertyChanged(params string[] namesOfProperties)
        {
            //jeśli ktoś obserwuje zdarzenie PropertyChanged
            if (PropertyChanged != null)
            {
                //wywołanie zdarzenia dla wszystkich zgłoszonych do aktualizacji własności
                //w ten sposób powiadamiamy widok o zmianie stanu własności
                //w ViewModel
                foreach (var prop in namesOfProperties)
                {
                    PropertyChanged(this, new PropertyChangedEventArgs(prop));
                }
            }
        }

    }
}
