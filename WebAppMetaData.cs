using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//----------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel {

    //-------------------------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    ///     Defines the mappings between properties (not fields) in DomainModel classes, and their friendly front facing names
    ///     as well as the related static lookup list, if this field is not a simple string or integer value
    ///     3-Oct-2015
    /// </summary>
    public class WebAppMetaData {

        //---------------------------------------------------------------------------------------------------------------------------------------------------
        private string propertyName;
        public string PropertyName {
            get { return propertyName; }
            set { propertyName = value; }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------
        private string prettyName;
        public string PrettyName {
            get { return prettyName; }
            set { prettyName = value; }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------
        private string type;
        public string Type {
            get { return type; }
            set { type = value; }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------
        private string lookupList;
        public string LookupList {
            get { return lookupList; }
            set { lookupList = value; }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------
        private bool includeInExport;
        public bool IncludeInExport {
            get { return includeInExport; }
            set { includeInExport = value; }
        }


        //---------------------------------------------------------------------------------------------------------------------------------------------------
        public WebAppMetaData() {

        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------
        public WebAppMetaData(string propertyName, string prettyName, string type, string lookupList) {
            this.propertyName = propertyName;
            this.prettyName = prettyName;
            this.type = type;
            this.lookupList = lookupList;
            this.includeInExport = true;
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------
        public WebAppMetaData(string propertyName, string prettyName, string type, string lookupList, bool includeInExport) {
            this.propertyName = propertyName;
            this.prettyName = prettyName;
            this.type = type;
            this.lookupList = lookupList;
            this.includeInExport = true;
            this.includeInExport = includeInExport;
        }


        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        public static WebAppMetaData GetWAMDItem(List<WebAppMetaData> wamdList, string propertyName) {

            WebAppMetaData wamd = null;

            if (wamdList != null && propertyName != null) {
                foreach (WebAppMetaData tempWAMD in wamdList) {
                    if (tempWAMD.PropertyName.Equals(propertyName)) {
                        wamd = tempWAMD;
                        break;
                    }
                }
            }
            return wamd;
        }


    }
}
