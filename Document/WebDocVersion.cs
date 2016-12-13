using MGL.DomainModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace DataNirvana.DomainModel.Document {

    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
    public class WebDocVersion {

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public WebDocVersion() {

        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public WebDocVersion(int id, int docID) {
            this.id = id;
            this.docID = docID;
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public WebDocVersion(int id, int docID, int status, string title, string description, string language, DateTime publicationDate, DateTime insertDate, DateTime updateDate) {
            this.id = id;
            this.docID = docID;

            this.status = status;
            this.title = title;
            this.description = description;
            this.language = language;
            this.publicationDate = publicationDate;
            this.insertDate = insertDate;
            this.updateDate = updateDate;
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int ID {
            get { return id; }
            set { id = value; }
        }
        private int id = 0;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int DocID {
            get { return docID; }
            set { docID = value; }
        }
        private int docID = 0;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int Status {
            get { return status; }
            set { status = value; }
        }
        private int status = 0;


        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string Title {
            get { return title; }
            set { title = value; }
        }
        private string title = "";

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string Description {
            get { return description; }
            set { description = value; }
        }
        private string description = "";

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string Language {
            get { return language; }
            set { language = value; }
        }
        private string language = "";

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public DateTime PublicationDate {
            get { return publicationDate; }
            set { publicationDate = value; }
        }
        private DateTime publicationDate = DateTimeNull.NullDate;


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


    }
}
