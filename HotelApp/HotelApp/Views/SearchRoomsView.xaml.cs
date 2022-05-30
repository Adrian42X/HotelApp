using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;
using HotelApp.Models;

namespace HotelApp.Views
{
    /// <summary>
    /// Interaction logic for SearchRoomsView.xaml
    /// </summary>
    public partial class SearchRoomsView : Window
    {
        HotelDBEntities MyHotel;
        public SearchRoomsView(DateTime datein,DateTime dateout)
        {
            MyHotel = new HotelDBEntities();
            InitializeComponent();
            roomlist.ItemsSource = MyHotel.GetAvailableRooms(datein, dateout);
        }
    }
}
