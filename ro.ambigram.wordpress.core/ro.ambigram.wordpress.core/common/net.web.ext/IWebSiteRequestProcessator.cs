using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ro.ambigram.wordpress.core.common.net.web.ext
{
    /// <summary>
    /// expose functions that are specified to a website component
    /// for example is on top of mvc top element -> route parser
    /// 
    /// for example, the main site of wordpress is able to instantiate the required site from site "network"
    /// based on request processing
    /// </summary>
    public interface IWebSiteRequestProcessator
    {
        /// <summary>
        /// each site must be able to provide the original 
        /// </summary>
        /// <returns></returns>
        UriBuilder RequestURI
        {
            get;
            
        }
    }
}
