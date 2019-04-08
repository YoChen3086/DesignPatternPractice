using System;
using System.Collections;
using System.Collections.Generic;
using System.Text;

namespace Flyweight
{
   public class WebSiteFactory
    {
        private Hashtable webSites = new Hashtable();

        // 獲得網站分類
        public WebSite GetWebSiteCategory(string key)
        {
            if (!webSites.ContainsKey(key))
            {
                webSites.Add(key, new ConcreteWebSite(key));
            }

            return (WebSite)webSites[key];
        }

        // 獲得網站分類總數
        public int GetWebStieCount()
        {
            return webSites.Count;
        }
    }
}
