using System;
using System.Collections.Generic;
using System.Text;

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel {
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public struct MGSimpleDoubleContent {

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private double val;
        public double Value {
            get { return val; }
            set { val = value; }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private int id;
        public int ID {
            get { return id; }
            set { id = value; }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public MGSimpleDoubleContent(int id, double val) {
            this.id = id;
            this.val = val;
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static IComparer<MGSimpleDoubleContent> Sort(MGL.DomainModel.ListSortState sortState) {
            if (sortState.SortedByFieldName.ToLower().Equals("value")) {
                return new SortValue(sortState.IsSortedAsc);
            } else if (sortState.SortedByFieldName.ToLower().Equals("id")) {
                return new SortID(sortState.IsSortedAsc);
            }
            return null;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private class SortValue : IComparer<MGSimpleDoubleContent> {
            private bool IsAscending = true;
            public SortValue(bool isAscending) {
                IsAscending = isAscending;
            }
            int IComparer<MGL.DomainModel.MGSimpleDoubleContent>.Compare(
                MGL.DomainModel.MGSimpleDoubleContent a, MGL.DomainModel.MGSimpleDoubleContent b) {
                if (IsAscending) {
                    return (a.Value.CompareTo(b.Value));
                } else {
                    return (b.Value.CompareTo(a.Value));
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private class SortID : IComparer<MGSimpleDoubleContent> {
            private bool IsAscending = true;
            public SortID(bool isAscending) {
                IsAscending = isAscending;
            }
            int IComparer<MGL.DomainModel.MGSimpleDoubleContent>.Compare(
                MGL.DomainModel.MGSimpleDoubleContent a, MGL.DomainModel.MGSimpleDoubleContent b) {
                if (IsAscending) {
                    return (a.ID.CompareTo(b.ID));
                } else {
                    return (b.ID.CompareTo(a.ID));
                }
            }
        }


    }
}
