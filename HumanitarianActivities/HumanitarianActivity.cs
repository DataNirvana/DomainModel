using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//-----------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel.HumanitarianActivities {

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------
    public class HumanitarianActivity {

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public HumanitarianActivity() {

        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // ID
        private int id;
        public int ID {
            get { return id; }
            set { id = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Meta - Start Date
        private DateTime metaStartDate;
        public DateTime MetaStartDate {
            get { return metaStartDate; }
            set { metaStartDate = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Meta - Change Date
        private DateTime metaChangeDate;
        public DateTime MetaChangeDate {
            get { return metaChangeDate; }
            set { metaChangeDate = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Who - Organisation Code
        private int whoOrgCode;
        public int WhoOrganisationCode {
            get { return whoOrgCode; }
            set { whoOrgCode = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Who - Other Organisation Name
        private string whoOrgNameAlt;
        public string WhoOrganisationNameAlternative {
            get { return whoOrgNameAlt; }
            set { whoOrgNameAlt = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Who - Add Organisation to List
        private bool whoAddOrganisationToList;
        public bool WhoAddOrganisationToList {
            get { return whoAddOrganisationToList; }
            set { whoAddOrganisationToList = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Who - Implementing Partner Code
        private int whoImplementingPartnerCode;
        public int WhoImplementingPartnerCode {
            get { return whoImplementingPartnerCode; }
            set { whoImplementingPartnerCode = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Who - Implementing Partner Alternative
        private string whoImplementingPartnerNameAlt;
        public string WhoImplementingPartnerNameAlternative {
            get { return whoImplementingPartnerNameAlt; }
            set { whoImplementingPartnerNameAlt = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Who - Contact Name
        private string whoContactName;
        public string WhoContactName {
            get { return whoContactName; }
            set { whoContactName = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Who - Contact Email
        private string whoContactEmail;
        public string WhoContactEmail {
            get { return whoContactEmail; }
            set { whoContactEmail = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Who - Contact Designation
        private string whoContactDesignation;
        public string WhoContactDesignation {
            get { return whoContactDesignation; }
            set { whoContactDesignation = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Who - Contact Number
        private long whoContactNumber;
        public long WhoContactNumber {
            get { return whoContactNumber; }
            set { whoContactNumber = value; }
        }



        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // What - Project Reference
        private string whatProjectReference;
        public string WhatProjectReference {
            get { return whatProjectReference; }
            set { whatProjectReference = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // What - Sector Code
        private int whatSector;
        public int WhatSector {
            get { return whatSector; }
            set { whatSector = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // What - Activity Code
        private int whatActivity;
        public int WhatActivity {
            get { return whatActivity; }
            set { whatActivity = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // What - Description
        private string whatActivityDesc;
        public string WhatActivityDesc {
            get { return whatActivityDesc; }
            set { whatActivityDesc = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // What - How Many?
        private int whatHowMany;
        public int WhatHowMany {
            get { return whatHowMany; }
            set { whatHowMany = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // What - How Many - in terms of the outcomes ...
        private int whatOutcome;
        public int WhatOutcome {
            get { return whatOutcome; }
            set { whatOutcome = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // What - Which Units? -------------------------------

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // What - Activity State?
        private int whatActivityState;
        public int WhatActivityState {
            get { return whatActivityState; }
            set { whatActivityState = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // What - Estimated Value
        private long whatEstimatedValue;
        public long WhatEstimatedValue {
            get { return whatEstimatedValue; }
            set { whatEstimatedValue = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Where - Country
        private int whereCountryCode;
        public int WhereCountryCode {
            get { return whereCountryCode; }
            set { whereCountryCode = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Where - Province
        private int whereProvinceCode;
        public int WhereProvinceCode {
            get { return whereProvinceCode; }
            set { whereProvinceCode = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Where - District
        private long whereDistrictCode;
        public long WhereDistrictCode {
            get { return whereDistrictCode; }
            set { whereDistrictCode = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Where - Tehsil
        private long whereTehsilCode;
        public long WhereTehsilCode {
            get { return whereTehsilCode; }
            set { whereTehsilCode = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Where - UC PCode
        private long whereUCCode;
        public long WhereUCCode {
            get { return whereUCCode; }
            set { whereUCCode = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Where - UC Text String
        private string whereLocationTextString;
        public string WhereLocationTextString {
            get { return whereLocationTextString; }
            set { whereLocationTextString = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Where - Village Or Site Name
        private string whereVillageOrSiteName;
        public string WhereVillageOrSiteName {
            get { return whereVillageOrSiteName; }
            set { whereVillageOrSiteName = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Where - Latitude
        private double whereLatitude;
        public double WhereLatitude {
            get { return whereLatitude; }
            set { whereLatitude = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Where - Longitude
        private double whereLongitude;
        public double WhereLongitude {
            get { return whereLongitude; }
            set { whereLongitude = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // When - Start Date
        private DateTime whenStartDate;
        public DateTime WhenStartDate {
            get { return whenStartDate; }
            set { whenStartDate = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        // When - End Date
        private DateTime whenEndDate;
        public DateTime WhenEndDate {
            get { return whenEndDate; }
            set { whenEndDate = value; }
        }




    }
}
