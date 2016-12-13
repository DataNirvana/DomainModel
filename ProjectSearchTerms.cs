using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;


//----------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel {

    //------------------------------------------------------------------------------------------------------------------------------------------------------------
    public class ProjectSearchTerms {

        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        public ProjectSearchTerms() {


        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// </summary>
        public ProjectSearchTerms(int whoDonor, int whoPM, int whoIP, int whatSector, int whatOutput, int where, int startYear, int endYear, string projectID) {

            this.whoDonor = whoDonor;
            this.whoPM = whoPM;
            this.whoIP = whoIP;
            this.whatSector = whatSector;
            this.whatOutput = whatOutput;
            this.where = where;
            this.whenFrom = startYear;
            this.whenTo = endYear;
            this.projectID = projectID;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// </summary>
        private int whoDonor;
        public int WhoDonor {
            get { return whoDonor; }
            set { whoDonor = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// </summary>
        private int whoPM;
        public int WhoPM {
            get { return whoPM; }
            set { whoPM = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// </summary>
        private int whoIP;
        public int WhoIP {
            get { return whoIP; }
            set { whoIP = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// </summary>
        private int whatSector;
        public int WhatSector {
            get { return whatSector; }
            set { whatSector = value; }
        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// </summary>
        private int whatOutput;
        public int WhatOutput {
            get { return whatOutput; }
            set { whatOutput = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// </summary>
        private int where;
        public int Where {
            get { return where; }
            set { where = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// </summary>
        private int whenFrom;
        public int WhenFrom {
            get { return whenFrom; }
            set { whenFrom = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        /// </summary>
        private int whenTo;
        public int WhenTo {
            get { return whenTo; }
            set { whenTo = value; }
        }

        ////-------------------------------------------------------------------------------------------------------------------------------------------------------------
        ///// <summary>
        /////	    Start Date
        ///// </summary>
        //private DateTime startDate;
        //public DateTime StartDate {
        //    get { return startDate; }
        //    set { startDate = value; }
        //}


        ////-------------------------------------------------------------------------------------------------------------------------------------------------------------
        ///// <summary>
        /////	    End Date
        ///// </summary>
        //private DateTime endDate;
        //public DateTime EndDate {
        //    get { return endDate; }
        //    set { endDate = value; }
        //}


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     The ID or agreement number
        /// </summary>
        private string projectID;
        public string ProjectID {
            get { return projectID; }
            set { projectID = value; }
        }


    }


}
