using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.IO;

namespace DEUProject.Server
{
    class DapSite
    {
        public List<MainModel> GetSite(bool bNotice = false)
        {
            WebClient wc = new WebClient
            {
                Encoding = Encoding.UTF8
            };

            string link = "http://dap.deu.ac.kr/DapNoticeList.aspx";

            string str = wc.DownloadString(link);

            str = Regex.Split(str, "<tbody>")[1];
            str = Regex.Split(str, "</tbody>")[0];

            var items = Regex.Split(str, "<tr>").ToList();
            items.RemoveAt(0);

            List<MainModel> Result = new List<MainModel>();

            foreach (var item in items)
            {
                MainModel nowarp = new MainModel();
                var IsTol = Regex.Split(Regex.Split(item, "<td class=\"text-nowrap\">")[1], "</td>")[0];
                if (IsTol.IndexOf("공지", StringComparison.CurrentCulture) != -1)
                {
                    if (!bNotice)
                    {
                        continue;
                    }
                }
                var i = Regex.Split(Regex.Split(item, "<td class=\"text-left\">")[1], "</td>")[0];
                nowarp.Link = Regex.Split(i, "<a href=\"")[1].Split('\"')[0];

                nowarp.Title = Regex.Split(i.Split('>')[1], "</a")[0];
                
                nowarp.Date = Regex.Split(item, "<td class=\"text-center\">")[2].Split('<')[0];

                Result.Add(nowarp);
            }
            return Result;
        }
    }
}
