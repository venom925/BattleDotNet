﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Dynamic;
using BattleDotNet.Extensions;
using System.Net;

namespace BattleDotNet
{
    public abstract class Client
    {
        // This will help ensure the main constructor is used
        private Client()
        {
        }

        public Client(string baseUrl, Region? region = Region.US, string publicKey = null, string privateKey = null)
        {
            if (baseUrl == null)
                throw new ArgumentNullException("baseUrl");

            // Defaults
            UseHttps = !publicKey.IsNullOrWhiteSpace() && !privateKey.IsNullOrWhiteSpace();

            _baseUrl = NormalizePath(baseUrl);
            _requestManager = new RequestManager(publicKey, privateKey);
        }

        private readonly RequestManager _requestManager;

        private readonly string _baseUrl;
        protected string BaseUrl
        {
            get { return _baseUrl; }
        }

        /// <summary>
        /// Gets or sets a value that indicates if HTTPS should be used.
        /// </summary>
        public bool UseHttps { get; private set; }

        private string NormalizePath(string path)
        {
            return path.TrimEnd('/').TrimStart('/');
        }

        public Region Region { get; private set; }

        protected string GetFieldsString(Enum flagsEnum)
        {
            int flagsValue = Convert.ToInt32(flagsEnum);

            var values =
                Enum.GetValues(flagsEnum.GetType()) // get all possible values
                    .Cast<int>() // we're assuming this enum is of type int
                    .Where(x => x == (flagsValue & x)) // only pull out values in the flags passed in
                    .Except(new[] { 0x0, 0x7FFFFFFF }) // don't include None and All values
                    .Select(x => Enum.GetName(flagsEnum.GetType(), x).ToString()) // ???
                    .ToArray(); // profit!

            return string.Join(",", values).ToLowerInvariant();
        }

        protected T Get<T>(string path = null, IEnumerable<KeyValuePair<string, string>> parameters = null, Region? region = null, Enum fields = null, string fullUrl = null, DateTime? ifModifiedSince = null, Locale? locale = null)
        {
            string url =
                    fullUrl ??
                    string.Format(
                        "{0}://{1}.battle.net/api/{2}/{3}",
                        UseHttps ? "https" : "http",
                        (region ?? this.Region).ToString().ToLowerInvariant(),
                        BaseUrl,
                        path
                    );

            // Fields were passed, need to ensure parameters isn't null since we're going to add to it
            if (parameters == null)
                parameters = new Dictionary<string, string>();

            // Add fields to the parameters
            if (fields != null)
                parameters = parameters.Concat(new Parameters { { "fields", GetFieldsString(fields) } });

            if (locale != null)
                parameters = parameters.Concat(new Parameters { { "locale", locale.ToString() } });

            // Add parameters onto the url
            if (parameters != null && parameters.Count() > 0)
                url = string.Format("{0}?{1}", url, string.Join("&", parameters.Select(x => string.Format("{0}={1}", x.Key, x.Value)).ToArray()));

            return _requestManager.Get<T>(url, ifModifiedSince: ifModifiedSince);
        }
    }

    public enum Region
    {
        /// <summary>
        /// United States
        /// </summary>
        US,
        /// <summary>
        /// Europe
        /// </summary>
        EU,
        /// <summary>
        /// Korea
        /// </summary>
        KR,
        /// <summary>
        /// Taiwan
        /// </summary>
        TW
    }

    public enum Locale
    {
        en_US,
        es_MX,
        en_GB,
        fr_FR,
        ru_RU,
        de_DE,
        ko_KR,
        zh_TW,
        zh_CN
    }
}