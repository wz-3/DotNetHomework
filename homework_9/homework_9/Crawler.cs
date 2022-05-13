using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;


    namespace homework_9
{
        class Crawler
        {
            private Hashtable urls = new Hashtable();
            private int count =0 ;
            public Dictionary<string,bool> DownloadPages { get; } = new Dictionary<string, bool>();
            private Queue<string> waiting = new Queue<string>();
            public string startUrl;
            public Action<string,string> IsSuccssed;
            public Action<string, string> Download;
            public int amount { get; set; }
            
            public void Crawl()
            {
              amount = 10;
              Console.WriteLine("开始爬行了.... ");
                while (count<=amount&&waiting.Count>0)
                {
                    string current = null;
                    foreach (string url in urls.Keys)
                    {
                        if ((bool)urls[url]) continue;
                        current = url;
                    }
                    Console.WriteLine("爬行" + current + "页面!");
                string html = null;
                try
                {
                    html = DownLoad(current); // 下载
                }
                catch(Exception ex)
                {
                    IsSuccssed(current, "爬取失败" + ex.Message);
                }
                    urls[current] = true;
                    count++;
                    Parse(html);//解析,并加入新的链接
                   IsSuccssed(current, "爬取成功");
                }
            }

            public string DownLoad(string url)
            {
                try
                {
                    WebClient webClient = new WebClient();
                    webClient.Encoding = Encoding.UTF8;
                    string html = webClient.DownloadString(url);
                    string fileName = count.ToString();
                    File.WriteAllText(fileName, html, Encoding.UTF8);
                    return html;
                }
                catch (Exception ex)
                {
                    Console.WriteLine(ex.Message);
                    return "";
                }
            }

            private void Parse(string html)
            {
                string strRef = @"(href|HREF)[]*=[]*[""'][^""'#>]+[""']";
                MatchCollection matches = new Regex(strRef).Matches(html);
                foreach (Match match in matches)
                {
                    strRef = match.Value.Substring(match.Value.IndexOf('=') + 1)
                              .Trim('"', '\"', '#', '>');
                    if (strRef.Length == 0) continue;
                    if (urls[strRef] == null) urls[strRef] = false;
                }
            }
     
        }
    }
