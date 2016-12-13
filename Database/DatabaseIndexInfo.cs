using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-----
namespace DataNirvana.DomainModel.Database {
    //-----
    public class DatabaseIndexInfo {

        //-----
        public DatabaseIndexInfo() {
        }
        //-----
        public DatabaseIndexInfo(string iName, string iType, SearchType searchType, double min, double max) {
            this.indexName = iName;
            this.indexType = iType;
            this.searchType = searchType;
            minMax = new KeyValuePair<double, double>(min, max);
        }

        //-----
        // e.g. MyFieldName
        public string IndexName {
            get { return indexName; }
            set { indexName = value; }
        }
        string indexName = "";

        //-----
        // e.g. Int or Bool
        public string IndexType {
            get { return indexType; }
            set { indexType = value; }
        }
        string indexType = "";


        //-----
        // e.g. A score
        public SearchType SearchType {
            get { return searchType; }
            set { searchType = value; }
        }
        SearchType searchType = SearchType.Score;

        //-----
        // e.g. 53 to 89
        public KeyValuePair<double, double> MinMax {
            get { return minMax; }
            set { minMax = value; }
        }
        KeyValuePair<double, double> minMax = new KeyValuePair<double, double>(0, 0);


        //----- Gets the % coverage for the range expressed in rsp as a proportion of the min and max identied in the list of indices ...
        public static double GetCoverage(List<DatabaseIndexInfo> riis, DatabaseSearchPattern rsp) {
            double coverage = 0;

            if (riis != null && rsp != null ) {
                foreach (DatabaseIndexInfo rii in riis) {
                    if (rii.IndexName.Equals( rsp.Parameter, StringComparison.CurrentCultureIgnoreCase)) {

                        double rangeMin = (rsp.ScoreMin < rii.MinMax.Key) ? rii.MinMax.Key : rsp.ScoreMin;
                        double rangeMax = (rsp.ScoreMax > rii.MinMax.Value) ? rii.MinMax.Value : rsp.ScoreMax;

                        coverage = (rangeMax - rangeMin) / (rii.MinMax.Value - rii.MinMax.Key);

                        break;
                    }
                }
            }
            

            return coverage;
        }


    }
}
