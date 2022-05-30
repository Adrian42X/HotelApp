using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using HotelApp.Helpers;
using HotelApp.Models;
using HotelApp.ViewModels;
using HotelApp.Views;

namespace HotelApp.ViewModels
{
    internal class UtilizatorNeautentificatVM : BaseVM
    {
        HotelDBEntities MyHotel;
        public UtilizatorNeautentificatVM()
        {
            MyHotel = new HotelDBEntities();
            var RoomsList = MyHotel.GetRoomTypes();
        }

        public ICommand openSearchCommand;
        public ICommand OpenSearchCommand
        {
            get
            {
                if (openSearchCommand == null)
                {
                    openSearchCommand = new RelayCommand(OpenWindow);
                }
                return openSearchCommand;
            }
        }

        public DateTime _dateIn;
        public DateTime DateIn
        {
            get
            {
                return _dateIn;
            }
            set
            {
                _dateIn = value;
                NotifyPropertyChanged(nameof(DateIn));
            }
        }

        public DateTime _dateOut;
        public DateTime DateOut
        {
            get
            {
                return _dateOut;
            }
            set
            {
                _dateOut = value;
                NotifyPropertyChanged(nameof(DateOut));
            }
        }


        public void OpenWindow(object obj)
        {
            SearchRoomsView window = new SearchRoomsView(DateIn,DateOut); 
            window.ShowDialog();
        }

        private System.Collections.IEnumerable rooms;
        public System.Collections.IEnumerable Rooms { get => MyHotel.GetRoomTypes(); set => SetProperty(ref rooms, value); }
        private void SetProperty(ref IEnumerable rooms, IEnumerable value)
        {
            throw new NotImplementedException();
        }
    }
}
