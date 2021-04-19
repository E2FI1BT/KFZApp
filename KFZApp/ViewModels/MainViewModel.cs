using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using KFZApp.Model;
using System.Threading.Tasks;
using System.ComponentModel; //Brauchen wir für INotifyPropertyChanged

namespace KFZApp.ViewModels
{
    class MainViewModel : INotifyPropertyChanged //vgl. abstrakten Klasse
    {
        public List<KFZ> AlleKFZs { get; set; }

        
        public MainViewModel() //Standardkonstruktor
        {
            AlleKFZs = new List<KFZ>();
            AlleKFZs.Add(new KFZ() { Kennzeichen = "S-RT 584", Typ="SUV" , FahrgestellNr="FG 4245", Leistung = 1});
            AlleKFZs.Add(new KFZ() { Kennzeichen = "RT-XD 5213", Typ="Cabrio", FahrgestellNr="FG 4333", Leistung= 2 });
            AlleKFZs.Add(new KFZ() { Kennzeichen = "B-BD 4302", Typ="Crossover", FahrgestellNr = "FG 4333",Leistung= 3 });
            //test
           
        }

        public event PropertyChangedEventHandler PropertyChanged;
    }
}
