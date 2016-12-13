using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Text;

//------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel {

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    ///     A simple RSS Item
    /// </summary>
    public struct RSSItem {
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public RSSItem(
            int id,
            string url,
            string title,
            string summary,
            string content,
            string source,
            DateTime publicationDate,
            List<string> countryISOs) {

            this.id = id;
            this.url = url;
            this.title = title;
            this.summary = summary;
            this.content = content;
            this.source = source;
            this.publicationDate = publicationDate;
            this.countryISOs = countryISOs;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private int id;
        public int ID {
            get { return id; }
            set { id = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string url;
        public string Url {
            get { return url; }
            set { url = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string title;
        public string Title {
            get { return title; }
            set { title = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string content;
        public string Content {
            get { return content; }
            set { content = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string summary;
        public string Summary {
            get { return summary; }
            set { summary = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string source;
        public string Source {
            get { return source; }
            set { source = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private DateTime publicationDate;
        public DateTime PublicationDate {
            get { return publicationDate; }
            set { publicationDate = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private List<string> countryISOs;
        public List<string> CountryISOs {
            get { return countryISOs; }
            set { countryISOs = value; }
        }


    }
}

