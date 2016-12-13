using System;
using System.Data;
using System.Configuration;

//--------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel {

    /// <summary>
    ///     Best to define these as an enum to prevent typos.!
    ///     Note that SecureUser and ProfessionalUser are akin to DataAdmin - not really used in the SGBV or IDPGrievances systems ...
    ///     But the SecureUser and Professional users are useful in order to provide three administrative levels (plus UserAdmin)
    /// </summary>
    public enum MGGroupType
    {
        Guest, User, DataEntry, Admin, UserAdmin, SecureUser, ProfessionalUser, DataAdmin // DataAdmin is legacy and is replaced by SecureUser and ProfessionalUser for flexibility ...
    }

    //----------------------------------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    /// Summary description for Group
    /// </summary>
    ///
    public class MGGroup {

        public static readonly int NO_GROUP_GROUP_ID = -1;

        public static readonly string NO_GROUP_GROUP_NAME = "NO_GROUP";

        public static MGGroup NO_GROUP = new MGGroup(NO_GROUP_GROUP_ID, NO_GROUP_GROUP_NAME);

        private int id;
        private string name = null;
        private string description = null;
        private bool isDefault = false;
        private bool canEditData = false;
        private bool canEditUsers = false;

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------

        public MGGroup()
        {
        }

        public MGGroup( string groupName ) {
            name = groupName;
        }

        /// <summary>
        /// Group type is converted to "name"
        /// </summary>
        /// <param name="groupType"></param>
        public MGGroup(MGGroupType _groupType)
        {
            name = _groupType.ToString();
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public MGGroup(MGGroupType _groupType, bool allowDataEdit, bool allowUserEdit)
        {
            name = _groupType.ToString();
            canEditData = allowDataEdit;
            canEditUsers = allowUserEdit;
        }

        public MGGroup(int groupID, string groupName)
        {
            id = groupID;
            name = groupName;
            canEditData = false;
            canEditUsers = false;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public MGGroup(int groupID, string groupName, bool allowDataEdit, bool allowUserEdit) {
            id = groupID;
            name = groupName;
            canEditData = allowDataEdit;
            canEditUsers = allowUserEdit;
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public int ID {
            get { return id; }
            set { id = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string Name {
            get { return name; }
            set { name = value; }
        }

        public string Description
        {
            get { return description; }
            set { description = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public bool CanEditData {
            get { return canEditData; }
            set { canEditData = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        public bool CanEditUsers {
            get { return canEditUsers; }
            set { canEditUsers = value; }
        }


        public bool IsDefault
        {
            get { return isDefault; }
            set { isDefault = value; }
        }


        /// <summary>
        /// This compare two group objects.
        /// It does it be comparing the ID of both groups.
        /// </summary>
        /// <param name="obj"></param>
        /// <returns></returns>
        public override bool Equals(object obj)
        {
            if(obj is MGGroup)
                return (this.ID == (obj as MGGroup).ID);
            else
                return base.Equals(obj);
        }

    }
}