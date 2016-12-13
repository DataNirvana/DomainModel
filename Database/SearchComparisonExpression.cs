using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataNirvana.DomainModel.Database {
    //------------------------------------------------------------------------------------------------------------------------------------------------------------------
    // and another one to make the ranges absolutely explicit????????????????????
    /// <summary>
    /// 
    /// </summary>
    public enum SearchComparisonExpression {
        Equivalent = 0,
        StartsWith = 1,
        RangeBetween = 2,
        RangeGreaterThanOrEqualTo = 3,
        RangeLessThanOrEqualTo = 4,

        /// <summary>
        ///     WARNING - this is slow!!!
        /// </summary>
        Bool = 5
    }
}
