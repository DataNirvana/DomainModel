using System;
using System.Collections.Generic;
using System.Text;

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel {
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public struct MGLSimpleStringContent {
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string myValue;
        public string Value {
            get { return myValue; }
            set { myValue = value; }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public MGLSimpleStringContent(string name, string value) {
            this.name = name;
            this.myValue = value;
        }
        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public MGLSimpleStringContent(string value) {
            this.name = value;
            this.myValue = value;
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static List<string> GetList(List<MGLSimpleStringContent> data, bool getNames) {
            List<string> cols = null;

            if (data != null) {
                cols = new List<string>();

                if (getNames) {
                    foreach (MGLSimpleStringContent ssc in data) {
                        cols.Add(ssc.Name);
                    }
                } else {
                    foreach (MGLSimpleStringContent ssc in data) {
                        cols.Add(ssc.Value);
                    }
                }
            }

            return cols;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static IComparer<MGLSimpleStringContent> Sort(MGL.DomainModel.ListSortState sortState) {
            if (sortState.SortedByFieldName.ToLower().Equals("name")) {
                return new SortName(sortState.IsSortedAsc);
            } else if (sortState.SortedByFieldName.ToLower().Equals("value")) {
                return new SortValue(sortState.IsSortedAsc);
            }
            return null;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private class SortName : IComparer<MGLSimpleStringContent> {
            private bool IsAscending = true;
            public SortName(bool isAscending) {
                IsAscending = isAscending;
            }
            int IComparer<MGL.DomainModel.MGLSimpleStringContent>.Compare(
                MGL.DomainModel.MGLSimpleStringContent a, MGL.DomainModel.MGLSimpleStringContent b) {
                if (IsAscending) {
                    return (a.Name.CompareTo(b.Name));
                } else {
                    return (b.Name.CompareTo(a.Name));
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private class SortValue : IComparer<MGLSimpleStringContent> {
            private bool IsAscending = true;
            public SortValue(bool isAscending) {
                IsAscending = isAscending;
            }
            int IComparer<MGL.DomainModel.MGLSimpleStringContent>.Compare(
                MGL.DomainModel.MGLSimpleStringContent a, MGL.DomainModel.MGLSimpleStringContent b) {
                if (IsAscending) {
                    return (a.Value.CompareTo(b.Value));
                } else {
                    return (b.Value.CompareTo(a.Value));
                }
            }
        }


    }
}
