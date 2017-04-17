using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using HtmlAgilityPack;

namespace CrawlMovie
{
    public class WXCrewl
    {
        public static IDModel GetMovieInfor(string movieName)
        {
            IDModel model = null;
            string searchUrl = HtmlHelper.wsSearchUrl + movieName;
            string html = HtmlHelper.DownloadHtml(searchUrl);
            if (!string.IsNullOrEmpty(html))
            {
                HtmlDocument doc = new HtmlDocument();
                doc.LoadHtml(html);
                string wsMoviePath = "/html/body/div[3]/div[2]/ul/li[1]/a";
                HtmlNode htmlnode = doc.DocumentNode.SelectSingleNode(wsMoviePath);
                if (htmlnode != null)
                {
                    string apathUrl = htmlnode.Attributes["href"].Value;
                    string resourceUrl = HtmlHelper.wsDownloadUrl + apathUrl;
                    string resourceHtml = HtmlHelper.DownloadHtml(resourceUrl);
                    if (!string.IsNullOrEmpty(resourceHtml))
                    {
                        HtmlDocument resourceDoc = new HtmlDocument();
                        resourceDoc.LoadHtml(resourceHtml);
                        model = new IDModel();
                        //收看地址          //*[@id="jisuayun"]/div/ul/li[1]/a  //*[@id="wuxingyun"]/div/ul/li/a
                        string lookPath = "//*[@id='wuxingyun']/div/ul/li/a";
                        HtmlNode linkNode = resourceDoc.DocumentNode.SelectSingleNode(lookPath);
                        if (linkNode != null)
                        {
                            model.downURL = HtmlHelper.wsDownloadUrl + linkNode.Attributes["href"].Value;
                        }
                        else
                        {
                            lookPath = "//*[@id='jisuayun']/div/ul/li[1]/a";
                            linkNode = resourceDoc.DocumentNode.SelectSingleNode(lookPath);
                            if (linkNode != null)
                            {
                                model.downURL = HtmlHelper.wsDownloadUrl + linkNode.Attributes["href"].Value;
                            }
                            else
                            {
                                lookPath = "//*[@id='mgtv']/div/ul/li/a";
                                linkNode = resourceDoc.DocumentNode.SelectSingleNode(lookPath);
                                if (linkNode != null)
                                {
                                    model.downURL = HtmlHelper.wsDownloadUrl + linkNode.Attributes["href"].Value;
                                }
                            }
                        }
                        //图片地址
                        string imagePath = "/html/body/div[3]/div[3]/div[4]/div[1]/img";
                        HtmlNode imageNode = resourceDoc.DocumentNode.SelectSingleNode(imagePath);
                        if (imageNode != null)
                        {
                            if (imageNode.Attributes.Contains("data-original"))
                                model.headImg = imageNode.Attributes["data-original"].Value;
                            else if (imageNode.Attributes.Contains("original"))
                                model.headImg = imageNode.Attributes["original"].Value;
                            else if (imageNode.Attributes.Contains("src"))
                                model.headImg = imageNode.Attributes["src"].Value;
                        }
                        //简介
                        string inforPath = "/html/body/div[3]/div[3]/div[4]/div[2]/div[2]/dl[2]/dd/p";
                        HtmlNode inforNode = resourceDoc.DocumentNode.SelectSingleNode(inforPath);
                        if (inforNode != null)
                        {
                            model.inforMessage = "简介：" + inforNode.InnerHtml;
                        }
                    }
                }
            }
            return model;
        }
    }
}
