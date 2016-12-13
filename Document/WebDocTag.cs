using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace DataNirvana.DomainModel.Document {
    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
    public class WebDocTag {

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public WebDocTag() {

        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public WebDocTag(int id, int chapterID, string name) {
            this.id = id;
            this.chapterID = chapterID;
            this.name = name;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int ID {
            get { return id; }
            set { id = value; }
        }
        private int id;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int ChapterID {
            get { return chapterID; }
            set { chapterID = value; }
        }
        private int chapterID;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string Name {
            get { return name; }
            set { name = value; }
        }
        private string name;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static List<KeyValuePair<int, string>> ConvertToKeyValuePair(List<WebDocTag> tags) {
            List<KeyValuePair<int, string>> data = new List<KeyValuePair<int, string>>();

            foreach( WebDocTag wdt in tags ) {
                data.Add(new KeyValuePair<int, string>(wdt.ID, wdt.Name));
            }

            return data;
        }

    }
}
