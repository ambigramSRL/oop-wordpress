using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ro.ambigram.wordpress.core
{

    public class WpBlogHeader:IWpEngineRenderer
    {
        WpLoad loader = new WpLoad();

        public void Run()
        {
            loader.Load();
            loader.functions.wp();
        }
    }

    public interface IWpEngineRenderer
    {
        void Run();
    }
}
