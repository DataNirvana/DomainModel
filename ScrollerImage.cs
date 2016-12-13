using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

//------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel {
    //--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public class ScrollerImage {

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public ScrollerImage() {

        }
        ////-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        ///// <summary>
        /////     Sets whether or not to display this scroller image or not on the map or in a project description randomly
        ///// </summary>
        //public ScrollerImage(int id, string sector, string fileName, string headingText, string subTitleText) {
        //    this.id = id;
        //    this.sector = sector;
        //    this.fileName = fileName;
        //    this.headingText = headingText;
        //    this.subTitleText = subTitleText;

        //    RNGSecurity

        //    this.showOnMap = ((new Random()).Next(0, 2) == 0);
        //    string temp = "";
        //}
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        public ScrollerImage(int id, string sector, string fileName, string headingText, string subTitleText, bool showOnMap) {
            this.id = id;
            this.sector = sector;
            this.fileName = fileName;
            this.headingText = headingText;
            this.subTitleText = subTitleText;
            this.showOnMap = showOnMap;
        }


        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // ID
        private int id;
        public int ID {
            get { return id; }
            set { id = value; }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Sector
        private string sector;
        public string Sector {
            get { return sector; }
            set { sector = value; }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Just the name of the file - the directory itself is specified elsewhere
        /// </summary>
        private string fileName;
        public string FileName {
            get { return fileName; }
            set { fileName = value; }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Heading
        private string headingText;
        public string HeadingText {
            get { return headingText; }
            set { headingText = value; }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        // SubTitle
        private string subTitleText;
        public string SubTitleText {
            get { return subTitleText; }
            set { subTitleText = value; }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Show on the map (true) or just show the project description (false)
        /// </summary>
        bool showOnMap = true;
        public bool ShowOnMap {
            get { return showOnMap; }
            set { showOnMap = value; }
        }


    }
}
