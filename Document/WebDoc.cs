using MGL.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace DataNirvana.DomainModel.Document {

    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
    public class WebDoc {

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public WebDoc() {

        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public WebDoc(int wdID) {
            this.id = wdID;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public WebDoc(int wdID, WebDocType docType, string internalDescription, int country, string image, DateTime insertDate, DateTime updateDate, int userID, int orgID) {
            this.id = wdID;
            this.documentType = docType;
            this.descriptionInternal = internalDescription;
            this.country = country;
            this.image = image;
            this.insertDate = insertDate;
            this.updateDate = updateDate;
            this.updateUserID = userID;
            this.organisationID = orgID;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int ID {
            get { return id; }
            set { id = value; }
        }
        private int id = 0;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public WebDocType DocumentType {
            get { return documentType; }
            set { documentType = value; }
        }
        private WebDocType documentType;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string DescriptionInternal {
            get { return descriptionInternal; }
            set { descriptionInternal = value; }
        }
        private string descriptionInternal = "";

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int Country {
            get { return country; }
            set { country = value; }
        }
        private int country = 0;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     We might also here want to store a converted image - or better to do this on the fly???
        /// </summary>
        public string Image {
            get { return image; }
            set { image = value; }
        }
        private string image = "";

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public DateTime InsertDate {
            get { return insertDate; }
            set { insertDate = value; }
        }
        private DateTime insertDate = DateTimeNull.NullDate;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public DateTime UpdateDate {
            get { return updateDate; }
            set { updateDate = value; }
        }
        private DateTime updateDate = DateTimeNull.NullDate;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int UpdateUserID {
            get { return updateUserID; }
            set { updateUserID = value; }
        }
        private int updateUserID = 0;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int OrganisationID {
            get { return organisationID; }
            set { organisationID = value; }
        }
        private int organisationID = 0;


        // And then here is the non relational data!

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public List<WebDocVersion> DocumentVersions {
            get { return documentVersions; }
            set { documentVersions = value; }
        }
        private List<WebDocVersion> documentVersions;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public List<WebDocChapter> DocumentChapters {
            get { return documentChapters; }
            set { documentChapters = value; }
        }
        private List<WebDocChapter> documentChapters;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public List<WebDocContent> DocumentContents {
            get { return documentContents; }
            set { documentContents = value; }
        }
        private List<WebDocContent> documentContents;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public List<WebDocTag> DocumentTags {
            get { return documentTags; }
            set { documentTags = value; }
        }
        private List<WebDocTag> documentTags;


        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Labels ...
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string LabelUpdateUserName {
            get { return labelUpdateUserName; }
            set { labelUpdateUserName = value; }
        }
        private string labelUpdateUserName = "";

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string LabelOrganisationName {
            get { return labelOrganisationName; }
            set { labelOrganisationName = value; }
        }
        private string labelOrganisationName = "";

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string LabelUpdateDate {
            get { return labelUpdateDate; }
            set { labelUpdateDate = value; }
        }
        private string labelUpdateDate = "";

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string LabelLanguages {
            get { return labelLanguages; }
            set { labelLanguages = value; }
        }
        private string labelLanguages = "";

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string LabelStatus {
            get { return labelStatus; }
            set { labelStatus = value; }
        }
        private string labelStatus = "";





        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Sorting ...
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     A sorting sub-class using Reflection ...
        /// </summary>
        public static class WebDocSorter {

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------
            /// <summary>
            ///     No try catch yet - lets see how this works out
            /// </summary>
            public static object GetPropertyValue(object obj, string propertyName) {
                return obj == null
                    ? null
                    : obj.GetType().GetProperty(propertyName).GetValue(obj, null);
            }

            //-------------------------------------------------------------------------------------------------------------------------------------------------------------
            public static void SortByPropertyName(ref List<WebDoc> list, string propertyName, SortDirection direction) {

                // I'm still not clear how the x => GetPropertyValue code syntax works ...
                if (direction == SortDirection.Ascending) {
                    list = list.OrderBy(x => WebDocSorter.GetPropertyValue(x, propertyName)).ToList();
                } else {
                    list = list.OrderByDescending(x => WebDocSorter.GetPropertyValue(x, propertyName)).ToList();
                }
            }


            //-------------------------------------------------------------------------------------------------------------------------------------------------------------
            public static void Test() {
                // the much simpler way to use Reflection
                List<WebDoc> docs = null;
                WebDoc.WebDocSorter.SortByPropertyName(ref docs, "ID", SortDirection.Ascending);

            }
        }


    }
}
