﻿using System;

namespace VelocityCoders.FitnessPractice.Models
{
    public static class Extension
    {

        /// <summary>
        /// Attempts to convert string to valid DateTime. If failed, returns DateTime.MinValue.
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static DateTime ToDate(this string s)
        {
            #region CREATED A STATIC EXTENSION | CONVERT DATETIME TO STRING

            DateTime dateTime;

            if (DateTime.TryParse(s, out dateTime))
            {
                return dateTime;
            }
            else
            {
                return new DateTime(1973,1,1);
            }
            #endregion
        }

        /// <summary>
        /// Attempts to convert string to valid int. If failed, returns int value of 0
        /// </summary>
        /// <param name="s"></param>
        /// <returns></returns>
        public static int ToInt(this string s)
        {
            #region EXTENSION ATTEMPTS TO CONVERT INT INTO A STRING
            int intValue = 0;

            if (int.TryParse(s, out intValue))
                return intValue;
            else
                return 0;
            #endregion
        }

    }
}
