using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace Garsonum_Design.Models
{
    public class PlacesList
    {
        public ObservableCollection<PlacesModel> PlaceList { get; set; }

        public PlacesList()
        {
            PlaceList = new ObservableCollection<PlacesModel>
            {
                new PlacesModel{PlaceId = "1", PhotoUrl = "https://i.hizliresim.com/dvMjDV.jpg", Title = "Arabica", Content = "Selam canım ben amcan."},
                new PlacesModel{PlaceId = "2", PhotoUrl = "https://i.hizliresim.com/lq4YRb.jpg", Title = "Monti", Content = "Selam bebek ben kelebek."},
                new PlacesModel{PlaceId = "3", PhotoUrl = "https://i.hizliresim.com/6aMR1P.jpg", Title = "Eti Cin", Content = "Ağla tarık."},
                new PlacesModel{PlaceId = "4", PhotoUrl = "https://i.hizliresim.com/26P7lq.jpg", Title = "Netflix", Content = "Kolay kapanıyomuş diyoğlar."},
                new PlacesModel{PlaceId = "5", PhotoUrl = "http://1.bp.blogspot.com/_qK_Zui1UM9E/SMFPnJ9REgI/AAAAAAAAE0A/nMLy-AKeVa8/s400/kuala+(9).jpg", Title = "Kuala", Content = "Ne diyom be"},
                new PlacesModel{PlaceId = "6", PhotoUrl = "https://i.hizliresim.com/dvMjDV.jpg", Title = "Arabica", Content = "Selam canım ben amcan."},
                new PlacesModel{PlaceId = "7", PhotoUrl = "https://i.hizliresim.com/lq4YRb.jpg", Title = "Monti", Content = "Selam bebek ben kelebek."},
                new PlacesModel{PlaceId = "8", PhotoUrl = "https://i.hizliresim.com/6aMR1P.jpg", Title = "Eti Cin", Content = "Ağla tarık."},
                new PlacesModel{PlaceId = "9", PhotoUrl = "https://i.hizliresim.com/26P7lq.jpg", Title = "Netflix", Content = "Kolay kapanıyomuş diyoğlar."},
                new PlacesModel{PlaceId = "10", PhotoUrl = "http://1.bp.blogspot.com/_qK_Zui1UM9E/SMFPnJ9REgI/AAAAAAAAE0A/nMLy-AKeVa8/s400/kuala+(9).jpg", Title = "Kuala", Content = "Ne diyom be"}
            };
        }
    }
}