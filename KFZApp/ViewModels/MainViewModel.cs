using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel; //Brauchen wir für INotifyPropertyChanged
using System.Windows.Input;
using CommandHelper;
using CommonTypes;
using DataAccess;

namespace KFZApp.ViewModels
{
    class MainViewModel : INotifyPropertyChanged //vgl. abstrakten Klasse
    {
        private KFZ _selectedKFZ;
        private ICommand _saveAllKFZCommand;
        private ICommand _saveKFZDetailsCommand;
        public List<KFZ> AlleKFZs { get; set; }

        public ICommand SaveAllKFZCommand
        {
            get 
            {
                if (_saveAllKFZCommand == null)
                {
                    _saveAllKFZCommand = new RelayCommand(c => SaveAllKFZ());
                }
                return _saveAllKFZCommand;
            }
        }

        public ICommand SaveKFZDetailsCommand
        {
            get
            {
                if (_saveKFZDetailsCommand == null)
                {
                    _saveKFZDetailsCommand = new RelayCommand(d => SaveKFZDetails());
                }
                return _saveKFZDetailsCommand;
            }
        }

        public KFZ SelectedKFZ 
        {
            get { return _selectedKFZ; }
            set {
                _selectedKFZ = value;
                PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(""));
            } 
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public MainViewModel() //Standardkonstruktor
        {
            AlleKFZs = new List<KFZ>();
            AlleKFZs.Add(new KFZ() { Kennzeichen = "S-RT 584", Typ="SUV" , FahrgestellNr="FG 4245", Leistung = 1});
            AlleKFZs.Add(new KFZ() { Kennzeichen = "RT-XD 5213", Typ="Cabrio", FahrgestellNr="FG 4333", Leistung= 2 });
            AlleKFZs.Add(new KFZ() { Kennzeichen = "B-BD 4302", Typ="Crossover", FahrgestellNr = "FG 4333",Leistung= 3 });
        }

        private void SaveKFZDetails()
        {
            System.Windows.MessageBox.Show("Jetzt werden die KFZ-Details Abgespeichert");
        }

        private void SaveAllKFZ()
        {
            DataAccess.DataAccess da = new DataAccess.DataAccess();

            foreach (var kfz in AlleKFZs)
            {
                da.SaveKFZ(kfz);
            }
        }
       
    }
}
