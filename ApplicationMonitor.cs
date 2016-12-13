using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

//-----------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel {

    //--------------------------------------------------------------------------------------------------------------------------------------------------------------
    public class ApplicationMonitor {

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        public ApplicationMonitor () {

        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Adds one to the counter and resets the counter if the current date and time has popped over into the next hour ...
        /// </summary>
        public void Increment() {

            DateTime now = DateTime.Now;

            // check the hour component - if this is not the same (normally more, but maybe less when we go from 23 to 00
            if (now.Hour != this.hour) {
                this.hour = now.Hour;
                this.TimeStamp = now;
                this.totalPageRequests = 0;
            }

            // increment the counter
            totalPageRequests++;

        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        private int hour;
        public int Hour {
            get { return hour; }
            set { hour = value; }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        private DateTime timeStamp;
        public DateTime TimeStamp {
            get { return timeStamp; }
            set { timeStamp = value; }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        private int totalPageRequests= 0;
        public int TotalPageRequests {
            get { return totalPageRequests; }
            set { totalPageRequests = value; }
        }

    }
}
