using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Net;
using System.Collections;
using System.Text.RegularExpressions;
using System.Threading;
using System.Diagnostics;

namespace crawl
{
    class program
    {
        static void Main(string[] args)
        {
            Crawler myCrawler_1 = new Crawler();
            string startUrl = "http://www.4399.com";
            if (args.Length >= 1) startUrl = args[0];
            myCrawler_1.urls.Add(startUrl, false);
            Crawler myCrawler_2 = new Crawler();
            string startUr2 = "http://www.baidu.com";
            if (args.Length >= 1) startUr2 = args[0];
            myCrawler_2.urls.Add(startUr2, false);
            //Crawler myCrawler_3 = new Crawler();
            //string startUr3 = "http://www.iqiyi.com";
            //if (args.Length >= 1) startUr3 = args[0];
            //myCrawler_3.urls.Add(startUrl, false);
            Task<int>[] tasks =
            {
                Task.Run(()=>myCrawler_1.Crawl()),
                Task.Run(()=>myCrawler_2.Crawl())
                //Task.Run(()=>myCrawler_3.Crawl())
            };
            //new Thread(myCrawler_1.Crawl).Start();
            //new Thread(myCrawler_2.Crawl).Start();
            Console.ReadKey();
        }
    }
    class Crawler
    {
        public Hashtable urls = new Hashtable();
        private int count = 0;
        //static void Main(string[] args)
        //{
        //    Crawler myCrawler_1 = new Crawler(); 
        //    string startUrl = "http://www.4399.com";
        //    if (args.Length >= 1) startUrl = args[0];
        //    myCrawler_1.urls.Add(startUrl, false);
        //    Crawler myCrawler_2 = new Crawler();
        //    string startUr2 = "http://www.baidu.com";
        //    if (args.Length >= 1) startUr2 = args[0];
        //    myCrawler_2.urls.Add(startUrl, false);
        //    Task<int>[] tasks =
        //    {
        //        Task.Run(()=>myCrawler_1.Crawl()),
        //        Task.Run(()=>myCrawler_2.Crawl())
        //    };
        //    //new Thread(myCrawler_1.Crawl).Start();
        //    //new Thread(myCrawler_2.Crawl).Start();
        //    Console.ReadKey();
        //}
        public int Crawl()
        {
            Console.WriteLine("开始爬虫了。。。");
            while (true)
            {
                string current = null;
                foreach (string url in urls.Keys)
                {
                    if ((bool)urls[url]) continue;
                    current = url;
                }
                if (current == null || count > 10) break;
                Console.WriteLine("爬行" + current + "页面！");
                string html = DownLoad(current);
                urls[current] = true;
                count++;
                Parse(html);
            }
            Console.WriteLine("爬行结束");
            return 0;
        }
        public string DownLoad(string url)
        {
            try
            {
                WebClient webClient = new WebClient();
                webClient.Encoding = Encoding.UTF8;
                string html = webClient.DownloadString(url);
                string filename = count.ToString();
                File.WriteAllText(filename, html, Encoding.UTF8);
                return html;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                return "";
            }
        }
        public void Parse(string html)
        {
            string strRef = @"(href|HREF) [] * = [] * [""'][^""'#>]+[""']";
            MatchCollection matches = new Regex(strRef).Matches(html);
            foreach (Match match in matches)
            {
                strRef = match.Value.Substring(match.Value.IndexOf('=') + 1).Trim('"', '\"', '#', ' ', '>');

                if (strRef.Length == 0) continue;
                if (urls[strRef] == null) urls[strRef] = false;
            }
        }
    }
}
