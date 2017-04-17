using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;
namespace CrawlMovie
{
    public class DyttCrewl
    {
        public static IDModel GetMovieInfor(string url)
        {
            IDModel model = new IDModel();
            string html = HtmlHelper.DyDownloadHtml(url);
            if (!string.IsNullOrEmpty(html))
            { 
                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(html);
                //获取电影主图
                string moviePath = "//*[@id='Zoom']/span/td[1]/p[1]/img[1]";
                HtmlNode imageNode = doc.DocumentNode.SelectSingleNode(moviePath);
                if (imageNode != null)
                {
                    model.headImg = imageNode.Attributes["src"].Value;
                }
                //获取电影简介
                // //*[@id='Zoom']/span/p[1]/text()[25]
                string inforPath = "//*[@id='Zoom']/span/td[1]/p[1]";//"//*[@id='Zoom']/span/p[1]/br[28]";
                HtmlNodeCollection infoNodes = doc.DocumentNode.SelectNodes(inforPath);
                if (infoNodes != null)
                {
                    model.inforMessage = infoNodes[0].InnerText;
                }
                //获取下载路径            //*[@id="Zoom"]/span/td[1]/table/tbody/tr/td/a
                string downloadPath = "//*[@id='Zoom']/span/td[1]//p[6]/table/tbody/tr/td/a";
                HtmlNode downloadNode = doc.DocumentNode.SelectSingleNode(downloadPath);
                if (downloadNode != null)
                {
                    model.downURL = downloadNode.Attributes["href"].Value;
                } 
            }
            return model;
        } 
    }
}
