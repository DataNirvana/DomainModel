using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNirvana.DomainModel.Database {
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------
    /// <summary>
    /// 
    /// </summary>
    public enum SearchType {
        PrimaryKey = 0,
        Text = 1,
        Score = 2, // Numeric       
        DateTime = 3,
        /// <summary>
        ///     WARNING - this is slow!!!
        /// </summary>
        Bool = 4
    }
}
