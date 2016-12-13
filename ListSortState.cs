using System;
using System.Collections.Generic;
using System.Text;

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel {

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    ///     A very basic sort direction enum ...
    /// </summary>
    public enum SortDirection {
        Ascending = 1,
        Descending = -1
    }

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    ///     Stores information related to the sorted state of an object ...
    ///     To Do: Switch between column name mode and column ID mode ....
    /// </summary>
    public class ListSortState {

        ////--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //private bool isSorted;
        //public bool IsSorted {
        //    get { return isSorted; }
        //    set { isSorted = value; }
        //}

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string sortedByFieldName;
        public string SortedByFieldName {
            get { return sortedByFieldName; }
            set { sortedByFieldName = value; }
        }

        ////--------------------------------------------------------------------------------------------------------------------------------------------------------------
        ///// <summary>
        /////     Feb 2010 - added col index as well - no backwards compatibility yet!
        ///// </summary>
        //private int sortedByColumnIndex;
        //public int SortedByColumnIndex {
        //    get { return sortedByColumnIndex; }
        //    set { sortedByColumnIndex = value; }
        //}

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private SortDirection sortedDirection;
        public SortDirection SortedDirection {
            get { return sortedDirection; }
            set { sortedDirection = value; }
        }



        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private bool isSortedAsc;
        public bool IsSortedAsc {
            get { return isSortedAsc; }
            set {
                isSortedAsc = value;
                sortedDirection = (isSortedAsc) ? SortDirection.Ascending : SortDirection.Descending;
            }
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public ListSortState(bool _isSortedAsc, string _sortedByFieldsName) {
//            isSorted = _isSorted;
            sortedByFieldName = _sortedByFieldsName;
            isSortedAsc = _isSortedAsc;

            sortedDirection = (isSortedAsc) ? SortDirection.Ascending : SortDirection.Descending;

//            sortedByColumnIndex = -1; // This will break if used, so need to test - the equivalent of null in this context ....
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Note that the critical thing with this default is the sortedByColumnIndex of -1.  As this is zero, other code recognises this as the default
        /// </summary>
        public static ListSortState Default() {
            return new ListSortState(true, null);
        }

    }
}
