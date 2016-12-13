using System;
using System.Collections.Generic;
using System.Text;
using System.Configuration;
using System.Security;

namespace MGL.DomainModel {

    //--------------------------------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    ///     Class models a User of the system.
    ///     12-Oct-2015 - refactored to use the SecureString class
    ///     1-Nov-2016 - Added the organisation id
    /// </summary>
    public class MGUser {


        #region Properties

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private int id;
        public int ID {
            get { return id; }
            set { id = value; }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private SecureString username;
        public SecureString Username {
            get { return username; }
            set { username = value; }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private SecureString password;
        public SecureString Password {
            get { return password; }
            set { password = value; }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private SecureString firstName;
        public SecureString FirstName {
            get { return firstName; }
            set { firstName = value; }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private SecureString lastName;
        public SecureString LastName {
            get { return lastName; }
            set { lastName = value; }
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private DateTime startDate;
        public DateTime StartDate {
            get { return startDate; }
            set { startDate = value; }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private DateTime lastLogin;
        public DateTime LastLogin {
            get { return lastLogin; }
            set { lastLogin = value; }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string lastIP;
        public string LastIP {
            get { return lastIP; }
            set { lastIP = value; }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string lastBrowser;
        public string LastBrowser {
            get { return lastBrowser; }
            set { lastBrowser = value; }
        }

        //private UserTypeEnum userType;

        //public UserTypeEnum UserType
        //{
        //    get { return userType; }
        //    set { userType = value; }
        //}

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //public bool IsGuest
        //{
        //    get
        //    {
        //        return (UserType == UserTypeEnum.guest);
        //    }
        //}

        //public bool IsAdmin
        //{
        //    get
        //    {
        //        return (UserType == UserTypeEnum.admin);
        //    }
        //}

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private SecureString email;
        public SecureString Email {
            get { return email; }
            set { email = value; }
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private int organisationID;
        public int OrganisationID {
            get { return organisationID; }
            set { organisationID = value; }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private SecureString organisation;
        public SecureString Organisation {
            get { return organisation; }
            set { organisation = value; }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private SecureString jobTitle;
        public SecureString JobTitle {
            get { return jobTitle; }
            set { jobTitle = value; }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private SecureString telephone;
        public SecureString Telephone {
            get { return telephone; }
            set { telephone = value; }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private int totalLogins;
        public int TotalLogins {
            get { return totalLogins; }
            set { totalLogins = value; }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private string description;
        public string Description {
            get { return description; }
            set { description = value; }
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private int numIncorrectLogins;
        public int NumIncorrectLogins {
            get { return numIncorrectLogins; }
            set { numIncorrectLogins = value; }
        }


        ////////////////////////////////////////////// Flag this!!

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public bool IsLockedOut {
            get {
                //bool IgnoreIncorrectLogins = false;
                //string IgnoreIncorrectLoginsStr = System.Configuration.ConfigurationSettings.AppSettings["IgnoreIncorrectLogins"] as string;
                //if (IgnoreIncorrectLoginsStr != null) {
                //    Boolean.TryParse(IgnoreIncorrectLoginsStr, out IgnoreIncorrectLogins);
                //}

                if (MGUser.IgnoreIncorrectLogins) {
                    return false;
                } else {
                    return NumIncorrectLogins >= MAX_NUM_FAILED_LOGINS;
                }
            }
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private bool isNew;
        public bool IsNew {
            get { return isNew; }
            set { isNew = value; }
        }


        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private List<int> groups;
        public List<int> Groups {
            get { return groups; }
            set { groups = value; }
        }


        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     24-Nov-2015 - added to support the multiplicity of time zones that can happen with global websites
        ///     This is collected during the login of the user using the javascript getTimezoneOffset function.
        ///     See - http://www.w3schools.com/jsref/jsref_getTimezoneOffset.asp
        ///     Timezone offset from GMT (UTC) in minutes, used to support the display of localised dates and times.
        ///     Note that e.g. GMT + 2 will be -120
        /// </summary>
        private int timezoneOffset = 0;
        public int TimezoneOffset {
            get { return timezoneOffset; }
            set { timezoneOffset = value; }
        }



        #region Constructors

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public MGUser() {
            ID = Int32.MaxValue;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public MGUser(int id) {
            ID = id;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public MGUser(SecureString username, SecureString password) {
            Username = username;
            Password = password;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public MGUser(SecureString username, SecureString email, SecureString password, SecureString jobTitle, SecureString organisation, SecureString telephone) {
            this.ID = Int32.MaxValue;
            this.Username = username;
            this.Email = email;
            this.Password = password;
            this.JobTitle = jobTitle;
            this.Organisation = organisation;
            this.Telephone = telephone;
        }

        /// <summary>
        /// Little utility function to try to parse the userTypeString
        /// and return a userType enum.
        ///
        /// Defaults to "user" if the parse fails
        /// </summary>
        /// <param name="userTypeString"></param>
        /// <returns></returns>
        //public static User.UserTypeEnum GetUserEnum(string userTypeString)
        //{
        //    User.UserTypeEnum UserType = User.UserTypeEnum.user;
        //    try
        //    {
        //        UserType =
        //            (User.UserTypeEnum)
        //                Enum.Parse(typeof(User.UserTypeEnum), userTypeString, true);
        //    }
        //    catch
        //    {
        //    }

        //    return UserType;
        //}

        #endregion

        #endregion

        #region Static Variables

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        //ss: Modified this from 5 as some of the DNF code was calling login more than once
        // for a single login event. This means people were being locked out if they got the pw
        // wrong twice in a row! :S Ideally need to find the source of the double login too!
        public static readonly int MAX_NUM_FAILED_LOGINS = 8;

        //        public static readonly string LOGGED_IN_USER_KEY = "LoggedInUser";

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        public static bool IgnoreIncorrectLogins = false;


        #endregion

    }
}
