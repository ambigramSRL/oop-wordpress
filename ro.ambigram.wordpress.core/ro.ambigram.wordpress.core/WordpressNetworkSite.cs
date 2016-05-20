using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ro.ambigram.wordpress.core
{
    /// <summary>
    /// this 
    /// </summary>
    public class WordpressNetworkSite:IWebSiteRequestProcessator
    {
        public static WordpressNetworkSite Default{
            get;set;
        }
        public static WordpressNetworkSite DefaultAdmin
        {
            get
            {
                return Default.Admin;
            }
            private set
            {

            }
        }

        public  WordpressNetworkSite Admin
        {
            get;set;
        }
    }

    public interface IWebSiteRequestProcessator
    {
         WordpressNetworkSite Admin
        {
            get;
        }
    }
}