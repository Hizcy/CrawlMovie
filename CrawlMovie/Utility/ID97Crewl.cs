using HtmlAgilityPack;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CrawlMovie
{
    public class ID97Crewl
    {
        public static IDModel GetMovieInforMode(string movieName)
        {
            IDModel model = null;
            //搜索页提取
            string html = HtmlHelper.DownloadHtml(HtmlHelper.idSeach + movieName);
            if (!string.IsNullOrEmpty(html))
            {
                model = new IDModel();
                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(html);///html/body/div[7]/div[1]/div/div[1]/a/img
                string xPath = "/html/body/div/div[1]/div/div[1]/a";
                HtmlNode node = doc.DocumentNode.SelectSingleNode(xPath);
                if (node != null)
                {
                    string movieUrl = node.Attributes["href"].Value; 
                    string movieId = movieUrl.Substring(movieUrl.LastIndexOf('/') + 1).Replace(".html", "");  //获取电影编号18094
                    string resquestUrl = HtmlHelper.downloadUrl + movieId;
                    string inforHtml = HtmlHelper.DownloadHtml(resquestUrl);
                    if (inforHtml != null)
                    {
                        HtmlDocument inforDoc = new HtmlDocument();
                        inforDoc.LoadHtml(inforHtml);  //  //*[@id="normalDown"]/div/table
                        string downPath = "//*[@id='normalDown']/div/table";
                        HtmlNode downNode = inforDoc.DocumentNode.SelectSingleNode(downPath);
                        if (downNode != null)
                        {
                            HtmlDocument thirdDoc = new HtmlDocument();
                            thirdDoc.LoadHtml(downNode.InnerHtml);
                            string aPath = "//a";
                            HtmlNodeCollection aNode = thirdDoc.DocumentNode.SelectNodes(aPath);
                            string downInfor = String.Empty;
                            if (aNode != null)
                            {
                                foreach (HtmlNode nodes in aNode)
                                {
                                    if (nodes.Attributes["href"].Value.IndexOf("http://pan.baidu.com/") >= 0 || nodes.Attributes["href"].Value.IndexOf("https://pan.baidu.com/s/") >= 0)
                                    {
                                        downInfor += nodes.Attributes["title"].Value + "\n百度云盘地址：" + nodes.Attributes["href"].Value + "\n";
                                    }
                                    else if (nodes.Attributes["href"].Value.IndexOf("ed2k://|file") >= 0)
                                    {
                                        downInfor += "电驴：" + nodes.Attributes["href"].Value + "\n";
                                    }
                                    else if (nodes.Attributes["href"].Value.IndexOf("magnet:?xt=urn:") >= 0)
                                    {
                                        downInfor += "磁力：" + nodes.Attributes["href"].Value + "\n";
                                    }
                                }
                            }
                            model.downURL = downInfor;
                        }
                    }
                }                 //html/body/div[7]/div[1]/div/div[1]/a/img
                string imgPath = "/html/body/div/div[1]/div/div[1]/a/img";
                HtmlNode imgNode = doc.DocumentNode.SelectSingleNode(imgPath);
                if (imgNode !=null)
                {
                    model.headImg = imgNode.Attributes["src"].Value;
                }
                string infoPath = "/html/body/div/div[1]/div/div[2]/div/p[2]";
                HtmlNode infoNode = doc.DocumentNode.SelectSingleNode(infoPath);
                if (infoNode != null)
                {
                    model.inforMessage = infoNode.InnerText;
                }
                else
                {
                    infoPath = "/html/body/div[7]/div[1]/div/div[2]/div/p[2]";
                    infoNode = doc.DocumentNode.SelectSingleNode(infoPath);
                    if (infoNode != null)
                    {
                        model.inforMessage = infoNode.InnerText;
                    }
                }
            }
            return model;
        }
    }
}
