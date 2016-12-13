using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel.HumanitarianActivities {

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    ///     A Humanitarian Image of activities ....
    /// </summary>
    public struct ActivityImage {
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public ActivityImage(
            int id,
            string countryISO,
            string fileName,
            string description,
            DateTime metaStartDate, DateTime metaChangeDate) {

            this.id = id;
            this.countryISO = countryISO;
            this.fileName = fileName;
            this.description = description;
            this.metaStartDate = metaStartDate;
            this.metaChangeDate = metaChangeDate;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private int id;
        public int ID {
            get { return id; }
            set { id = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string countryISO;
        public string CountryISO {
            get { return countryISO; }
            set { countryISO = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string fileName;
        public string FileName {
            get { return fileName; }
            set { fileName = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string description;
        public string Description {
            get { return description; }
            set { description = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private DateTime metaStartDate;
        public DateTime MetaStartDate {
            get { return metaStartDate; }
            set { metaStartDate = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private DateTime metaChangeDate;
        public DateTime MetaChangeDate {
            get { return metaChangeDate; }
            set { metaChangeDate = value; }
        }


    }


}