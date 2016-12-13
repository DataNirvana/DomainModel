using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel.Spatial {

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    ///     A Humanitarian Image of activities ....
    /// </summary>
    public struct SpatialReference {
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public SpatialReference(
            int zoomLevel,
            double latitude,
            double longitude,
            double altitude ) {

                this.latitude = latitude;
                this.longitude = longitude;
                this.altitude = altitude;
                this.zoomLevel = zoomLevel;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private int zoomLevel;
        public int ZoomLevel {
            get { return zoomLevel; }
            set { zoomLevel = value; }
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
        private double altitude;
        public double Altitude {
            get { return altitude; }
            set { altitude = value; }
        }



        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Get the Google zoom level based on the area, Zoom level ranges from 1 to 23, with 23 people being visible ...
        /// </summary>
        public static int GetZoomLevel(double area) {

            int zoomLevel = 1; // the default - global ....

            // Max level should be about 8 or so ....

            double[] areaThresholds = {
                    12000000,           // Fucking big - only russia ....
                    6000000,            // Big - US, China, Brazil, Australia
                    2000000,
                    1000000,
                    100000,
                    50000,
                    25000,
                    5000,
                    1000,
                    100
            };

            int zl = 2;
            foreach( double areaThreshold in areaThresholds ) {
                if ( area > areaThreshold ) {
                    zoomLevel = zl;
                    break;
                }
                zl++;
            }
            if (area < areaThresholds[areaThresholds.Length - 1]) {
                zoomLevel = zl;
            }

            return zoomLevel;
        }


    }
}