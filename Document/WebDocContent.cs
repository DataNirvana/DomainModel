using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace DataNirvana.DomainModel.Document {

    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
    public class WebDocContent {

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public WebDocContent() {
            // Nada
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public WebDocContent( int idWDC, int docVersionIDWDC, int chapterIDWDC, int contentWeightWDC, int orderInChapterWDC, string contentTitleWDC, string contentWDC) {
            this.id = idWDC;
            this.docVersionID = docVersionIDWDC;
            this.chapterID = chapterIDWDC;
            this.contentWeight = contentWeightWDC;
            this.orderInChapter = orderInChapterWDC;
            this.contentTitle = contentTitleWDC;
            this.content = contentWDC;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int ID {
            get { return id; }
            set { id = value; }
        }
        private int id;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int DocVersionID {
            get { return docVersionID; }
            set { docVersionID = value; }
        }
        private int docVersionID;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int ChapterID {
            get { return chapterID; }
            set { chapterID = value; }
        }
        private int chapterID;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     1 = Chapter
        ///     2 = Sub Chapter
        ///     3 = Sub Sub Chapter
        ///     - Is this worth an Enum????
        /// </summary>
        public int ContentWeight {
            get { return contentWeight; }
            set { contentWeight = value; }
        }
        private int contentWeight;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int OrderInChapter {
            get { return orderInChapter; }
            set { orderInChapter = value; }
        }
        private int orderInChapter;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string ContentTitle {
            get { return contentTitle; }
            set { contentTitle = value; }
        }
        private string contentTitle;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string Content {
            get { return content; }
            set { content = value; }
        }
        private string content;


        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///  This may be a little redundant here .... as we already have a version insert date...
        /// </summary>
        //public DateTime InsertDate {
        //    get { return insertDate; }
        //    set { insertDate = value; }
        //}
        //private DateTime insertDate;

        ////--------------------------------------------------------------------------------------------------------------------------------------------------------------
        ///// <summary>
        /////  This may be a little redundant here .... as we already have a version update date...
        ///// </summary>
        //public DateTime UpdateDate {
        //    get { return updateDate; }
        //    set { updateDate = value; }
        //}
        //private DateTime updateDate;


    }
}
