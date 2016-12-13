using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//-----------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace MGL.DomainModel {
    //--------------------------------------------------------------------------------------------------------------------------------------------------------------
    public static class DateTimeNull {
        //-----------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     This needs to be in the domain model so that we can declare date properties in classes to be initially null...
        ///     See also MGL.DataUtilities.DateTimeInformation
        /// </summary>
        public static readonly DateTime NullDate = new DateTime(1, 1, 1, 1, 1, 1);
    }
}
