using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel.HumanitarianActivities {

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    ///     A Humanitarian Indicator of activities ....
    /// </summary>
    public struct Indicator {
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public Indicator(
            int id,
            string phase,
            int sectorCode, string sectorName, string subSectorName, string indicatorName, string indicatorText,
            string unitOfMeasurementIndicator, string unitOfMeasurementOutcome,
            string questionIndicator, string questionOutcome,
            DateTime metaStartDate, DateTime metaChangeDate) {

            this.id = id;
            this.phase = phase;
            this.sectorCode = sectorCode;
            this.sectorName = sectorName;
            this.subSectorName = subSectorName;
            this.indicatorName = indicatorName;
            this.indicatorDisplayText = indicatorText;
            this.unitOfMeasurementIndicator = unitOfMeasurementIndicator;
            this.unitOfMeasurementOutcome = unitOfMeasurementOutcome;
            this.questionIndicator = questionIndicator;
            this.questionOutcome = questionOutcome;
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
        private string phase;
        /// <summary>
        ///     Emergency or Early Recovery ....
        /// </summary>
        public string Phase {
            get { return phase; }
            set { phase = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private int sectorCode;
        public int SectorCode {
            get { return sectorCode; }
            set { sectorCode = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string sectorName;
        public string SectorName {
            get { return sectorName; }
            set { sectorName = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string subSectorName;
        public string SubSectorName {
            get { return subSectorName; }
            set { subSectorName = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string indicatorName;
        public string IndicatorName {
            get { return indicatorName; }
            set { indicatorName = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string indicatorDisplayText;
        public string IndicatorDisplayText {
            get { return indicatorDisplayText; }
            set { indicatorDisplayText = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string unitOfMeasurementIndicator;
        public string UnitOfMeasurementIndicator {
            get { return unitOfMeasurementIndicator; }
            set { unitOfMeasurementIndicator = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string unitOfMeasurementOutcome;
        public string UnitOfMeasurementOutcome {
            get { return unitOfMeasurementOutcome; }
            set { unitOfMeasurementOutcome = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string questionIndicator;
        public string QuestionIndicator {
            get { return questionIndicator; }
            set { questionIndicator = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string questionOutcome;
        public string QuestionOutcome {
            get { return questionOutcome; }
            set { questionOutcome = value; }
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