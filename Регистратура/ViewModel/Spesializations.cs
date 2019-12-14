using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Регистратура.Model;

namespace Регистратура.ViewModel
{
    public class Spesializations : Base
    {
        ClinContext db;
        public List<Spesiality> Allspesialities { get; set; }       //список специальностей

        public Spesializations()
        {
            db = new ClinContext();
            Allspesialities = db.Spesiality.ToList();
        }

        private Spesiality selectSpesialities;      //Выбранная специальность
        public Spesiality SelectSpesialities
        {
            get
            {
                return selectSpesialities;
            }
            set
            {
                selectSpesialities = value;
                OnPropertyChanged("SelectSpesialities");
            }
        }

        private RelayCommand selectCommand;
        public RelayCommand SelectCommand
        {
            get
            {
                return selectCommand ??
                  (selectCommand = new RelayCommand(obj => { },
                 (obj) => (selectSpesialities != null)));    //условие, при котором будет доступна команда
            }
        }
    }
}
