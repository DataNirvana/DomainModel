using System;
using System.Collections.Generic;

//---------------------------------------------------------------------------------------------------------------------------------------------------------------------
namespace DataNirvana.DomainModel.Database {

    //------------------------------------------------------------------------------------------------------------------------------------------------------------------
    public class DatabaseSearchPattern {

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        public SearchType SearchType;

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        public SearchComparisonExpression SearchComparisonExpression;

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string Parameter;

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string Pattern;
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Returns the first n chars in lower case of the pattern stored in this SeachPattern ...
        /// </summary>
        /// <param name="fetFirstNChars">The maximum number of characters to return</param>
        /// <returns></returns>
        public string PatternStartsWith( int firstNChars ) {
                if (SearchType == SearchType.Text) {
                    return Pattern.Substring(0, firstNChars).ToLower();
                } else {
                    // Expand out the score to remove the scientific notation
                    return ScoreMin.ToString("0." + new string('#', 339));
                }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string PatternMin {
            get {
                if (SearchType == SearchType.Text) {
                    return Pattern;
                } else {
                    // Expand out the score to remove the scientific notation
                    return ScoreMin.ToString("0." + new string('#', 339));                    
                }
            }
        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        public string PatternMax {
            get {
                if (SearchType == SearchType.Text) {
                    // a little bit more complicated because of how this is being used!!
                    return GetPatternMax(Pattern);
                } else {
                    // Expand out the score to remove the scientific notation
                    return ScoreMax.ToString("0." + new string('#', 339));
                }
            }

        }
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        public long Score = 0;

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        public double ScoreMin;
        //public string ScoreMinStr {
        //    get { return ScoreMin.ToString("0." + new string('#', 339)); }
        //}
        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        public double ScoreMax;
        //public string ScoreMaxStr {
        //    get { return ScoreMax.ToString("0." + new string('#', 339)); }
        //}

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Sets up a search for a specific score
        /// </summary>
        public DatabaseSearchPattern(string parameter, double score) {
            SearchType = SearchType.Score;
            SearchComparisonExpression = SearchComparisonExpression.Equivalent;

            Parameter = parameter;

            ScoreMin = ScoreMax = score;
        }


        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Sets up a search for a primary key - always ID!!
        /// </summary>
        public DatabaseSearchPattern(long primaryKey) {
            SearchType = SearchType.PrimaryKey;
            SearchComparisonExpression = SearchComparisonExpression.Equivalent;

            Parameter = "ID";

            Score = primaryKey;
        }


        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Sets up a search for a score range
        /// </summary>
        public DatabaseSearchPattern(string parameter, double minScore, double maxScore) {
            SearchType = SearchType.Score;
            SearchComparisonExpression = SearchComparisonExpression.RangeBetween;

            Parameter = parameter;

            ScoreMin = minScore;
            ScoreMax = maxScore;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Sets up a search for a score range
        ///     Note - not yet sure we can implement canBeEqual!!! - always inclusive I think
        /// </summary>
        public DatabaseSearchPattern(string parameter, double score, bool isGreaterThan) {
            SearchType = SearchType.Score;
            Parameter = parameter;

            if ( isGreaterThan == true) {
                ScoreMin = score;
                ScoreMax = double.MaxValue;
                SearchComparisonExpression = SearchComparisonExpression.RangeGreaterThanOrEqualTo;
            } else {
                ScoreMin = double.MinValue;
                ScoreMax = score;
                SearchComparisonExpression = SearchComparisonExpression.RangeLessThanOrEqualTo;
            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Sets up a search for a specific bool
        /// </summary>
        public DatabaseSearchPattern(string parameter, bool searchBool) {
            SearchType = SearchType.Bool;
            SearchComparisonExpression = SearchComparisonExpression.Bool;
            Parameter = parameter;
            Score = (searchBool == true) ? 1 : 0;
            ScoreMin = ScoreMax = Score;
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Sets up a search for a specific DateTime
        /// </summary>
        public DatabaseSearchPattern(string parameter, DateTime dt) {
            SearchType = SearchType.DateTime;
            Parameter = parameter;
            
//            ScoreMin = RedisSearchPattern.StandardiseDate(dt).Ticks;
            // Even for equivalence searches, note that we want the searches to be inclusive .... - so here, lets 23 59 59 to the date to be sure...
//            if (RedisWrapper.DateTimeAccuracy.Equals("day", StringComparison.CurrentCultureIgnoreCase)) {
//                SearchComparisonExpression = DNSearchComparisonExpression.RangeBetween;
//                ScoreMax = RedisSearchPattern.StandardiseDate(dt).Add(new TimeSpan(23, 59, 59)).Ticks;
//            } else {
                SearchComparisonExpression = SearchComparisonExpression.Equivalent;
            //                Score = RedisSearchPattern.StandardiseDate(dt).Ticks;
            //ScoreMax = ScoreMin;
            //            }
            Score = dt.Ticks;
            ScoreMin = ScoreMax = Score;   

        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Sets up a search for a DateTime range
        /// </summary>
        public DatabaseSearchPattern(string parameter, DateTime dtStart, DateTime dtEnd) {
            SearchType = SearchType.DateTime;
            SearchComparisonExpression = SearchComparisonExpression.RangeBetween;

            Parameter = parameter;

            ScoreMin = dtStart.Ticks;
            ScoreMax = dtEnd.Ticks;

            // Note that we want the searches to be inclusive .... - so here, lets 23 59 59 to the date to be sure...
            //ScoreMin = RedisSearchPattern.StandardiseDate(dtStart).Ticks;
            //ScoreMax = RedisSearchPattern.StandardiseDate(dtEnd).Ticks;
            //if ( RedisWrapper.DateTimeAccuracy.Equals("day", StringComparison.CurrentCultureIgnoreCase)) {
//                ScoreMax = RedisSearchPattern.StandardiseDate(dtEnd).Add(new TimeSpan(23, 59, 59)).Ticks;
//            }
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Sets up a search for a DateTime range
        /// </summary>
        public DatabaseSearchPattern(string parameter, DateTime dt, bool isGreaterThan) {
            SearchType = SearchType.DateTime;
            Parameter = parameter;
            if ( isGreaterThan == true) {
                SearchComparisonExpression = SearchComparisonExpression.RangeGreaterThanOrEqualTo;
                //ScoreMin = RedisSearchPattern.StandardiseDate(dt).Ticks;
                ScoreMin = dt.Ticks;
                ScoreMax = DateTime.MaxValue.Ticks;
            } else {
                SearchComparisonExpression = SearchComparisonExpression.RangeLessThanOrEqualTo;
                // Note that we want the searches to be inclusive .... - so here, lets 23 59 59 to the date to be sure...
                ScoreMin = DateTime.MinValue.Ticks;
                //ScoreMax = RedisSearchPattern.StandardiseDate(dt).Ticks;
                ScoreMax = dt.Ticks;
                //if (RedisWrapper.DateTimeAccuracy.Equals("day", StringComparison.CurrentCultureIgnoreCase)) {
                //    ScoreMax = RedisSearchPattern.StandardiseDate(dt).Add(new TimeSpan(23, 59, 59)).Ticks;
                //}
            }
        }


        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Sets up a lexical search
        /// </summary>
        public DatabaseSearchPattern(string parameter, string textPattern) {
            SearchType = SearchType.Text;
            SearchComparisonExpression = SearchComparisonExpression.StartsWith;
            Parameter = parameter;
            Pattern = textPattern;
        }


        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Gets a textual representation of the pattern
        public string AsText() {
            string txt = Parameter + " -> " + SearchType.ToString() + " - "+ SearchComparisonExpression.ToString() +" -> ";
            if (SearchType == SearchType.Text) {
                txt = txt + PatternMin;
            } else if (SearchType == SearchType.PrimaryKey) {
                txt = txt + Score;
            } else if (SearchType == SearchType.Bool) {
                txt = txt + Score;
            } else if (SearchType == SearchType.DateTime) {
                //if (ScoreMin != DateTime.MinValue.Ticks) {
                    if (SearchComparisonExpression == SearchComparisonExpression.RangeGreaterThanOrEqualTo
                        || SearchComparisonExpression == SearchComparisonExpression.RangeBetween
                        || SearchComparisonExpression == SearchComparisonExpression.Equivalent) {

                        string desc = (SearchComparisonExpression == SearchComparisonExpression.RangeGreaterThanOrEqualTo
                            || SearchComparisonExpression == SearchComparisonExpression.RangeBetween ) ? ">=Min" : "==";
                    //txt = txt + " " + desc + " " + DateTimeInformation.FormatDatabaseDate(new DateTime((long)Math.Round(ScoreMin))., true, true);
                    DateTime dt = new DateTime((long)Math.Round(ScoreMin));
                    txt = txt + " " + desc + " " + dt.Year + "-" + dt.Month + "-" + dt.Date + " " + dt.Hour + ":" + dt.Minute + ":" + dt.Second;
                }
                    if (SearchComparisonExpression == SearchComparisonExpression.RangeLessThanOrEqualTo
                            || SearchComparisonExpression == SearchComparisonExpression.RangeBetween) {
                    //if (ScoreMin != ScoreMax && ScoreMax != DateTime.MaxValue.Ticks) {
                    DateTime dt = new DateTime((long)Math.Round(ScoreMax));
                    txt = txt + " <=Max " + dt.Year + "-" + dt.Month + "-" + dt.Date + " " + dt.Hour + ":" + dt.Minute + ":" + dt.Second;
                    }
                
            } else {
                // it is a score, so lets print the range we are searching for ...
                if (SearchComparisonExpression == SearchComparisonExpression.Equivalent) {
                    txt = txt + " == " + Score;
                } else if (SearchComparisonExpression == SearchComparisonExpression.RangeGreaterThanOrEqualTo) {
                    txt = txt + ScoreMin + " to Max";
                } else if (SearchComparisonExpression == SearchComparisonExpression.RangeLessThanOrEqualTo) {
                    txt = txt + "Min to " + ScoreMax;
                } else if (SearchComparisonExpression == SearchComparisonExpression.RangeBetween) {
                    txt = txt + ScoreMin + " to " + ScoreMax;
                }
            }
                return txt;
        }



        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Gets the list of ticks representing the sets for each day ....
        /// </summary>
        /// <returns></returns>
        /// 
        /*
        public List<long> GetTickList() {
            List<long> ticks = new List<long>();

            if ( SearchType == DNSearchType.DateTime) {

                //                if (ScoreMin == ScoreMax) {                                         // an exact date and time

                if (SearchComparisonExpression == DNSearchComparisonExpression.Equivalent) {

                    ticks.Add(Score);

                } else {
                    long start = 0;
                    long end = 0;

                    //if (ScoreMin == DateTime.MinValue.Ticks) {           // less than or equal to ...
                    if ( SearchComparisonExpression == DNSearchComparisonExpression.RangeLessThanOrEqualTo) { 
                        start = RedisWrapper.DateMin.Ticks;
                        end = (long) ScoreMax;

                    } else if (SearchComparisonExpression == DNSearchComparisonExpression.RangeGreaterThanOrEqualTo) {
                        //ScoreMax == DateTime.MaxValue.Ticks) {           // greater than or equal to ...
                        start = (long)ScoreMin;
                        end = RedisWrapper.DateMax.Ticks;

                    } else if (SearchComparisonExpression == DNSearchComparisonExpression.RangeBetween) {
                    //} else {                                                                            // Must be a real between
                        start = (long)ScoreMin;
                        end = (long)ScoreMax;
                    } else {
                        string ohFuck = "";
                    }

                    /////////////////////////////////////
                    //string txt = AsText();

                    // Ooops - this was previously < - we want to include the end date as well to make this inclusive ...
                    // Perhaps it is in fact better to be <!! Now that the dates we have ensured that the end date is 23 59 59
                    DateTime stanEnd = StandardiseDateToStartOfDay(new DateTime(end));
                    while (start <= stanEnd.Ticks) {
                        ticks.Add(start);                       
                        start = new DateTime(start).AddDays(1).Ticks; // (new TimeSpan(1,23,59,59));
                    }
                    // special case is if the start and end are equivalent ...
                    if ( ticks.Count == 0) {
                        ticks.Add(start);
                    }
                }
            }

            return ticks;
        }
        */

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Recalculates the next character
        ///     Note that this _has_ to be done in this way due to the way Redis works - to search for the db equivalent of "f*" we need to search between f and g
        ///     So this method calculates the next char.
        ///     Note that in UTF-8 after z is { and after Z is [ .... but if we uppercase z without recalculating the max character, we end up with the entire lowercase range - doh!!
        ///     
        ///     We should override or parameterise this for e.g. MySQL database usage too
        /// </summary>
        /// <param name="newPattern"></param>
        /// <returns></returns>
        public string GetPatternMax(string newPattern) {           
            // This option works in the cmd interface, but not through StackExchange.Redis ....
            // we need to append the last known utf-8 character to the end of the pattern to create the range ....
            // See http://www.utf8-chartable.de/unicode-utf8-table.pl?start=0&number=1024&names=-&utf8=string-literal
            // RedisValue[] rvs = rDB.SortedSetRangeByValue(setName, "Another O", "Another O\xf4\x8f\xbf\xbe");
            //return Pattern + "\xf4\x8f\xbf\xbe";

            //-----2----- This option works!
            // http://stackoverflow.com/questions/1026220/how-to-find-out-next-character-alphabetically
            // just increment the last character in the pattern....
            char nextChar = (char)((int)newPattern[newPattern.Length - 1] + 1);
            return newPattern.Substring(0, newPattern.Length - 1) + nextChar.ToString();
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     What is an Opposite in this context I hear you say???!!!!
        ///     So here we want to mimic a database and make this search case independent....But Redis is not a fucking database - the text searches are binary implementations
        ///     Note that the string comparisons are conducted as a binary array of bytes(http://redis.io/commands/zrangebylex and https://en.wikipedia.org/wiki/UTF-8).  
        ///     This means that the first character has the most importance.  Note also that uppercase letters precede lower case letters
        ///     So here we want to do both upper and lower case searches (obvs for nums and chars this is not needed!)
        ///     Also, to mimic the* wildcard we need to search up until the next character(e.g. >= a and < b)... there are of course some wiggly special cases here
        ///     To get all z's you need to search until { and to get all Z's you need to search until[, because these chars are ordered as UTF - 8(see http://www.fileformat.info/info/charset/UTF-8/list.htm )
        /// </summary>
        /// <param name="oppMin"></param>
        /// <param name="oppMax"></param>
        /// <returns>
        ///     Whether or not we need to run an additional search with the opposite capitalisation (e.g. for alpha chars we probably will, for numbers and special chars, we probably wont need to.
        /// </returns>
        public bool GetOppositeCaseMaxAndMin(out string oppMin, out string oppMax) {
            bool worthRunning = false;

            oppMin = oppMax = null;

            // only worth doing this if this is a Text pattern and the pattern is not null!
            if (SearchType == SearchType.Text && Pattern != null) {

                // So if the lowercase or uppercase versions of our text is different, then lets change it here...
                if (Pattern.Equals(Pattern.ToLower()) == false) {
                    oppMin = Pattern.ToLower();
                    oppMax = GetPatternMax(oppMin);
                    worthRunning = true;

                } else if (Pattern.Equals(Pattern.ToUpper()) == false) {
                    oppMin = Pattern.ToUpper();
                    oppMax = GetPatternMax(oppMin);
                    worthRunning = true;
                }

            }

            return worthRunning;
        }



        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Truncates the date as required ...
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static DateTime StandardiseDateToStartOfDay( DateTime input) {
            return new DateTime(input.Year, input.Month, input.Day, 0, 0, 0);
        }

        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        /// <summary>
        ///     Truncates the date as to the nearest second (inclusive) ...
        /// </summary>
        /// <param name="input"></param>
        /// <returns></returns>
        public static DateTime StandardiseDateToStartOfSecond(DateTime input, bool roundUp) {
            int seconds = (roundUp == true) ? input.Second + 1 : input.Second;
            return new DateTime(input.Year, input.Month, input.Day, input.Hour, input.Minute, input.Second);
        }


        //---------------------------------------------------------------------------------------------------------------------------------------------------------------
        // Ok lets build the search here .... ONLY sorts by priority at the moment....
        public static IComparer<DatabaseSearchPattern> Sort(List<DatabaseIndexInfo> riis) {
//            if (sortField.Equals("Duration", StringComparison.CurrentCultureIgnoreCase)) {
                return new SortByLikelyFastestQuery(riis);
//            }
//            return null;
        }

        //--------------------------------------------------------------------------------------------------------------------------------------------------------------
        private class SortByLikelyFastestQuery : IComparer<DatabaseSearchPattern> {
            private List<DatabaseIndexInfo> riis = null;
            public SortByLikelyFastestQuery(List<DatabaseIndexInfo> riis) {
                this.riis = riis;
//                IsAscending = isAscending;
            }

            int IComparer<DatabaseSearchPattern>.Compare(DatabaseSearchPattern a, DatabaseSearchPattern b) {
                //                if (IsAscending) {

                // Equivalent, Between, GreaterThan, StartsWith ...
                int comparison = a.SearchComparisonExpression.CompareTo(b.SearchComparisonExpression);
                //if (comparison == 0 || a.SearchType == DNSearchType.Bool || b.SearchType == DNSearchType.Bool) {
                if (comparison == 0) {

                    // So lets compare DateTimes and Score search patterns in terms of their coverage ...
                    if (a.SearchComparisonExpression == SearchComparisonExpression.RangeBetween
                        || a.SearchComparisonExpression == SearchComparisonExpression.RangeGreaterThanOrEqualTo
                        || a.SearchComparisonExpression == SearchComparisonExpression.RangeLessThanOrEqualTo) {
                        // so we want to calculate the proportions of the spread between max and min

                            comparison = DatabaseIndexInfo.GetCoverage(riis, a).CompareTo(DatabaseIndexInfo.GetCoverage(riis, b));

                    } else {

                        // PrimaryKey, Score, Text, Bool ...
                        comparison = a.SearchType.CompareTo(b.SearchType);

                    }

                    //if (comparison == 0) {

                    //        //                            double rangeA = a.ScoreMax - a.ScoreMin;
                    //        //                            double rangeB = b.ScoreMax - b.ScoreMin;
                    //        //                            comparison = rangeA.CompareTo(rangeB);
                            
                    //    } else if (a.SearchComparisonExpression == DNSearchComparisonExpression.Equivalent) {
                    //        comparison = a.Score.CompareTo(b.Score);
                    //    }
                    //}
                }

                return comparison;
//                    return (a.Duration.CompareTo(b.Duration));
//                } else {
//                    return (b.Duration.CompareTo(a.Duration));
//                }
            }
        }




    }
}
