using System;
using System.Collections.Generic;
using System.Text;

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel {
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public struct MGLSimpleContent {

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private int id;
        public int ID {
            get { return id; }
            set { id = value; }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public MGLSimpleContent(int id, string name) {
            this.id = id;
            this.name = name;
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public bool Equals(MGLSimpleContent otherSC) {
            bool areEqual = false;
            if (this.id == otherSC.id) {
                if (this.name != null && otherSC.name != null && this.name.Equals(otherSC.name, StringComparison.CurrentCultureIgnoreCase)) {
                    areEqual = true;
                }
            }
            return areEqual;
        }



        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static IComparer<MGLSimpleContent> Sort(MGL.DomainModel.ListSortState sortState) {
            if (sortState.SortedByFieldName.ToLower().Equals("name")) {
                return new SortName(sortState.IsSortedAsc);
            } else if (sortState.SortedByFieldName.ToLower().Equals("id")) {
                return new SortID(sortState.IsSortedAsc);
            }
            return null;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private class SortName : IComparer<MGLSimpleContent> {
            private bool IsAscending = true;
            public SortName(bool isAscending) {
                IsAscending = isAscending;
            }
            int IComparer<MGL.DomainModel.MGLSimpleContent>.Compare(
                MGL.DomainModel.MGLSimpleContent a, MGL.DomainModel.MGLSimpleContent b) {
                if (IsAscending) {
                    return (a.Name.CompareTo(b.Name));
                } else {
                    return (b.Name.CompareTo(a.Name));
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private class SortID : IComparer<MGLSimpleContent> {
            private bool IsAscending = true;
            public SortID(bool isAscending) {
                IsAscending = isAscending;
            }
            int IComparer<MGL.DomainModel.MGLSimpleContent>.Compare(
                MGL.DomainModel.MGLSimpleContent a, MGL.DomainModel.MGLSimpleContent b) {
                if (IsAscending) {
                    return (a.ID.CompareTo(b.ID));
                } else {
                    return (b.ID.CompareTo(a.ID));
                }
            }
        }


    }
}
