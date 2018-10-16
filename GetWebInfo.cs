using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace DEU_Project
{
    class GetWebInfo
    {
        public string Download()
        {
            WebClient wc = new WebClient();
            return wc.DownloadString("http://prime.deu.ac.kr/prime/412/subview.do");

        }

    }
}
