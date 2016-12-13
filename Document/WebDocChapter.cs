using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace DataNirvana.DomainModel.Document {

    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
    public class WebDocChapter {

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public WebDocChapter() {
            // Nada
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public WebDocChapter( int webDocChapterID, int webDocID, int webDocChapterNum, string webDocChapterTitle ) {
            this.id = webDocChapterID;
            this.docID = webDocID;
            this.chapterNumber = webDocChapterNum;
            this.chapterTitle = webDocChapterTitle;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int ID {
            get { return id; }
            set { id = value; }
        }
        private int id;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int DocID {
            get { return docID; }
            set { docID = value; }
        }
        private int docID;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int ChapterNumber {
            get { return chapterNumber; }
            set { chapterNumber = value; }
        }
        private int chapterNumber;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string ChapterTitle {
            get { return chapterTitle; }
            set { chapterTitle = value; }
        }
        private string chapterTitle;




    }
}
