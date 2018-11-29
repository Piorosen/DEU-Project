using System;
using System.Net;
using System.IO;
using System.Collections.Generic;
using System.Text.RegularExpressions;

namespace DEUProject.Server
{
    public struct LincplusSite : ISite
    {
        public List<MainModel> GetSite(bool bNotice = false, int page = 1)
        {
            List<MainModel> result = new List<MainModel>();

            HttpWebRequest request = (HttpWebRequest)WebRequest.Create($"https://lincplus.deu.ac.kr/Module/Board/Board_List.aspx?mc=28&RowNum=10&bno=3&ca1=0&ca2=0&sg=SC3&sk=&bk=&VIEW=N&PageNo={page}");
            request.Method = "GET";
            request.Referer = $"https://lincplus.deu.ac.kr/Module/Board/Board_List.aspx?mc=28&RowNum=10&bno=3&ca1=0&ca2=0&sg=SC3&sk=&bk=&VIEW=N&PageNo={page}";
            request.Accept = "text/html,application/xhtml+xml,application/xml;q=0.9,image/webp,image/apng,*/*;q=0.8";

            ServicePointManager.ServerCertificateValidationCallback += (sender, certificate, chain, sslPolicyErrors) => true;
            request.Headers.Add("authority", "lincplus.deu.ac.kr");

            using (var respond = request.GetResponse())
            {
                using (var sendRequest = new StreamReader(respond.GetResponseStream()))
                {
                    var text = sendRequest.ReadToEnd();
                    var tmp = Regex.Split(text, "<tbody>")[1];
                    var list = Regex.Split(tmp, "<tr>");
                    for (int i = 1; i < list.Length; i++)
                    {
                        MainModel model = new MainModel();

                        var b = Regex.Split(Regex.Split(list[i], "javascript:document.location.href='")[1], "';\"");

                        tmp = b[0];
                        text = b[1];

                        model.Link = $"https://lincplus.deu.ac.kr/Module/Board/{tmp}";
                        tmp = text.Remove(0, 2);
                        tmp = Regex.Split(tmp, "</a>")[0];

                        model.Title = tmp;
                        model.Date = Regex.Split(Regex.Split(text, "<td class='text-center'>")[2], "</td>")[0];

                        result.Add(model);
                    }
                }
            }

            return result;

        }

    }
}

/*
 * https://lincplus.deu.ac.kr/Module/Board/Board_List.aspx?mc=28&RowNum=10&bno=3&ca1=0&ca2=0&sg=SC3&sk=&bk=&VIEW=N&PageNo=2
 * https://lincplus.deu.ac.kr/Module/Board/Board_List.aspx?mc=28&RowNum=10&bno=3&ca1=0&ca2=0&sg=SC3&sk=&bk=&VIEW=N&PageNo=3
 * 
 */
