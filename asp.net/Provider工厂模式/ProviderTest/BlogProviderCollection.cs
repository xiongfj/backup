﻿using System;
using System.Collections.Generic;
using System.Configuration.Provider;
using System.Linq;
using System.Web;

namespace ProviderTest
{
    public class BlogProviderCollection : ProviderCollection
    {
        #region Indexers

        /// <summary>
        ///     Gets a provider by its name.
        /// </summary>
        /// <param name="name">The name of the provider.</param>
        public new BlogProvider this[string name]
        {
            get
            {
                return (BlogProvider)base[name];
            }
        }

        #endregion

        #region Public Methods

        /// <summary>
        /// 必须重写
        public override void Add(ProviderBase provider)
        {
            if (provider == null)
            {
                throw new ArgumentNullException(nameof(provider));
            }

            if (!(provider is BlogProvider))
            {
                throw new ArgumentException("Invalid provider type", nameof(provider));
            }

            base.Add(provider);
        }

        #endregion
    }
}