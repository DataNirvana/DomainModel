using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel.HumanitarianActivities {

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    ///     A Humanitarian Organisation
    ///     3-Nov-16 - The icon and webIcon are the names of the files stored in the web.config(DropboxRootFolder)/logos/ folder
    /// </summary>
    public struct Organisation {
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public Organisation(
            int id, string organisationAcronym,
            string organisationName, string organisationAddress, 
            string orgIcon, string orgWebIcon,
            int loginUserID,
            string contactName, long contactNumber, string contactDesignation, string contactEmail,
            DateTime startDate, DateTime changeDate,
            double latitude, double longitude) {

            this.id = id;
            this.organisationAcronym = organisationAcronym;
            this.organisationName = organisationName;
            this.organisationAddress = organisationAddress;

            this.organisationIcon = orgIcon;
            this.organisationWebIcon = orgWebIcon;

            this.loginUserID = loginUserID;
            this.contactName = contactName;
            this.contactNumber = contactNumber;
            this.contactDesignation = contactDesignation;
            this.contactEmail = contactEmail;
            this.metaStartDate = startDate;
            this.metaChangeDate = changeDate;
            this.latitude = latitude;
            this.longitude = longitude;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int ID {
            get { return id; }
            set { id = value; }
        }
        private int id;

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Added 2-Nov-16 to support systems like GHSP
        /// </summary>
        public string OrganisationAcronym {
            get { return organisationAcronym; }
            set { organisationAcronym = value; }
        }
        private string organisationAcronym;

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string OrganisationName {
            get { return organisationName; }
            set { organisationName = value; }
        }
        private string organisationName;


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string OrganisationAddress {
            get { return organisationAddress; }
            set { organisationAddress = value; }
        }
        private string organisationAddress;

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string OrganisationIcon {
            get { return organisationIcon; }
            set { organisationIcon = value; }
        }
        private string organisationIcon;

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string OrganisationWebIcon {
            get { return organisationWebIcon; }
            set { organisationWebIcon = value; }
        }
        private string organisationWebIcon;


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public double Latitude {
            get { return latitude; }
            set { latitude = value; }
        }
        private double latitude;

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public double Longitude {
            get { return longitude; }
            set { longitude = value; }
        }
        private double longitude;

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int LoginUserID {
            get { return loginUserID; }
            set { loginUserID = value; }
        }
        private int loginUserID;

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string ContactName {
            get { return contactName; }
            set { contactName = value; }
        }
        private string contactName;

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public long ContactNumber {
            get { return contactNumber; }
            set { contactNumber = value; }
        }
        private long contactNumber;

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string ContactDesignation {
            get { return contactDesignation; }
            set { contactDesignation = value; }
        }
        private string contactDesignation;

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string ContactEmail {
            get { return contactEmail; }
            set { contactEmail = value; }
        }
        private string contactEmail;

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public DateTime MetaStartDate {
            get { return metaStartDate; }
            set { metaStartDate = value; }
        }
        private DateTime metaStartDate;

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public DateTime MetaChangeDate {
            get { return metaChangeDate; }
            set { metaChangeDate = value; }
        }
        private DateTime metaChangeDate;



    }


}