using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel {

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    ///     Records the fields to be displayed in a specific section of a PNA Case or PNA Individual Object
    ///     (should cater for both individuals and relatives)
    /// </summary>
    public class WebAppDisplaySection {

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        public WebAppDisplaySection() {

        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        public WebAppDisplaySection(string sectionName, string cssClass, List<string> properties) {
            this.sectionName = sectionName;
            this.cssClass = cssClass;
            this.properties = properties;
        }


        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string sectionName;
        public string SectionName {
            get { return sectionName; }
            set { sectionName = value; }
        }


        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string cssClass;
        public string CssClass {
            get { return cssClass; }
            set { cssClass = value; }
        }


        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        private List<string> properties;
        public List<string> Properties {
            get { return properties; }
            set { properties = value; }
        }

    }
}
