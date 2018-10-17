using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace DEUProject
{
    class PrimeSite
    {
        public List<MainModel> GetSite(bool bNotice = false)
        {
            WebClient wc = new WebClient();
            wc.Encoding = Encoding.UTF8;
            string str = wc.DownloadString("http://prime.deu.ac.kr/prime/412/subview.do");

            str = Regex.Split(str, "<table class=\"artclTable artclHorNum1\">")[1];
            str = Regex.Split(str, "</table>")[0];

            str = Regex.Split(str, "<tbody>")[1];
            str = Regex.Split(str, "</tbody>")[0];

            str = str.Replace("\r", string.Empty);
            str = str.Replace("\n", string.Empty);
            str = str.Replace("\t", string.Empty);
            List<string> list = Regex.Split(str, "<tr").ToList();

            List<MainModel> Result = new List<MainModel>();

            //<td class="_artclTdRdate">2018.08.27</td>
            for (int i = 1; i < list.Count; i++)
            {
                var item = list[i];
                //< tr class="headline  _artclEven">…</tr>

                if (bNotice)
                {
                    if (item.IndexOf("class=\"headline ", StringComparison.CurrentCulture) == -1)
                    {
                        continue;
                    }
                }
                else
                {
                    if (item.IndexOf("class=\"headline ", StringComparison.CurrentCulture) != -1)
                    {
                        continue;
                    }
                }
                

                string Title = Regex.Split(item, "<td class=\"_artclTdTitle\">")[1];
                string Link = "http://prime.deu.ac.kr" + Regex.Split(Title, "<a href=\"")[1].Split('\"')[0];
                Title = Regex.Split(Title, "<strong>")[1];
                Title = Regex.Split(Title, "</strong>")[0];

                string Date = Regex.Split(item, "<td class=\"_artclTdRdate\">")[1];
                Date = Regex.Split(Date, "</td>")[0];

                var y = new[] { Title, Date };

                Result.Add(new MainModel
                {
                    Title = Title,
                    Date = Date,
                    Link = Link
                });
            }

            return Result;
        }

    }
}
