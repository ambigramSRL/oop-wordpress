using ro.ambigram.wordpress.core.common;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ro.ambigram.wordpress.core
{
    public class WordpressConfig: WpCfgBase { 
        private static WordpressConfig _single;

        public WordpressConfig()
        {
            if (_single!=null)
            {
                throw new Exception("Multiple Instance not allowed");
            }

        }

        public static WordpressConfig Default { get
            {
                if (_single == null)
                {
                    _single = new WordpressConfig();
                }
                return _single;
            }
            private set { } }
    }
}
