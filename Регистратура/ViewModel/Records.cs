﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Регистратура.Model;

namespace Регистратура.ViewModel
{
    public class Records: Base
    {
        ClinContext db;
        public int Doctor_id;
        public DateTime d;
        private List<RecordsViewModel> allrecord;
        public List<RecordsViewModel> Allrecord
        {   get { return allrecord; }
            set { allrecord = value; OnPropertyChanged("Allrecord");  }
        }       //список докторов

        private DateTime date = /*new DateTime(2019,12,10); */ DateTime.Now;
        public Records(int Doctor_ID)
        {
            db = new ClinContext();
            Allrecord = db.Record.Where(i => i.Doctor_FK == Doctor_ID && i.Date == date.Date).ToList().Select(i => new RecordsViewModel(i)).ToList();
            Doctor_id = Doctor_ID;
            d = date.Date;
        }

       // private DateTime date = /*new DateTime(2019,12,10); */ DateTime.Now;
        public DateTime Date
        { 
            get { return date; }
            set { date = value; d = date.Date;  Allrecord = db.Record.Where(i => i.Doctor_FK == Doctor_id && i.Date == date.Date).ToList().Select(i => new RecordsViewModel(i)).ToList(); ; OnPropertyChanged("Date"); }
        }

        private RecordsViewModel selectedrecord;
        public RecordsViewModel SelectedRecord
        {
            get { return selectedrecord; }
            set
            {
                    selectedrecord = value;
                if (selectedrecord !=null && selectedrecord.Status == false)
                    Color = "#FF479C00";
                else Color = "Red";
                OnPropertyChanged("SelecRecords");

            }
        }

        private RelayCommand selectCommand;
        public RelayCommand SelectCommand
        {
            get
            {
                return selectCommand ??
                  (selectCommand = new RelayCommand(obj => {
                      
                  },
                 (obj) => (selectedrecord != null && selectedrecord.Status == false)));    //условие, при котором будет доступна команда
            }
        }

        private string color= "Red";
        public string Color
        {
            get
            {
                return color;
            }
            set { color = value; OnPropertyChanged("Color"); }
        }
    }
}
