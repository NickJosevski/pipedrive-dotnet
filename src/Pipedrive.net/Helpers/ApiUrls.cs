﻿using System;

namespace Pipedrive
{
    /// <summary>
    /// Class for retrieving Pipedrive API URLs
    /// </summary>
    public static class ApiUrls
    {
        static readonly Uri _currenciesUrl = new Uri("currencies", UriKind.Relative);

        static readonly Uri _activityFieldsUrl = new Uri("activityFields", UriKind.Relative);

        static readonly Uri _activityTypesUrl = new Uri("activityTypes", UriKind.Relative);

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the currencies in response to a GET request.
        /// </summary>
        /// <returns></returns>
        public static Uri Currencies()
        {
            return _currenciesUrl;
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the activity fields in response to a GET request.
        /// </summary>
        /// <returns></returns>
        public static Uri ActivityFields()
        {
            return _activityFieldsUrl;
        }

        /// <summary>
        /// Returns the <see cref="Uri"/> that returns all of the activity types in response to a GET request.
        /// </summary>
        /// <returns></returns>
        public static Uri ActivityTypes()
        {
            return _activityTypesUrl;
        }
    }
}
