using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Reflection;


//----------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel {

    //------------------------------------------------------------------------------------------------------------------------------------------------------------
    public class ProjectInformation {

        public static string DBTN = "Project_Data";
        /// <summary>
        ///     The test table used to validate the data
        /// </summary>
        public static string DBTNTest = "Project_Data_TEST";
        public static string[] DBFields = {

                "ID",
		        "Project_Name",
		        "Project_Agreement_Num",
		        "What_Status",
		        "Who_Donor",
		        "Who_PM",
		        "Who_IP",
		        "Who_IPType",

		        "Ben_Pak_Total",
		        "Ben_Pak_Child_M",
		        "Ben_Pak_Adult_M",
		        "Ben_Pak_Elderly_M",
		        "Ben_Pak_Child_F",
		        "Ben_Pak_Adult_F",
		        "Ben_Pak_Elderly_F",

		        "Ben_Ref_Total",
		        "Ben_Ref_Child_M",
		        "Ben_Ref_Adult_M",
		        "Ben_Ref_Elderly_M",
		        "Ben_Ref_Child_F",
		        "Ben_Ref_Adult_F",
		        "Ben_Ref_Elderly_F",

		        "Where_Province",
		        "Where_District",
		        "Where_Tehsil",
		        "Where_Union_Council",
		        "Where_Village",

		        "Y_Coord", // Latitude
		        "X_Coord", // Longitude

		        "When_Year",
		        "When_InceptionDate",
		        "When_EndorsementDate",
		        "When_StartDate",
		        "When_EndDate",

		        "What_Sector",
		        "What_Outputs",
		        "Description",

		        "Total_Value_USD",
		        "Currency",
		        "Exchange_Rate",
		        "Total_Value_PKR"
        };


        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        public ProjectInformation() {


        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------
        // we need some way of mapping from the property names to the public facing names and also the lookup tables too ...
        // eventually this will go in the PNAIndividuals and PNACases classes as a static lookup
        public static List<WebAppMetaData> MetaData = new List<WebAppMetaData> {
            // Object name, Pretty name, type to parse to, lookup list name in the KeyInfo class
                        //_____ Project Identifiers ...
            new WebAppMetaData( "ID",                   "Project ID", "int", null ),
            new WebAppMetaData( "Name",                "Project name","string", null ),
            new WebAppMetaData( "AgreementNumber", "Agreement number", "string", null ),
            new WebAppMetaData( "WhatStatus",       "Status", "string", null  ),

            //_____ Who
            new WebAppMetaData( "LabelWhoDonor",    "Organisation (Donor)", "string", null ),
            new WebAppMetaData( "LabelWhoPM",       "Organisation (Project Manager)", "string", null ),
            new WebAppMetaData( "LabelWhoIP",       "Organisation (IP)", "string", null ),
            new WebAppMetaData( "LabelWhoIPType", "Type of IP", "string", null ),

            //_____ Beneficiary information ....
            new WebAppMetaData( "BenPakTotal",      "Total Number of Beneficiaries", "int", null ),
            new WebAppMetaData( "BenPakChildM",     "Total male children beneficiaries", "int", null ),
            new WebAppMetaData( "BenPakAdultM",     "Total male adult beneficiaries", "int", null ),
            new WebAppMetaData( "BenPakElderlyM",   "Total elderly male beneficiaries", "int", null ),
            new WebAppMetaData( "BenPakChildF", "   Total female children beneficiaries", "int", null ),
            new WebAppMetaData( "BenPakAdultF",     "Total female adult beneficiaries", "int", null ),
            new WebAppMetaData( "BenPakElderlyF",   "Total elderly female Beneficiaries", "int", null ),

            new WebAppMetaData( "BenRefTotal",      "Total refugee beneficiaries", "int", null ),
            new WebAppMetaData( "BenRefChildM",     "Refugee male children beneficiaries", "int", null ),
            new WebAppMetaData( "BenRefAdultM",     "Refugee male adult beneficiaries", "int", null ),
            new WebAppMetaData( "BenRefElderlyM",   "Refugee elderly male beneficiaries", "int", null ),
            new WebAppMetaData( "BenRefChildF",     "Refugee female children beneficiaries", "int", null ),
            new WebAppMetaData( "BenRefAdultF",     "Refugee female adult beneficiaries", "int", null ),
            new WebAppMetaData( "BenRefElderlyF",   "Refugee elderly female Beneficiaries", "int", null ),

            //_____ Where
            new WebAppMetaData( "Province", "Province", "string", null ),
            new WebAppMetaData( "District", "District", "string", null ),
            new WebAppMetaData( "Tehsil", "Tehsil", "string", null ),
            new WebAppMetaData( "UnionCouncil", "Union Council", "string", null ),
            new WebAppMetaData( "Village", "Village", "string", null ),
            new WebAppMetaData( "Latitude", "Latitude", "double", null, false ),    // Dont extract ...
            new WebAppMetaData( "Longitude", "Longitude", "double", null, false ),      // Dont Extract ...

            //_____ When
            new WebAppMetaData( "LabelWhen",         "Year", "string", null ),
            new WebAppMetaData( "WhenInception",    "Inception date", "DateTime", null ),
            new WebAppMetaData( "WhenEndorsement", "Endorsement date", "DateTime", null ),
            new WebAppMetaData( "WhenStart",            "Start date", "DateTime", null ),
            new WebAppMetaData( "WhenEnd",          "End date", "DateTime", null ),


            //_____ What
            new WebAppMetaData( "LabelWhat",          "Sector", "string", null ),
            new WebAppMetaData( "WhatOutputs",      "Outputs", "string", null ),
            new WebAppMetaData( "Description",          "Project description", "string", null ),

            //_____ Budget
            new WebAppMetaData( "TotalValueUSD",    "Total Project Value (USD)", "long", null ),
            new WebAppMetaData( "Currency",             "Currency", "string", null ),
            new WebAppMetaData( "ExchangeRate",      "Exchange Rate", "double", null ),
            new WebAppMetaData( "TotalValuePKR",    "Total Project Value (PKR)", "long", null )


        };

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     The list of specific fields (in order) to incude in each section
        /// </summary>
        public static List<WebAppDisplaySection> DisplayFieldsBySection = new List<WebAppDisplaySection>() {

            new WebAppDisplaySection( "1. Project identifiers", "HeaderBar1", new List<string>() {
                "ID", "Name", "AgreementNumber", "WhatStatus"
            }),

            new WebAppDisplaySection( "2. Who", "HeaderBar2", new List<string>() {
                "LabelWhoDonor", "LabelWhoPM", "LabelWhoIP", "LabelWhoIPType"
            }),

            new WebAppDisplaySection( "3. Beneficiary information", "HeaderBar3", new List<string>() {
                "BenPakTotal", "BenPakChildM", "BenPakAdultM", "BenPakElderlyM", "BenPakChildF", "BenPakAdultF", "BenPakElderlyF",
                "BenRefTotal", "BenRefChildM", "BenRefAdultM", "BenRefElderlyM", "BenRefChildF", "BenRefAdultF", "BenRefElderlyF"
            }),

            new WebAppDisplaySection( "4. Where", "HeaderBar4", new List<string>() {
                "Province", "District", "Tehsil", "UnionCouncil", "Village", "Latitude", "Longitude"
            }),

            new WebAppDisplaySection( "5. When", "HeaderBar5", new List<string>() {
                "LabelWhen", "WhenInception", "WhenEndorsement", "WhenStart", "WhenEnd",
            }),

            new WebAppDisplaySection( "6. What", "HeaderBar6", new List<string>() {
                "LabelWhat", "WhatOutputs", "Description"
            }),

            new WebAppDisplaySection( "7. Budget", "HeaderBar7", new List<string>() {
                "TotalValueUSD", "Currency", "ExchangeRate", "TotalValuePKR"
            }),

        };


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     A list of key value pairs with the .net object name as the key and the value being the text from the PNA annotated form
        ///     (or Eddies filler, if the annotation did not exist!!)
        ///     Note that these are for the case and individuals ...
        /// </summary>
        public static List<KeyValuePair<string, string>> MetaDataAnnotations = new List<KeyValuePair<string, string>>() {

            new KeyValuePair<string, string>( "ID", "Project ID (within the MIS)"),
            new KeyValuePair<string, string>( "Name", "Project name; common acronyms are CPI for Construction Project Initiative and DWSS for Drinking Water Supply Schemes" ),
            new KeyValuePair<string, string>( "AgreementNumber",
                @"Agreement number - organisation specific project agreement number.  Organisations manage projects in different ways.  For example, for UNDP a project is a specific activity occurring in a specific location at a specific time.  With UNHCR, on the other hand, a project can span multiple locations and even multiple activities.

In order to make the projects listed in this tool as comparable as possible, all multi-location or multi-activity projects have been disaggregated to their discrete component locations and activities.  In these cases, the number of beneficiary numbers and the overall project costs have been apportioned between each entry.  The overarching project agreement number is recorded for each of the part-projects so that the entire project can be reviewed by searching using the agreement number." ),

            new KeyValuePair<string, string>( "WhatStatus", "Status - one of planned, active / ongoing or completed." ),

            new KeyValuePair<string, string>( "LabelWhoDonor", "The name of the donor organisation providing the funding for this project.  See the full list of the organisations in the help pages." ),
            new KeyValuePair<string, string>( "LabelWhoPM", "The name of the organisation managing this project.  Note that this may be the same as the donor organisation. See the full list of the organisations in the help pages." ),
            new KeyValuePair<string, string>( "LabelWhoIP", "The name of the organisation implementing this project.  Note that this may be the same as the project management organisation. See the full list of the organisations in the help pages." ),
            new KeyValuePair<string, string>( "LabelWhoIPType",
                "Type of IP - one of INGO, NGO or GOV for international or national non-governmental organisation or a government department." ),

            new KeyValuePair<string, string>( "BenPakTotal",
                @"Total Number of Beneficiaries - includes both Pakistanis and Afghan refugees.

As noted for the agreement number, in some cases where a project spans multiple locations or comprises several activities, the beneficiary numbers for a specific location or activity might be estimated."),

            new KeyValuePair<string, string>( "BenPakChildM", "Male children beneficiaries - less than 18 years old" ),
            new KeyValuePair<string, string>( "BenPakAdultM", "Total male adult beneficiaries - between 18 and 59 (inclusive)" ),
            new KeyValuePair<string, string>( "BenPakElderlyM", "Total elderly male beneficiaries - 60 years old or more" ),
            new KeyValuePair<string, string>( "BenPakChildF", "Total female children beneficiaries - less than 18 years old" ),
            new KeyValuePair<string, string>( "BenPakAdultF", "Total female adult beneficiaries - between 18 and 59 (inclusive)" ),
            new KeyValuePair<string, string>( "BenPakElderlyF", "Total elderly female Beneficiaries - 60 years old or more" ),

            new KeyValuePair<string, string>( "BenRefTotal", "Total refugee beneficiaries is also estimated for projects spanning multiple locations or several activities." ),
            new KeyValuePair<string, string>( "BenRefChildM", "Refugee male children beneficiaries - Afghans and less than 18 years old" ),
            new KeyValuePair<string, string>( "BenRefAdultM", "Refugee male adult beneficiaries -  Afghans between 18 and 59 (inclusive)" ),
            new KeyValuePair<string, string>( "BenRefElderlyM", "Refugee elderly male beneficiaries - Afghans 60 years old or more" ),
            new KeyValuePair<string, string>( "BenRefChildF", "Refugee female children beneficiaries - Afghan and less than 18 years old" ),
            new KeyValuePair<string, string>( "BenRefAdultF", "Refugee female adult beneficiaries - Afghans between 18 and 59 (inclusive)" ),
            new KeyValuePair<string, string>( "BenRefElderlyF", "Refugee elderly female Beneficiaries - Afghans 60 years old or more" ),

            new KeyValuePair<string, string>( "Province", "Province in which the project is being / has been implemented." ),
            new KeyValuePair<string, string>( "District", "District in which the project is being / has been implemented." ),
            new KeyValuePair<string, string>( "Tehsil", "Tehsil in which the project is being / has been implemented." ),
            new KeyValuePair<string, string>( "UnionCouncil", "Union council in which the project is being / has been implemented." ),
            new KeyValuePair<string, string>( "Village", "Village in which the project is being / has been implemented." ),
            new KeyValuePair<string, string>( "Latitude", "Latitude or 'y' coordinate of the project in decimal degrees (e.g. 35.00342)." ),
            new KeyValuePair<string, string>( "Longitude", "Longitude or 'x' coordinate of the project in decimal degrees (e.g. 71.84939)." ),


            new KeyValuePair<string, string>( "LabelWhen",
                @"Year in which the project was implemented.

The vast majority of projects are designed to be relatively small and implemented quickly in three to six months.

In the rare cases where a project spans multiple years, the year noted here is the year in which the majority of the implementation occurred." ),
            new KeyValuePair<string, string>( "WhenInception",
                "Inception date, also known as the 'PTF' date or the date on which the Provincial Task Force first met to discuss the project." ),
            new KeyValuePair<string, string>( "WhenEndorsement", "Date of endorsement by the RAHA project team" ),
            new KeyValuePair<string, string>( "WhenStart", "Start date of the implementation phase" ),
            new KeyValuePair<string, string>( "WhenEnd", "End date of the project" ),

            new KeyValuePair<string, string>( "LabelWhat",
                "The sector is one of:"
                + "<ul class='ULCompressed'>"

                +"<li>Admin</li>"
                +"<li>Education</li>"
                +"<li>Food Security</li>"
                +"<li>Health</li>"
                +"<li>Infrastructure - e.g. rehabilitation of street pavements</li>"
                +"<li>Livelihoods</li>"
                +"<li>Social Cohesion</li>"
                +"<li>Solar - Projects with a component of solar energy</li>"
                +"<li>WASH - Water, Sanitation and Hygiene including the construction of water supply schemes</li>"

                + "</ul>"
                +"Note that a few projects incorporate multiple sectors; in these cases the primary sector is listed here" ),

            new KeyValuePair<string, string>( "WhatOutputs", "Outputs - the specific RAHA deliverables, including one or more of the following:"
                + "<ul class='ULCompressed'>"

                +"<li>111: Form community organization (CO)</li>"
                +"<li>112: Form village organization (VO)</li>"
                +"<li>113: Form local support organization (LSO)</li>"
                +"<li>114: Train CO representatives in CMST</li>"
                +"<li>115: Train VO representatives in LMST</li>"
                +"<li>121: Train government officials in relevant professional expertise</li>"
                +"<li>211: Train community members from most vulnerable households on different potential vocations</li>"
                +"<li>212: Strengthen government employment information/extension centers</li>"
                +"<li>221: Road or Street Projects</li>"
                +"<li>222: Solar or alternate energy projects</li>"
                +"<li>223: Irrigation projects</li>"
                +"<li>224: Agriculture projects</li>"
                +"<li>225: Livestock projects</li>"
                +"<li>226: Training of O and M committee members completed</li>"

                +"<li>230: Rehabilitate or construct major physical infrastructure at the tehsil/union council level based on the need assessment</li>"
                +"<li>232: Rehabilitate or construct basic Community Physical Infrastructure (CPIs) through the communities</li>"

                +"<li>311: Drinking water supply project</li>"
                +"<li>312: Sanitation project</li>"
                +"<li>313: Health project</li>"
                +"<li>314: Education project</li>"
                +"<li>315: Awareness raised on health and hygiene</li>"
                +"<li>316: Awareness raised on clean drinking water and improved sanitation</li>"
                +"<li>411: Child protection centres strengthened</li>"
                +"<li>412: Women welfare centres strengthened</li>"
                +"<li>413: Drug rehabilitation centres strengthened</li>"
                +"<li>414: Mentally retarded people centre strengthened</li>"
                +"<li>415: Any other social welfare centre strengthened</li>"
                +"<li>416: Establish protection committee to address GBV issues</li>"
                +"<li>417: Community members trained on GBV</li>"
                +"<li>418: Community members trained on human rights</li>"
                +"<li>419: Awareness raised on GBV issues</li>"
                +"<li>4110: Awareness raised on peace building and social cohesion</li>"
                +"<li>511: Agro-forestry nurseries established/rehabilitated and functional</li>"
                +"<li>512: Awareness raised on solid &amp; liquid waste management</li>"
                +"<li>513: Solid waste management committees formed</li>"
                +"<li>521: Flood protections projects</li>"
                +"<li>522: Nature and environmental conservation projects</li>"

                + "</ul>"
                ),

            new KeyValuePair<string, string>( "Description",
                @"Detailed description of the specific activities in each project and any other relevant information.

Common acronyms are CPI for Construction Project Initiative and DWSS for Drinking Water Supply Schemes" ),

            new KeyValuePair<string, string>( "TotalValueUSD",
                @"Total project value in US dollars (USD).  As noted above, in some cases where a project spans multiple locations or activities, the project value for a specific location might be estimated.

Also, it is important to note that the value of each project listed in this tool only relates to the direct implementation costs and does not include the wider management and administrative costs.  The <a href='http://www.rahapakistan.org/?page_id=27'>total RAHA funding and contributions</a> summarises all of these together." ),

            new KeyValuePair<string, string>( "Currency",
                @"The type of currency in which the project funding was provided (e.g. USD, GBP, EUR or PKR)." ),
            new KeyValuePair<string, string>( "ExchangeRate",
                "The exchange rate used during this project, which will vary depending on when the project agreement was signed and / or the project was implemented." ),
            new KeyValuePair<string, string>( "TotalValuePKR",
                "Total project value in Pakistani rupees (PKR) calculated using the exchange rate that was used during the project implementation." )

    };

        // For reference - the database fields ...
        // ID, Project_Name, Sector, Year, Project_Lead, Beneficiary_Total, Total_Amount, District, Tehsil, Union_Council, Village

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     The property names and their proper name to be displayed in e.g. CSV Exports ...
        /// </summary>
        //public static List<KeyValuePair<string, string>> PropertyProperNamesToDisplay = new List<KeyValuePair<string, string>>() {

        //    //_____ Project Identifiers ...
        //    new KeyValuePair<string, string> ( "ID", "Project ID" ),
        //    new KeyValuePair<string, string> ( "Name", "Project name" ),
        //    new KeyValuePair<string, string> ( "AgreementNumber", "Agreement number" ),
        //    new KeyValuePair<string, string> ( "WhatStatus", "Status" ),

        //    //_____ Who
        //    new KeyValuePair<string, string> ( "LabelWhoDonor", "Organisation (Donor)" ),
        //    new KeyValuePair<string, string> ( "LabelWhoPM", "Organisation (Project Manager)" ),
        //    new KeyValuePair<string, string> ( "LabelWhoIP", "Organisation (IP)" ),
        //    new KeyValuePair<string, string> ( "LabelWhoIPType", "Type of IP" ),

        //    //_____ Beneficiary information ....
        //    new KeyValuePair<string, string> ( "BenPakTotal", "Total Number of Beneficiaries" ),
        //    new KeyValuePair<string, string> ( "BenPakChildM", "Total male children beneficiaries" ),
        //    new KeyValuePair<string, string> ( "BenPakAdultM", "Total male adults beneficiaries" ),
        //    new KeyValuePair<string, string> ( "BenPakElderlyM", "Total elderly male beneficiaries" ),
        //    new KeyValuePair<string, string> ( "BenPakChildF", "Total female children beneficiaries" ),
        //    new KeyValuePair<string, string> ( "BenPakAdultF", "Total female adult beneficiaries" ),
        //    new KeyValuePair<string, string> ( "BenPakElderlyF", "Total elderly female Beneficiaries" ),

        //    new KeyValuePair<string, string> ( "BenRefTotal", "Total refugee beneficiaries" ),
        //    new KeyValuePair<string, string> ( "BenRefChildM", "Refugee male children beneficiaries" ),
        //    new KeyValuePair<string, string> ( "BenRefAdultM", "Refugee male adults beneficiaries" ),
        //    new KeyValuePair<string, string> ( "BenRefElderlyM", "Refugee elderly male beneficiaries" ),
        //    new KeyValuePair<string, string> ( "BenRefChildF", "Refugee female children beneficiaries" ),
        //    new KeyValuePair<string, string> ( "BenRefAdultF", "Refugee female adult beneficiaries" ),
        //    new KeyValuePair<string, string> ( "BenRefElderlyF", "Refugee elderly female Beneficiaries" ),

        //    //_____ Where
        //    new KeyValuePair<string, string> ( "Province", "Province" ),
        //    new KeyValuePair<string, string> ( "District", "District" ),
        //    new KeyValuePair<string, string> ( "Tehsil", "Tehsil" ),
        //    new KeyValuePair<string, string> ( "UnionCouncil", "UnionCouncil" ),
        //    new KeyValuePair<string, string> ( "Village", "Village" ),
        //    new KeyValuePair<string, string> ( "", "Latitude" ),    // Dont extract ...
        //    new KeyValuePair<string, string> ( "", "Longitude" ),      // Dont Extract ...

        //    //_____ When
        //    new KeyValuePair<string, string> ( "LabelWhen", "Year" ),
        //    new KeyValuePair<string, string> ( "WhenInception", "Inception date" ),
        //    new KeyValuePair<string, string> ( "WhenEndorsement", "Endorsement date" ),
        //    new KeyValuePair<string, string> ( "WhenStart", "Start date" ),
        //    new KeyValuePair<string, string> ( "WhenEnd", "End date" ),


        //    //_____ What
        //    new KeyValuePair<string, string> ( "LabelWhat", "Sector" ),
        //    new KeyValuePair<string, string> ( "WhatOutputs", "Outputs" ),
        //    new KeyValuePair<string, string> ( "Description", "Project description" ),

        //    //_____ Budget
        //    new KeyValuePair<string, string> ( "TotalValueUSD", "Total Project Value (USD)" ),
        //    new KeyValuePair<string, string> ( "Currency", "Currency" ),
        //    new KeyValuePair<string, string> ( "ExhangeRate", "Exchange Rate" ),
        //    new KeyValuePair<string, string> ( "TotalValuePKR", "Total Project Value (PKR)" )

        //};


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Gets the values as a string list from all of the properties to be displayed in the front end
        ///     To Do - in the future this should also include for the different types, with the Date, Int, Double and Strings accomodated accordingly.
        ///     IncludeAllFields allows us to override the specific export flags in the WAMD.  This means e.g. the geocodes can be exported for administrators only
        /// </summary>
        /// <returns></returns>
        public List<object> GetDisplayData(bool includeAllFields) {
            List<object> data = new List<object>();

            Type thisType = this.GetType();

            foreach (WebAppMetaData wamd in MetaData) {
                // note that this is pretty basic for now - in the future we might want to make this sexier ...
                object myVal = null;
                Object obj = null;

                if (wamd.IncludeInExport == true || includeAllFields == true) {
                    PropertyInfo propInfo = thisType.GetProperty(wamd.PropertyName);
                    if (propInfo != null) {
                        obj = propInfo.GetValue(this, null);

                        if (obj != null) {
                            myVal = obj; //.ToString();
                        }
                    }
                }
                data.Add(myVal);
            }

            return data;
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Old School way to get the data - this take around 1 millisecond, compared to the 8 milliseconds for the Reflection based method above, but is
        ///     obviously much clunkier - lets try to use the reflection based method unless the website performance degrades significantly ....
        /// </summary>
        /// <returns></returns>
        public List<string> GetDisplayDataNonReflection() {
            List<string> data = new List<string>();

            //data.Add( this.ID.ToString());
            //data.Add( this.Name.ToString());
            //data.Add( this.LabelWhoDonor.ToString());
            //data.Add(this.LabelWhoPM.ToString());
            //data.Add(this.LabelWhoIP.ToString());
            //data.Add( this.LabelWhat.ToString());
            //data.Add( this.LabelWhen.ToString());
            //data.Add( this.Province.ToString());
            //data.Add( this.District.ToString());
            //data.Add( this.Tehsil.ToString());
            //data.Add( this.Village.ToString());
            //data.Add( this.LabelTotalBeneficiaries.ToString());
            //data.Add( this.LabelTotalProjectValue.ToString());

            return data;
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     ID
        /// </summary>
        private int id;
        public int ID {
            get { return id; }
            set { id = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///    Project_Name
        /// </summary>
        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///    Project_Agreement_Num
        /// </summary>
        private string agreementNumber;
        public string AgreementNumber {
            get { return agreementNumber; }
            set { agreementNumber = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///    What_Status
        /// </summary>
        private string whatStatus;
        public string WhatStatus {
            get { return whatStatus; }
            set { whatStatus = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Who - Donor - Who_Donor (after extracted to label)
        /// </summary>
        private int infoWhoDonor;
        public int InfoWhoDonor {
            get { return infoWhoDonor; }
            set { infoWhoDonor = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Who - the textual Label - not ideal to include this in the object, but this is needed to make the grid views, well, work!
        /// </summary>
        private string labelWhoDonor;
        public string LabelWhoDonor {
            get { return labelWhoDonor; }
            set { labelWhoDonor = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Who - Who_PM (after extracted to label)
        /// </summary>
        private int infoWhoPM;
        public int InfoWhoPM {
            get { return infoWhoPM; }
            set { infoWhoPM = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Who - the textual Label - not ideal to include this in the object, but this is needed to make the grid views, well, work!
        /// </summary>
        private string labelWhoPM;
        public string LabelWhoPM {
            get { return labelWhoPM; }
            set { labelWhoPM = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Who - Who_IP (after extracted to label)
        /// </summary>
        private int infoWhoIP;
        public int InfoWhoIP {
            get { return infoWhoIP; }
            set { infoWhoIP = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Who - the textual Label - not ideal to include this in the object, but this is needed to make the grid views, well, work!
        /// </summary>
        private string labelWhoIP;
        public string LabelWhoIP {
            get { return labelWhoIP; }
            set { labelWhoIP = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Who - Who_IPType (after extracted to label)
        /// </summary>
        private int infoWhoIPType;
        public int InfoWhoIPType {
            get { return infoWhoIPType; }
            set { infoWhoIPType = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Who - the textual Label - not ideal to include this in the object, but this is needed to make the grid views, well, work!
        /// </summary>
        private string labelWhoIPType;
        public string LabelWhoIPType {
            get { return labelWhoIPType; }
            set { labelWhoIPType = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Ben_Pak_Total
        /// </summary>
        private int benPakTotal;
        public int BenPakTotal {
            get { return benPakTotal; }
            set { benPakTotal = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Label for Ben_Pak_Total (for the search results!!!
        /// </summary>
        private string labelBenPakTotal;
        public string LabelBenPakTotal {
            get { return labelBenPakTotal; }
            set { labelBenPakTotal = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Ben_Pak_Child_M
        /// </summary>
        private int benPakChildM;
        public int BenPakChildM {
            get { return benPakChildM; }
            set { benPakChildM = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Ben_Pak_Adult_M
        /// </summary>
        private int benPakAdultM;
        public int BenPakAdultM {
            get { return benPakAdultM; }
            set { benPakAdultM = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Ben_Pak_Elderly_M
        /// </summary>
        private int benPakElderlyM;
        public int BenPakElderlyM {
            get { return benPakElderlyM; }
            set { benPakElderlyM = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Ben_Pak_Child_F
        /// </summary>
        private int benPakChildF;
        public int BenPakChildF {
            get { return benPakChildF; }
            set { benPakChildF = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Ben_Pak_Adult_F
        /// </summary>
        private int benPakAdultF;
        public int BenPakAdultF {
            get { return benPakAdultF; }
            set { benPakAdultF = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Ben_Pak_Elderly_F
        /// </summary>
        private int benPakElderlyF;
        public int BenPakElderlyF {
            get { return benPakElderlyF; }
            set { benPakElderlyF = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Ben_Ref_Total
        /// </summary>
        private int benRefTotal;
        public int BenRefTotal {
            get { return benRefTotal; }
            set { benRefTotal = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Ben_Ref_Child_M
        /// </summary>
        private int benRefChildM;
        public int BenRefChildM {
            get { return benRefChildM; }
            set { benRefChildM = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Ben_Ref_Adult_M
        /// </summary>
        private int benRefAdultM;
        public int BenRefAdultM {
            get { return benRefAdultM; }
            set { benRefAdultM = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Ben_Ref_Elderly_M
        /// </summary>
        private int benRefElderlyM;
        public int BenRefElderlyM {
            get { return benRefElderlyM; }
            set { benRefElderlyM = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Ben_Ref_Child_F
        /// </summary>
        private int benRefChildF;
        public int BenRefChildF {
            get { return benRefChildF; }
            set { benRefChildF = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Ben_Ref_Adult_F
        /// </summary>
        private int benRefAdultF;
        public int BenRefAdultF {
            get { return benRefAdultF; }
            set { benRefAdultF = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Ben_Ref_Elderly_F
        /// </summary>
        private int benRefElderlyF;
        public int BenRefElderlyF {
            get { return benRefElderlyF; }
            set { benRefElderlyF = value; }
        }



        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Where - Province, District
        /// </summary>
        private int infoWhere;
        public int InfoWhere {
            get { return infoWhere; }
            set { infoWhere = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Where - Province, District
        /// </summary>
        private string labelWhere;
        public string LabelWhere {
            get { return labelWhere; }
            set { labelWhere = value; }
        }



        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Province				Where_Province
        /// </summary>
        private string province;
        public string Province {
            get { return province; }
            set { province = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    District	        Where_District
        /// </summary>
        private string district;
        public string District {
            get { return district; }
            set { district = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Tehsil		        Where_Tehsil
        /// </summary>
        private string tehsil;
        public string Tehsil {
            get { return tehsil; }
            set { tehsil = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Union_Council				Where_Union_Council
        /// </summary>
        private string unionCouncil;
        public string UnionCouncil {
            get { return unionCouncil; }
            set { unionCouncil = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Village			        Where_Village
        /// </summary>
        private string village;
        public string Village {
            get { return village; }
            set { village = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    X_Coord				X_Coord
        /// </summary>
        private double longitude;
        public double Longitude {
            get { return longitude; }
            set { longitude = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Y_Coord				Y_Coord
        /// </summary>
        private double latitude;
        public double Latitude {
            get { return latitude; }
            set { latitude = value; }
        }



        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    When - Year - When_Year
        /// </summary>
        private int infoWhen;
        public int InfoWhen {
            get { return infoWhen; }
            set { infoWhen = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    When - the textual Label - not ideal to include this in the object, but this is needed to make the grid views, well, work!
        /// </summary>
        private string labelWhen;
        public string LabelWhen {
            get { return labelWhen; }
            set { labelWhen = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    When - Year - When_InceptionDate
        /// </summary>
        private DateTime whenInception;
        public DateTime WhenInception {
            get { return whenInception; }
            set { whenInception = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    When -  When_EndorsementDate
        /// </summary>
        private DateTime whenEndorsement;
        public DateTime WhenEndorsement {
            get { return whenEndorsement; }
            set { whenEndorsement = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    When - When_StartDate
        /// </summary>
        private DateTime whenStart;
        public DateTime WhenStart {
            get { return whenStart; }
            set { whenStart = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    When - When_EndDate
        /// </summary>
        private DateTime whenEnd;
        public DateTime WhenEnd {
            get { return whenEnd; }
            set { whenEnd = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    What - Sector - What_Sector
        /// </summary>
        private int infoWhat;
        public int InfoWhat {
            get { return infoWhat; }
            set { infoWhat = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    What - What_Sector - the textual Label - not ideal to include this in the object, but this is needed to make the grid views, well, work!
        /// </summary>
        private string labelWhat;
        public string LabelWhat {
            get { return labelWhat; }
            set { labelWhat = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Description
        /// </summary>
        private string description;
        public string Description {
            get { return description; }
            set { description = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    What_Outputs
        /// </summary>
        private string whatOutputs;
        public string WhatOutputs {
            get { return whatOutputs; }
            set { whatOutputs = value; }
        }




        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Total_Value_USD
        /// </summary>
        private long totalValueUSD;
        public long TotalValueUSD {
            get { return totalValueUSD; }
            set { totalValueUSD = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Total_Value_USD LABEL!!!!
        /// </summary>
        private string labelTotalValueUSD;
        public string LabelTotalValueUSD {
            get { return labelTotalValueUSD; }
            set { labelTotalValueUSD = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Total_Value_PKR
        /// </summary>
        private long totalValuePKR;
        public long TotalValuePKR {
            get { return totalValuePKR; }
            set { totalValuePKR = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Exchange_Rate
        /// </summary>
        private double exchangeRate;
        public double ExchangeRate {
            get { return exchangeRate; }
            set { exchangeRate = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///	    Currency
        /// </summary>
        private string currency;
        public string Currency {
            get { return currency; }
            set { currency = value; }
        }




















        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     A sorting sub-class using Reflection ...
        /// </summary>
        public static class ProjectInformationSorter {

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------
            /// <summary>
            ///     No try catch yet - lets see how this works out
            /// </summary>
            public static object GetPropertyValue(object obj, string propertyName) {
                return obj == null
                    ? null
                    : obj.GetType().GetProperty(propertyName).GetValue(obj, null);
            }

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------
            public static void SortByPropertyName(ref List<ProjectInformation> list, string propertyName, SortDirection direction) {

                // I'm still not clear how the x => GetPropertyValue code syntax works ...
                if ( direction == SortDirection.Ascending) {
                    list = list.OrderBy(x => ProjectInformationSorter.GetPropertyValue(x, propertyName)).ToList();
                } else {
                    list = list.OrderByDescending(x => ProjectInformationSorter.GetPropertyValue(x, propertyName)).ToList();
                }
            }


            //-------------------------------------------------------------------------------------------------------------------------------------------------------------
            public static void Test() {
                // the much simpler way to use Reflection
                List<ProjectInformation> idpgs = null;
                ProjectInformationSorter.SortByPropertyName(ref idpgs, "Name", SortDirection.Ascending);

            }
        }



    }

}
