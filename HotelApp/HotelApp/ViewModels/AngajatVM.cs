using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HotelApp.Models;
using HotelApp.Helpers;
using System.Collections;

namespace HotelApp.ViewModels
{
    public class AngajatVM : BaseVM
    {
        HotelDBEntities MyHotel;

        public AngajatVM()
        {
            MyHotel = new HotelDBEntities();
            //var Rezervari=MyHotel.
        }

        private System.Collections.IEnumerable rooms;
        public System.Collections.IEnumerable Rooms { get => MyHotel.GetOffers(); set => SetProperty(ref rooms, value); }
        private void SetProperty(ref IEnumerable rooms, IEnumerable value)
        {
            throw new NotImplementedException();
        }
    }
}
