using System;
using System.Collections.Generic;
using System.Text;

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel {
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public struct MGLSimpleLongContent {

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private long num;
        public long Num {
            get { return num; }
            set { num = value; }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private int id;
        public int ID {
            get { return id; }
            set { id = value; }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public MGLSimpleLongContent(int id, long num) {
            this.id = id;
            this.num = num;
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static IComparer<MGLSimpleLongContent> Sort(MGL.DomainModel.ListSortState sortState) {
            if (sortState.SortedByFieldName.ToLower().Equals("num")) {
                return new SortNum(sortState.IsSortedAsc);
            } else if (sortState.SortedByFieldName.ToLower().Equals("id")) {
                return new SortID(sortState.IsSortedAsc);
            }
            return null;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private class SortNum : IComparer<MGLSimpleLongContent> {
            private bool IsAscending = true;
            public SortNum(bool isAscending) {
                IsAscending = isAscending;
            }
            int IComparer<MGL.DomainModel.MGLSimpleLongContent>.Compare(
                MGL.DomainModel.MGLSimpleLongContent a, MGL.DomainModel.MGLSimpleLongContent b) {
                if (IsAscending) {
                    return (a.Num.CompareTo(b.Num));
                } else {
                    return (b.Num.CompareTo(a.Num));
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private class SortID : IComparer<MGLSimpleLongContent> {
            private bool IsAscending = true;
            public SortID(bool isAscending) {
                IsAscending = isAscending;
            }
            int IComparer<MGL.DomainModel.MGLSimpleLongContent>.Compare(
                MGL.DomainModel.MGLSimpleLongContent a, MGL.DomainModel.MGLSimpleLongContent b) {
                if (IsAscending) {
                    return (a.ID.CompareTo(b.ID));
                } else {
                    return (b.ID.CompareTo(a.ID));
                }
            }
        }


    }
}
