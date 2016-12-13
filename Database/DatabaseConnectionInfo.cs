using System;
using System.Collections.Generic;
using System.Linq;
using System.Security;
using System.Text;
using System.Threading.Tasks;

//------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace DataNirvana.DomainModel.Database {
    //---------------------------------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    ///     A simple wrapper class to store the database connection parameters, using secure strings to hold the values
    /// </summary>
    public struct DatabaseConnectionInfo {
        // The location of the database e.g. "localhost"
        public string HOST;
        // The database port (e.g. 3306 for MySQL)
        public int PORT;
        // The type of database e.g. "MySQL"
        public string TYPE;
        // The database name
        public string NAME;

        // The username ...
        public SecureString USER;
        // The password ...
        public SecureString PASSWORD;

        // 24-Aug-15 - late to the SSL party, but good that we are here - add three extra params for the SSL
        /// <summary>
        ///     SSL Required
        /// </summary>
        public bool SSLRequired;

        /// <summary>
        ///     SSL PFX Certificate
        /// </summary>
        public SecureString SSLCertificatePath;

        /// <summary>
        ///     SSL Password - need to quote if it includes ; special characters ...  Most likely not to be included in the context in which the certificates are used
        /// </summary>
        public SecureString SSLCertificatePassword;

        //------------------------------------------------------------------------------------------------------------------------------------------------------------
        public DatabaseConnectionInfo(string host, string type, string name, SecureString user, SecureString password, int port) {
            this.HOST = host;
            this.TYPE = type;
            this.NAME = name;
            this.USER = user;
            this.PASSWORD = password;
            this.PORT = port;

            // 24-Aug-15 - assign the three SSL parameters ...
            this.SSLRequired = false;
            this.SSLCertificatePath = new SecureString();
            this.SSLCertificatePassword = new SecureString();

        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        public DatabaseConnectionInfo(string host, string type, string name, SecureString user, SecureString password, int port,
            bool sslRequired, SecureString sslCertificatePath, SecureString sslCertificatePassword) {

            this.HOST = host;
            this.TYPE = type;
            this.NAME = name;
            this.USER = user;
            this.PASSWORD = password;
            this.PORT = port;

            // 24-Aug-15 - assign the three SSL parameters ...
            this.SSLRequired = sslRequired;
            this.SSLCertificatePath = sslCertificatePath;
            this.SSLCertificatePassword = sslCertificatePassword;

        }


        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        public DatabaseConnectionInfo Clone() {

            return new DatabaseConnectionInfo(
                this.HOST, this.TYPE, this.NAME, this.USER, this.PASSWORD, this.PORT,
                this.SSLRequired, this.SSLCertificatePath, this.SSLCertificatePassword);

        }

    }
}
