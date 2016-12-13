using System;
using System.Collections.Generic;
using System.Text;
using System.Reflection;

//-----------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel {

    //--------------------------------------------------------------------------------------------------------------------------------------------------------------
    public class DataListInfo {

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        public DataListInfo() {
            ResetInfo(null);
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        public DataListInfo(string keyName) {
            ResetInfo(keyName);
        }
        public void ResetInfo( string keyName ) {
            key = keyName;
            results = null;
            SortState = ListSortState.Default();
            PageState = ListPageState.Default();
            srcImgPath = "";
            totalNumberItemsAttempted = 0;
            //            addressList = null;
//            detailsURL = null;
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>Checks that the keys of the two are equivalent</summary>
        public bool Equals(DataListInfo otherList) {
            bool isEqual = false;
            if (otherList != null) {
                isEqual = Equals(otherList.Key);
            }
            return isEqual;
        }
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>Checks that the keys of the two are equivalent</summary>
        public bool Equals(string otherKey) {
            bool isEqual = false;
            if (key != null && otherKey != null) {
                if (key.ToLower().Equals(otherKey.ToLower())) {
                    isEqual = true;
                }
            }
            return isEqual;
        }


        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        private string key;
        public string Key {
            get { return key; }
            set { key = value; }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        private List<MGL.DomainModel.MGLSimpleContent> results;
        public List<MGL.DomainModel.MGLSimpleContent> Results {
            get { return results; }
            set {
                results = null;
                List<MGL.DomainModel.MGLSimpleContent> temp = value;
                if (temp != null) {
                    results = new List<MGLSimpleContent>();
                    results.AddRange(temp);
                }
            }
        }


        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        private int totalNumberItemsAttempted = 0;
        public int TotalNumberItemsAttempted {
            get { return totalNumberItemsAttempted; }
            set { totalNumberItemsAttempted = value; }
        }


        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
//        private ListSortState sortState;
        public ListSortState SortState;
//            get { return SortState; }
//            set { SortState = value; }
//        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
//        private ListPageState pageState;
        public ListPageState PageState;
//            get { return pageState; }
//            set { pageState = value; }
//        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        private string srcImgPath;
        public string SrcImgPath {
            get { return srcImgPath; }
            set { srcImgPath = value; }
        }

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        //private string detailsURL;
        //public string DetailsURL {
        //    get { return detailsURL; }
        //    set { detailsURL = value; }
        //}

        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>Uses reflection to clone all of the exposed attributes of the load configuration class</summary>
        public DataListInfo Clone() {
            try {
                Type type = this.GetType();
                object clone = Activator.CreateInstance(type); // Throws an exception if a global that shouldnt be null is null (e.g. a struct)

                PropertyInfo[] typeProperties = type.GetProperties();

                object sourceVal = null;
                object targetVal = null;

                foreach (PropertyInfo propInfo in typeProperties) {
                    string propName = propInfo.Name;
                    sourceVal = propInfo.GetValue(this, null);

                    if (sourceVal != null) {
                        targetVal = sourceVal;
                        propInfo.SetValue(clone, targetVal, null);
                    }
                }

                MemberInfo[] typeMems = type.GetMembers();
                foreach (MemberInfo memInfo in typeMems) {

                }

                return (DataListInfo)clone;
            } catch {
                // We need to put a logger in here to be sure we are not missing anything ....
                //Logger.LogError("DataListInfo - Clone error: " + ex.ToString());
            }
            return null;
        }
    }
}
