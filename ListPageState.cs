using System;
using System.Collections.Generic;
using System.Text;

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel {
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    ///     Stores the simple information related to the paging controls on lists of objects in pages / sessions ...
    /// </summary>
    public class ListPageState {

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
//        public int NumberOfResultsPerPage;
//        public int StartIndex;
//        public int EndIndex;
//        public int NumberOfPages;
//        public int CurrentPage;
//        public string HeaderText;

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private int numberOfResultsPerPage;
        public int NumberOfResultsPerPage {
            get { return numberOfResultsPerPage; }
            set { numberOfResultsPerPage = value; }
        }

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //private int numberOfPages;
        //public int NumberOfPages {
        //    get { return numberOfPages; }
        //    set { numberOfPages = value; }
        //}

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        private int currentPageIndex;
        public int CurrentPageIndex {
            get { return currentPageIndex; }
            set { currentPageIndex = value; }
        }


        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //private string id;
        //public string ID
        //{
        //    get { return id; }
        //    set { id = value; }
        //}

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //private string pageNumText;
        //public string PageNumText
        //{
        //    get { return pageNumText; }
        //    set { pageNumText = value; }
        //}

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //private string linkAction;
        //public string LinkAction
        //{
        //    get { return linkAction; }
        //    set { linkAction = value; }
        //}

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //private string tooltip;
        //public string Tooltip
        //{
        //    get { return tooltip; }
        //    set { tooltip = value; }
        //}

        //------------------------------------------------------------------------------------------------------------------------------------------------------------------
        //private bool disabled = false;
        //public bool Disabled
        //{
        //    get { return disabled; }
        //    set { disabled = value; }
        //}

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public ListPageState(int numberOfResultsPerPage, int currentPage) {
            NumberOfResultsPerPage = numberOfResultsPerPage;
//            NumberOfPages = numberOfPages;
            CurrentPageIndex = currentPage;
        }

        ////--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //public ListPageState(int numberOfResultsPerPage, int startIndex, int endIndex, int numberOfPages, int currentPage, string headerText) {
        //    NumberOfResultsPerPage = numberOfResultsPerPage;
        //    StartIndex = startIndex;
        //    EndIndex = endIndex;
        //    NumberOfPages = numberOfPages;
        //    CurrentPage = currentPage;
        //    HeaderText = headerText;
        //    ID = "lps_" + CurrentPage;
        //    LinkAction = "javascript:__forcePostBack('" + ID + "', '');";
        //    PageNumText = (CurrentPage + 1).ToString();
        //    Tooltip = "Go to page " + PageNumText;
        //}

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Note that the critical thing with this default is the NumberOfPages.  As this is zero, other code recognises this as the default
        /// </summary>
        public static ListPageState Default() {
            return new ListPageState(50, 0);
        }

    }
}
