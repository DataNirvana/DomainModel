using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace DataNirvana.DomainModel.Document {
    //-----------------------------------------------------------------------------------------------------------------------------------------------------------------
    public class WebDocStyle {

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public WebDocStyle() {

        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public WebDocStyle(int id, string name, string tag, string cssClass, int weight, bool createsNewSection, bool createsNewChapter, string description) {
            this.id = id;
            this.name = name;
            this.tag = tag;
            this.cssClass = cssClass;
            this.weight = weight;
            this.createsNewSection = createsNewSection;
            this.createsNewChapter = createsNewChapter;
            this.description = description;
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int ID {
            get { return id; }
            set { id = value; }
        }
        private int id = 0;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string Name {
            get { return name; }
            set { name = value; }
        }
        private string name = "";

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string Description {
            get { return description; }
            set { description = value; }
        }
        private string description = "";

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string Tag {
            get { return tag; }
            set { tag = value; }
        }
        private string tag = "";
        
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string CssClass {
            get { return cssClass; }
            set { cssClass = value; }
        }
        private string cssClass = "";
        
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int Weight {
            get { return weight; }
            set { weight = value; }
        }
        private int weight = 0;
        
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public bool CreatesNewSection {
            get { return createsNewSection; }
            set { createsNewSection = value; }
        }
        private bool createsNewSection = false;

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public bool CreatesNewChapter {
            get { return createsNewChapter; }
            set { createsNewChapter = value; }
        }
        private bool createsNewChapter = false;


    }
}
