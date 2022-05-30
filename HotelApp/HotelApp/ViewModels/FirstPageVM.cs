using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.Helpers;
using HotelApp.Views;
using System.Windows.Input;

namespace HotelApp.ViewModels
{
    public class FirstPageVM
    {
        public ICommand openWindowCommand;

        public ICommand OpenWindowCommand
        {
            get 
            { 
                if(openWindowCommand == null)
                {
                    openWindowCommand = new RelayCommand(OpenWindow);
                }             
                return openWindowCommand; 
            }
        }

        public void OpenWindow(object obj)
        {
            string nr = obj as string;
            switch(nr)
            {
                case "1":
                    AdministratorView administrator = new AdministratorView();
                    administrator.ShowDialog();
                    break;
                case "2":
                    UtilizatorNeautentificatView utilizatorNeautentificat = new UtilizatorNeautentificatView();
                    utilizatorNeautentificat.ShowDialog();
                    break;
                case "3":
                    AngajatView angajat = new AngajatView();
                    angajat.ShowDialog();
                    break ;
            }
        }

        private RelayCommand addRoomCommand;

        public ICommand AddRoomCommand
        {
            get
            {
                if (addRoomCommand == null)
                {
                    addRoomCommand = new RelayCommand(AddRoom);
                }

                return addRoomCommand;
            }
        }

        private void AddRoom(object commandParameter)
        {
        }
    }
}
