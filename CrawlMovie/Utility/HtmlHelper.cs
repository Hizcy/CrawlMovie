using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Configuration;
namespace CrawlMovie
{
    public class HtmlHelper
    {
        //豆瓣
        public static string DBYear= ConfigurationManager.AppSettings["DBYear"];
        public static string DBOrder = ConfigurationManager.AppSettings["DBOrder"];
        public static string Showing = ConfigurationManager.AppSettings["Showing"];
        public static string Coming = ConfigurationManager.AppSettings["Coming"]; 
        public static string Top = ConfigurationManager.AppSettings["Top"];
        //id97
        public static string idSeach = ConfigurationManager.AppSettings["idSeach"];
        public static string downloadUrl = ConfigurationManager.AppSettings["DownloadUrl"];
        //五杀
        public static string wsSearchUrl = ConfigurationManager.AppSettings["wsSearch"];
        public static string wsDownloadUrl = ConfigurationManager.AppSettings["wsDownloadUrl"];
        public static string DownloadHtml(string url)
        {
            return DownloadHtml(url, System.Text.Encoding.UTF8);
        }

        public static string DyDownloadHtml(string url)
        {
            return DownloadHtml(url, System.Text.Encoding.Default);
        }
        /// <summary>
        /// 下载html
        /// </summary>
        /// <param name="url">下载路径</param>
        /// <param name="encode">编码</param>
        /// <returns></returns>
        public static string DownloadHtml(string url, System.Text.Encoding encoding)
        {
            string html = String.Empty;
            try
            {
                HttpWebRequest request = HttpWebRequest.Create(url) as HttpWebRequest;//模拟请求
                request.Timeout = 60 * 1000;//设置60s的超时
                request.ContentType = "text/html; charset=utf-8";
                //发起请求
                using (HttpWebResponse response = request.GetResponse() as HttpWebResponse)
                {
                    if (response.StatusCode == HttpStatusCode.OK)
                    {
                        try
                        {
                            StreamReader sr = new StreamReader(response.GetResponseStream(), encoding);
                            html = sr.ReadToEnd();//读取数据
                            sr.Close();
                        }
                        catch (Exception ex)
                        {
                            html = null;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                html = null;
            }
            return html;
        }
        /// <summary>
        /// 从指定的URL下载页面内容(使用WebClient)
        /// </summary>
        /// <param name="url"></param> 
        /// <returns></returns>
        public static string LoadPageContent(string url)
        {
            WebClient wc = new WebClient();
            wc.Credentials = CredentialCache.DefaultCredentials;
            byte[] pageData = wc.DownloadData(url); 
            return (Encoding.GetEncoding("utf-8").GetString(pageData)); 
        }
    }
}
