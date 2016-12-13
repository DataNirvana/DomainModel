using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel.HumanitarianActivities {

    //-------------------------------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    ///     23-Jun-14 = Added so that we can switch on which geographic level to build a KeyValuePair(int, string) list (See the GeographicUnitProcessing class)
    /// </summary>
    public enum GeographicLevel {
        Admin1 = 1,
        Admin2 = 2,
        Admin3 = 3,
        Admin4 = 4
    }

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    /// Summary description for GeogName
    /// </summary>
    public struct GeographicUnit {
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public GeographicUnit(
            int id,
            string countryISO, string countryName, int countryCode,
            string admin1Name, long admin1Code,
            string admin2Name, long admin2Code,
            string admin3Name, long admin3Code,
            string admin4Name, long admin4Code,
            string fullTextualName, int numPeople, int numHouseholds,
            double latitude, double longitude, double area) {

            this.id = id;
            this.countryISO = countryISO;
            this.countryName = countryName;
            this.countryCode = countryCode;
            this.admin1Name = admin1Name;
            this.admin1Code = admin1Code;
            this.admin2Name = admin2Name;
            this.admin2Code = admin2Code;
            this.admin3Name = admin3Name;
            this.admin3Code = admin3Code;
            this.admin4Name = admin4Name;
            this.admin4Code = admin4Code;
            this.fullText = fullTextualName;
            this.numberOfPeople = numPeople;
            this.numberOfHouseholds = numHouseholds;
            this.latitude = latitude;
            this.longitude = longitude;
            this.area = area;
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
        private string countryName;
        public string CountryName {
            get { return countryName; }
            set { countryName = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private int countryCode;
        public int CountryCode {
            get { return countryCode; }
            set { countryCode = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string admin1Name;
        public string Admin1Name {
            get { return admin1Name; }
            set { admin1Name = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private long admin1Code;
        public long Admin1Code {
            get { return admin1Code; }
            set { admin1Code = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string admin2Name;
        public string Admin2Name {
            get { return admin2Name; }
            set { admin2Name = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private long admin2Code;
        public long Admin2Code {
            get { return admin2Code; }
            set { admin2Code = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string admin3Name;
        public string Admin3Name {
            get { return admin3Name; }
            set { admin3Name = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private long admin3Code;
        public long Admin3Code {
            get { return admin3Code; }
            set { admin3Code = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string admin4Name;
        public string Admin4Name {
            get { return admin4Name; }
            set { admin4Name = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private long admin4Code;
        public long Admin4Code {
            get { return admin4Code; }
            set { admin4Code = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string fullText;
        public string FullText {
            get { return fullText; }
            set { fullText = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private int numberOfPeople;
        public int NumberOfPeople {
            get { return numberOfPeople; }
            set { numberOfPeople = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private int numberOfHouseholds;
        public int NumberOfHouseholds {
            get { return numberOfHouseholds; }
            set { numberOfHouseholds = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private double latitude;
        public double Latitude {
            get { return latitude; }
            set { latitude = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private double longitude;
        public double Longitude {
            get { return longitude; }
            set { longitude = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private double area;
        public double Area {
            get { return area; }
            set { area = value; }
        }


    }


}