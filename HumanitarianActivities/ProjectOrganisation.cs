using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

//------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel.HumanitarianActivities {

    //---------------------------------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    ///     A Simple Organisation for use with e.g. the project information
    ///     The IDs are generated dynamically when the application loads
    ///     The accronym is a key that is ued to pull out the full name from a lookup list
    ///     OrganisationType is GOV, INGO or NGO
    /// </summary>
    public class ProjectOrganisation {

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Default empty constructor
        /// </summary>
        public ProjectOrganisation() {

        }
        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Useful constructor with all the parameters included!
        ///     Accronym e.g. UNHCR
        ///     Name e.g. United Nations ...
        ///     OrgType e.g. UN, Donor, GOV, INGO or NGO
        /// </summary>
        public ProjectOrganisation(
            int id,
            string acronym,
            string name,
            string orgType

            ) {

            this.id = id;
            this.acronym = acronym;
            this.name = name;
            this.orgType = orgType;

        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private int id;
        public int ID {
            get { return id; }
            set { id = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string acronym;
        public string Acronym {
            get { return acronym; }
            set { acronym = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string name;
        public string Name {
            get { return name; }
            set { name = value; }
        }

        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string orgType;
        public string OrgType {
            get { return orgType; }
            set { orgType = value; }
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Compare project organisations based on ONLY the organisation acronym
        ///     Note that we cannot use the ID to determine if the organisations are equivalent
        ///     as they are common between the separate lists of Donors, PMs and IP/OPs
        ///     Therefore the ID in the ProjectOrganisations are irrelevant (for now)!
        /// </summary>
        public bool Equals(ProjectOrganisation po) {
            bool isEqual = false;

            //if (this.ID > 0 && this.ID == po.ID) {
            //    isEqual = true;

            //} else
            if (string.IsNullOrEmpty(this.acronym) == false && string.IsNullOrEmpty(po.acronym) == false
                && this.acronym.Equals( po.acronym) == true ) {

                isEqual = true;
            }

            return isEqual;
        }


        //-------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Compare project organisations based on the ID and / or the organisation accronym
        /// </summary>
        public static ProjectOrganisation Find(List<ProjectOrganisation> poList, int id, string acronym) {
            // Here is the object to return
            ProjectOrganisation po = new ProjectOrganisation();
            // The search tokens
            ProjectOrganisation searchPO = new ProjectOrganisation( id, acronym, null, null );

            if (poList != null) {
                foreach (ProjectOrganisation tempPO in poList) {
                    if ( tempPO.Equals( searchPO ) == true) {
                        po = tempPO;
                        break;
                    }
                }
            }

            return po;
        }

    }
}