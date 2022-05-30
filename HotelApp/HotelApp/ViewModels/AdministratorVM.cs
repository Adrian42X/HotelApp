using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using HotelApp.Helpers;
using HotelApp.Models;
using HotelApp.Views;
using System.Windows;
using System.Windows.Input;
using System.Collections;
using System.Data.SqlClient;

namespace HotelApp.ViewModels
{
    public class AdministratorVM : BaseVM
    {
        HotelDBEntities MyHotel;
 
        public AdministratorVM()
        {
            MyHotel = new HotelDBEntities();
            //var RoomList = MyHotel.GetRooms();
        }

        private string errorMessage;
        public string ErrorMessage
        {
            get => errorMessage;
            set
            {
                errorMessage = value;
                NotifyPropertyChanged("ErrorMessage");
            }
        }  

        public string _roomNr;
        public string RoomNr
        {
            get
            {
                return _roomNr; 
            }
            set
            {
                _roomNr = value;
                NotifyPropertyChanged(nameof(RoomNr));
            }
        }

        public string _roomFeature;
        public string RoomFeature
        {
            get
            {
                return _roomFeature;
            }
            set
            {
                _roomFeature = value;
                NotifyPropertyChanged(nameof(RoomFeature));
            }
        }

        public string _roomPrice;
        public string RoomPrice
        {
            get
            {
                return _roomPrice;
            }
            set
            {
                _roomPrice = value;
                NotifyPropertyChanged(nameof(RoomPrice));
            }
        }

        public string _roomService;
        public string RoomService
        {
            get
            {
                return _roomService;
            }
            set
            {
                _roomService = value;
                NotifyPropertyChanged(nameof(RoomService));
            }
        }

        public void AddMethod(object obj)
        {
            if (RoomNr.ToString() == "")
                MessageBox.Show("Nu e pusa camera");
            else
            {
                int nr = int.Parse(RoomNr.ToString());
                MyHotel.AddRoom(nr);
                MyHotel.SaveChanges();
            }
            return;
        }

        public void DeleteMethod(object obj)
        {
            if (RoomNr.ToString() == "")
                MessageBox.Show("Nu e pusa camera");
            else
            {
                int nr = int.Parse(RoomNr.ToString());
                MyHotel.DeleteRoom(nr);
                MyHotel.SaveChanges();
            }
            return;
        }

        public void UpdateFeatureMethod(object obj)
        {
            if (RoomFeature.ToString() == "" || RoomNr.ToString()=="")
                MessageBox.Show("Specificati dotarea si camera");
            else
            {
                int nr = int.Parse(RoomNr.ToString());
                MyHotel.UpdateRoomFeature(nr, RoomFeature.ToString());
                MyHotel.SaveChanges();
            }
        }

        public void UpdatePriceMethod(object obj)
        {
            if (RoomPrice.ToString() == "" || RoomNr.ToString() == "")
                MessageBox.Show("Specificati pretul si camera");
            else
            {
                int nr = int.Parse(RoomNr.ToString());
                int price=int.Parse(RoomPrice.ToString());
                MyHotel.UpdateRoomPrice(nr,price);
                MyHotel.SaveChanges();
            }
        }

        public void UpdateRoomServiceMethod(object obj)
        {
            if (RoomService.ToString() == "" || RoomNr == "")
                MessageBox.Show("Specificati serviciile si camera");
            else
            {
                int nr=int.Parse(RoomNr.ToString());
                MyHotel.UpdateRoomService(nr, RoomService.ToString());
                MyHotel.SaveChanges();
            }
        }

        public ICommand addRoomCommand;
        public ICommand AddRoomCommand
        {
            get
            {
                if(addRoomCommand == null)
                {
                    addRoomCommand = new RelayCommand(AddMethod);
                }
                return addRoomCommand;
            }
        }
        public ICommand deleteRoomCommand;
        public ICommand DeleteRoomCommand
        {
            get
            {
                if (deleteRoomCommand == null)
                {
                    deleteRoomCommand = new RelayCommand(DeleteMethod);
                }
                return deleteRoomCommand;
            }
        }

        public ICommand updateFeatureCommand;
        public ICommand UpdateFeatureCommand
        {
            get
            {
                if(updateFeatureCommand == null)
                {
                    updateFeatureCommand = new RelayCommand(UpdateFeatureMethod);
                }
                return updateFeatureCommand;
            }
        }

        public ICommand updatePriceCommand;
        public ICommand UpdatePriceCommand
        {
            get
            {
                if (updatePriceCommand == null)
                {
                    updatePriceCommand = new RelayCommand(UpdatePriceMethod);
                }
                return updatePriceCommand;
            }
        }

        public ICommand updateRoomServiceCommand;
        public ICommand UpdateRoomServiceCommand
        {
            get
            {
                if(updateRoomServiceCommand==null)
                {
                    updateRoomServiceCommand = new RelayCommand(UpdateRoomServiceMethod);
                }
                return updateRoomServiceCommand;
            }
        }

        private System.Collections.IEnumerable rooms;
        public System.Collections.IEnumerable Rooms { get => MyHotel.GetRooms(); set => SetProperty(ref rooms, value); }
        private void SetProperty(ref IEnumerable rooms, IEnumerable value)
        {
            throw new NotImplementedException();
        }
    }
}
