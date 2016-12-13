using System;
using System.Collections.Generic;
using System.Text;

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel {
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public struct MGSecurityTag {

        public string Name;
        public int SubType;
        public int ID;
        public string Description;


        public MGSecurityTag(string name, int subType) {
            SubType = subType;
            Name = name;
            ID = -1;
            Description = null;
        }
    }

    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    /// Summary description for SecurityFeatureClasses
    /// </summary>
    public static class SecurityFeatureClasses {
        public static readonly string Functionality = "functionality";
        public static readonly string Display = "display";
        public static readonly string Content = "content";
        public static readonly string User = "user";
        public static readonly string Group = "group";
    }

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public static class ContentSecurityRuleType {
        public static readonly string Address = "address";
        public static readonly string Street = "street";
        public static readonly string Report = "report";
        public static readonly string FacilityGroup = "facilitygroup";
        public static readonly string Theme = "theme";
        public static readonly string Geography = "geography";
        public static readonly string StatisticLayerGroup = "statisticlayergroup";
        public static readonly string StatisticLayer = "statisticlayer";
        public static readonly string StatisticLayerItem = "statisticlayeritem";
        public static readonly string Date = "date";
        public static readonly string Spatial = "spatialdata";
    }



    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    /// Summary description for SecurityFeatureClass
    /// </summary>
    public class MGSecurityFeatureClass {

        private int id;
        private string name;
        private string description;


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public MGSecurityFeatureClass(int featureID, string featureName, string featureDescription) {
            id = featureID;
            name = featureName;
            description = featureDescription;
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int ID {
            get { return id; }
            set { id = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string Name {
            get { return name; }
            set { name = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string Description {
            get { return description; }
            set { description = value; }
        }


    }

}
