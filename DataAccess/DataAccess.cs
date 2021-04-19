using CommonTypes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;


namespace DataAccess
{
    public class DataAccess
    {
        public void SaveKFZ(KFZ kfz)
        {
            MessageBox.Show($"Data-Access SaveKFZ {kfz.Kennzeichen}");
            //In Azure-DB speichern.
        }
    }
}
