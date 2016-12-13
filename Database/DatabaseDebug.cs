using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNirvana.DomainModel.Database {
    public class DatabaseDebug {

        //--
        public DatabaseDebug(int taskID, DateTime start, List<DatabaseSearchPattern> searchPatterns) {
            this.taskID = taskID;
            this.start = start;
            this.searchPatterns = searchPatterns;
        }

        //--
        public int TaskID {
            get { return taskID; }
            set { taskID = value; }
        }
        private int taskID = 0;

        //--
        public List<DatabaseSearchPattern> SearchPatterns {
            get { return searchPatterns; }
            set { searchPatterns = value; }
        }
        private List<DatabaseSearchPattern> searchPatterns;

        //--
        public string SearchPatternsAsText {
            get { return searchPatternsAsText; }
            set { searchPatternsAsText = value; }
        }
        private string searchPatternsAsText;


        //--
        public DateTime Start {
            get { return start; }
            set { start = value; }
        }
        private DateTime start;

        //--
        public double Duration {
            get { return duration; }
            set { duration = value; }
        }
        private double duration = 0; // in MS

        //--
        public int ResultCount {
            get { return resultCount; }
            set { resultCount = value; }
        }
        private int resultCount = 0;

        //--
        public bool IsFaulted {
            get { return isFaulted; }
            set { isFaulted = value; }
        }
        private bool isFaulted = false;


        //-- And add a sorter too ...
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static IComparer<DatabaseDebug> Sort(string sortField, bool isAsc) {
            if (sortField.Equals("Duration", StringComparison.CurrentCultureIgnoreCase)) {
                return new SortDuration(isAsc);
            }
            return null;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private class SortDuration : IComparer<DatabaseDebug> {
            private bool IsAscending = true;
            public SortDuration(bool isAscending) {
                IsAscending = isAscending;
            }
            int IComparer<DatabaseDebug>.Compare(DatabaseDebug a, DatabaseDebug b) {
                if (IsAscending) {
                    return (a.Duration.CompareTo(b.Duration));
                } else {
                    return (b.Duration.CompareTo(a.Duration));
                }
            }
        }




    }
}
